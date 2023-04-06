using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizador_tareas
{
    class NodoTarea
    {
        public string nombre;
        public DateTime fechaVencimiento;
        public List<NodoTarea> subTareas;

        public NodoTarea(string nombre, DateTime fechaVencimiento)
        {
            this.nombre = nombre;
            this.fechaVencimiento = fechaVencimiento;
            subTareas = new List<NodoTarea>();
        }
    }
}
