using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizador_tareas
{
    class EstadoGlobal
    {
        public static List<ArbolTareas> arboles;
        public static ArbolTareas arbolActual;
        public static Stack<NodoTarea> tareas;
    }
}
