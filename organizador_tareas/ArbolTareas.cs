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
            NodoTarea nuevaTarea = new NodoTarea(nombre, fechaVencimiento);

            if (nodoPadre == null)
            {
                raiz = nuevaTarea;
                return;
            }

            nodoPadre.subTareas.Add(nuevaTarea);
        }

        public void MostrarTareas(NodoTarea nodoActual, int nivel = 0)
        {
            if (nodoActual != null)
            {
                Console.WriteLine(new string(' ', nivel * 4) + "- " + nodoActual.nombre + " (" + nodoActual.fechaVencimiento.ToString("dd/MM/yyyy") + ")");

                foreach (NodoTarea subTarea in nodoActual.subTareas)
                {
                    MostrarTareas(subTarea, nivel + 1);
                }
            }
        }

        public bool EliminarTarea(NodoTarea nodoActual, string nombre)
        {
            if (nodoActual == null) return false;
            foreach (NodoTarea subTarea in nodoActual.subTareas)
            {
                if (subTarea.nombre == nombre)
                {
                    nodoActual.subTareas.Remove(subTarea);
                    return true;
                }
                else
                {
                    bool eliminado = EliminarTarea(subTarea, nombre);
                    if (eliminado) return true;
                }
            }
            return false;
        }
    }
}
