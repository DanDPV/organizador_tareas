﻿using System;
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

        public double porcentajeProgreso
        {
            get
            {
                double porcentaje = 0;
                double totalCompletos = 0;
                foreach(NodoTarea tarea in this.subTareas)
                {
                    if (tarea.completado == 1)
                    {
                        totalCompletos++;
                    }
                }
                if (totalCompletos > 0)
                {
                    porcentaje = totalCompletos / this.subTareas.Count();
                } else
                {
                    porcentaje = this.completado;
                }
                return porcentaje;
            }
        }

        public string porcentajeProgresoFormateado
        {
            get
            {
                string porcentaje = (this.porcentajeProgreso * 100).ToString("N2") + "%";
                return porcentaje;
            }
        }
    }
}
