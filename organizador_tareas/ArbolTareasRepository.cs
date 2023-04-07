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
                SqlCommand comando = new SqlCommand("INSERT INTO Tarea (nombre, fecha_vencimiento) VALUES (@nombre, @fechaVencimiento); SELECT SCOPE_IDENTITY();", conexion);
                comando.Parameters.AddWithValue("@nombre", nuevaTarea.nombre);
                comando.Parameters.AddWithValue("@fechaVencimiento", nuevaTarea.fechaVencimiento);
                idTarea = Convert.ToInt32(comando.ExecuteScalar());
            }

            // Insertar el registro de la relación entre las tareas en la tabla "Relacion_Tarea"
            if (idTareaPadre != -1)
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO Relacion_Tarea (id_tarea_padre, id_tarea_hija) VALUES (@idTareaPadre, @idTareaHija);", conexion);
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
                SqlCommand comando = new SqlCommand("SELECT id, nombre, fecha_vencimiento, completado FROM Tarea A LEFT JOIN Relacion_Tareas B ON B.id_tarea_hija = A.id WHERE B.id_tarea_padre is null;", conexion);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    NodoTarea subTarea = new NodoTarea(Convert.ToInt32(lector["id"]), Convert.ToString(lector["nombre"]), Convert.ToDateTime(lector["fecha_vencimiento"]));
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
    }
}
