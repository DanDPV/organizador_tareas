using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace organizador_tareas
{
    class ArbolTareasRepository
    {
        private static string cadenaConexion = "Data Source=localhost;Initial Catalog=organizador_tareas;Integrated Security=True;";
        public static int AgregarTarea(NodoTarea nuevaTarea, int idTareaPadre = -1)
        {
            int idTarea = -1;

            // Insertar el registro de la tarea en la tabla "Tarea"
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO Tarea (nombre, fecha_vencimiento, completado) VALUES (@nombre, @fechaVencimiento, @completado); SELECT SCOPE_IDENTITY();", conexion);
                comando.Parameters.AddWithValue("@nombre", nuevaTarea.nombre);
                comando.Parameters.AddWithValue("@fechaVencimiento", nuevaTarea.fechaVencimiento);
                comando.Parameters.AddWithValue("@completado", nuevaTarea.completado);
                idTarea = Convert.ToInt32(comando.ExecuteScalar());
            }

            // Insertar el registro de la relación entre las tareas en la tabla "Relacion_Tareas"
            if (idTareaPadre != -1)
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO Relacion_Tareas (id_tarea_padre, id_tarea_hija) VALUES (@idTareaPadre, @idTareaHija);", conexion);
                    comando.Parameters.AddWithValue("@idTareaPadre", idTareaPadre);
                    comando.Parameters.AddWithValue("@idTareaHija", idTarea);
                    comando.ExecuteNonQuery();
                }
            }

            return idTarea;
        }

        public static List<NodoTarea> ObtenerSubtareas(int idTareaActual)
        {
            // Obtener los registros de la tabla "Tarea" que corresponden a las sub-tareas de la tarea actual
            List<NodoTarea> subTareas = new List<NodoTarea>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT id, nombre, fecha_vencimiento, completado FROM Tarea WHERE id IN (SELECT id_tarea_hija FROM Relacion_Tareas WHERE id_tarea_padre = @idTareaActual);", conexion);
                comando.Parameters.AddWithValue("@idTareaActual", idTareaActual);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    NodoTarea subTarea = new NodoTarea(Convert.ToInt32(lector["id"]), Convert.ToString(lector["nombre"]), Convert.ToDateTime(lector["fecha_vencimiento"]));
                    subTarea.completado = Convert.ToInt32(lector["completado"]);
                    subTareas.Add(subTarea);
                }
                lector.Close();
            }

            // Obtener las sub-tareas recursivamente
            foreach (NodoTarea subTarea in subTareas)
            {
                subTarea.subTareas = ObtenerSubtareas(subTarea.id);
            }

            return subTareas;
        }

        public static List<NodoTarea> ObtenerTareasPrincipales()
        {
            // Obtener los registros de la tabla "Tarea" que corresponden a las tareas principales
            List<NodoTarea> tareas = new List<NodoTarea>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT id, nombre, fecha_vencimiento, ISNULL ( completado , 0 ) as completado FROM Tarea A LEFT JOIN Relacion_Tareas B ON B.id_tarea_hija = A.id WHERE B.id_tarea_padre is null;", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    NodoTarea subTarea = new NodoTarea(Convert.ToInt32(lector["id"]), Convert.ToString(lector["nombre"]), Convert.ToDateTime(lector["fecha_vencimiento"]));
                    subTarea.completado = Convert.ToInt32(lector["completado"]);
                    tareas.Add(subTarea);
                }
                lector.Close();
            }

            // Obtener las sub-tareas recursivamente
            foreach (NodoTarea tarea in tareas)
            {
                tarea.subTareas = ObtenerSubtareas(tarea.id);
            }

            return tareas;
        }

        public static void EliminarTarea(int idTarea)
        {
            // Eliminar los registros de la tabla "Relacion_Tareas" que corresponden a la tarea actual y a sus sub-tareas
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("DELETE FROM Relacion_Tareas WHERE id_tarea_padre = @idTarea OR id_tarea_hija = @idTarea;", conexion);
                comando.Parameters.AddWithValue("@idTarea", idTarea);
                comando.ExecuteNonQuery();
            }

            // Eliminar los registros de la tabla "Tarea" que corresponden a la tarea actual y a sus sub-tareas
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("DELETE FROM Tarea WHERE id = @idTarea;", conexion);
                comando.Parameters.AddWithValue("@idTarea", idTarea);
                comando.ExecuteNonQuery();
            }
        }

        public static bool ModificarTarea(int idNuevaTarea, NodoTarea nodoModificar)
        {

            // Insertar el registro de la tarea en la tabla "Tarea"
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("UPDATE Tarea SET nombre = @nuevoNombre, fecha_vencimiento = @nuevaFechaVencimiento, completado = @completado WHERE id = @idTarea;", conexion);
                comando.Parameters.AddWithValue("@nuevoNombre", nodoModificar.nombre);
                comando.Parameters.AddWithValue("@nuevaFechaVencimiento", nodoModificar.fechaVencimiento);
                comando.Parameters.AddWithValue("@completado", nodoModificar.completado);
                comando.Parameters.AddWithValue("@idTarea", idNuevaTarea);
                comando.ExecuteNonQuery();
            }

            return true;
        }
    }
}
