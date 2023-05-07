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
                int idTareaRaiz = ArbolTareasRepository.AgregarTarea(nuevaTarea);
                if (idTareaRaiz == -1)
                {
                    throw new Exception("No se pudo agregar la tarea");
                }
                nuevaTarea.id = idTareaRaiz;
                raiz = nuevaTarea;
                return;
            }

            int idTarea = ArbolTareasRepository.AgregarTarea(nuevaTarea, nodoPadre.id);
            if (idTarea == -1)
            {
                throw new Exception("No se pudo agregar la tarea");
            }
            nuevaTarea.id = idTarea;

            nodoPadre.subTareas.Add(nuevaTarea);
        }

        public bool EliminarTarea(NodoTarea nodoEliminar, NodoTarea nodoPadre)
        {
            if (nodoEliminar == null) return false;
            if (nodoEliminar.subTareas.Count > 0)
            {
                foreach (NodoTarea subTarea in nodoEliminar.subTareas.ToList())
                {
                    EliminarTarea(subTarea, nodoEliminar);
                }
            }

            if (nodoPadre == null)
            {
                int posicionNodo = 0;

                foreach (ArbolTareas arbol in EstadoGlobal.arboles)
                {
                    if (arbol.raiz.id == nodoEliminar.id)
                    {
                        break;
                    }
                    posicionNodo++;
                }

                EstadoGlobal.arboles.RemoveAt(posicionNodo);
            } else
            {
                int posicionNodo = 0;

                foreach (NodoTarea tarea in nodoPadre.subTareas)
                {
                    if (tarea.id == nodoEliminar.id)
                    {
                        break;
                    }
                    posicionNodo++;
                }

                nodoPadre.subTareas.RemoveAt(posicionNodo);
            }

            ArbolTareasRepository.EliminarTarea(nodoEliminar.id);

            return true;
        }

        public bool ModificarTarea(NodoTarea nodoModificar, NodoTarea referenciaNodo)
        {
            if (nodoModificar == null || referenciaNodo == null) return false;

            ArbolTareasRepository.ModificarTarea(referenciaNodo.id, nodoModificar);

            referenciaNodo.nombre = nodoModificar.nombre;
            referenciaNodo.fechaVencimiento = nodoModificar.fechaVencimiento;
            referenciaNodo.completado = nodoModificar.completado;

            return true;
        }
    }
}
