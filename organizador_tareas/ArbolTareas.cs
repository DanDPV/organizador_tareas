using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizador_tareas
{
    class ArbolTareas
    {
        public NodoTarea raiz;

        public ArbolTareas()
        {
            raiz = null;
        }

        public void AgregarTarea(string nombre, DateTime fechaVencimiento, NodoTarea nodoPadre)
        {
            NodoTarea nuevaTarea = new NodoTarea(1, nombre, fechaVencimiento);

            if (nodoPadre == null)
            {
                raiz = nuevaTarea;
                return;
            }

            nuevaTarea.id = nodoPadre.subTareas.Count + 1;

            nodoPadre.subTareas.Add(nuevaTarea);
        }

        public bool EliminarTarea(NodoTarea nodoActual, int id)
        {
            if (nodoActual == null) return false;
            foreach (NodoTarea subTarea in nodoActual.subTareas)
            {
                if (subTarea.id == id)
                {
                    nodoActual.subTareas.Remove(subTarea);
                    return true;
                }
                else
                {
                    bool eliminado = EliminarTarea(subTarea, id);
                    if (eliminado) return true;
                }
            }
            return false;
        }
    }
}
