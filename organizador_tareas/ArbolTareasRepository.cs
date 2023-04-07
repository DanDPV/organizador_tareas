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
    }
}
