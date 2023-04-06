using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizador_tareas
{
    class NodoTarea
    {
        public int id;
        public string nombre;
        public DateTime fechaVencimiento;
        public List<NodoTarea> subTareas;
        public int completado;

        public NodoTarea(int id, string nombre, DateTime fechaVencimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechaVencimiento = fechaVencimiento;
            subTareas = new List<NodoTarea>();
            this.completado = 0;
        }
    }
}
