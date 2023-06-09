﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organizador_tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<NodoTarea> tareasRaiz;
        bool modificarTarea = false;
        NodoTarea modificarNodoTarea;
        public delegate void ActualizarTareasPrincipales();

        private void btnAddTarea_Click(object sender, EventArgs e)
        {
            BorrarMesaje();
            if (validarCampos()) {
                if (!modificarTarea)
                {
                    ArbolTareas arbol = new ArbolTareas();
                    arbol.AgregarTarea(txtNombre.Text, dtpFechaVencimiento.Value, null);

                    EstadoGlobal.arboles.Add(arbol);
                    tareasRaiz.Add(arbol.raiz);
                    actualizarGridView();
                    txtNombre.Clear();
                    dtpFechaVencimiento.Value = DateTime.Today;
                } else
                {
                    NodoTarea nodoTarea = new NodoTarea(-1, txtNombre.Text, dtpFechaVencimiento.Value);
                    ArbolTareas arbol = new ArbolTareas();
                    arbol.ModificarTarea(nodoTarea, modificarNodoTarea);
                    actualizarGridView();
                    modificarTarea = false;
                    modificarNodoTarea = null;
                    txtNombre.Clear();
                    dtpFechaVencimiento.Value = DateTime.Today;
                    btnModificarTarea.Text = "Modificar Tarea";
                    btnAddTarea.Text = "Agregar Tarea";
                    groupBoxFormulario.Text = "Agregar tarea";
                }
            }
        }

        private void actualizarGridView()
        {
            if (dgvTareas.Columns.Count == 0)
            {
                if (tareasRaiz.Count > 0)
                {
                    DataGridViewColumn colNombre = new DataGridViewTextBoxColumn();
                    colNombre.DataPropertyName = "nombre";
                    colNombre.HeaderText = "Nombre";
                    dgvTareas.Columns.Add(colNombre);

                    DataGridViewColumn colFecha = new DataGridViewTextBoxColumn();
                    colFecha.DataPropertyName = "fechaVencimiento";
                    colFecha.HeaderText = "Fecha de Vencimiento";
                    dgvTareas.Columns.Add(colFecha);

                    DataGridViewColumn colCompletado = new DataGridViewTextBoxColumn();
                    colCompletado.DataPropertyName = "completado";
                    colCompletado.HeaderText = "Completado";
                    dgvTareas.Columns.Add(colCompletado);

                    DataGridViewColumn colPorcentaje = new DataGridViewTextBoxColumn();
                    colPorcentaje.DataPropertyName = "porcentajeProgresoFormateado";
                    colPorcentaje.HeaderText = "Porcentaje Progreso";
                    dgvTareas.Columns.Add(colPorcentaje);
                }
            }
            if (tareasRaiz.Count > 0)
            {
                dgvTareas.DataSource = null;
                dgvTareas.DataSource = tareasRaiz;

                foreach (DataGridViewRow row in dgvTareas.Rows)
                {
                    NodoTarea tarea = (NodoTarea)row.DataBoundItem;
                    row.Cells[0].Value = tarea.nombre;
                    row.Cells[1].Value = tarea.fechaVencimiento.ToShortDateString();
                    if (tarea.completado == 1)
                    {
                        row.Cells[2].Value = "Sí";
                    } else
                    {
                        row.Cells[2].Value = "No";
                    }
                    row.Cells[3].Value = tarea.porcentajeProgresoFormateado;
                }
            }
            else
            {
                dgvTareas.DataSource = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tareasRaiz = new List<NodoTarea>();
            EstadoGlobal.arboles = new List<ArbolTareas>();
            dgvTareas.AutoGenerateColumns = false;

            tareasRaiz = ArbolTareasRepository.ObtenerTareasPrincipales();
            foreach (NodoTarea tarea in tareasRaiz)
            {
                ArbolTareas arbol = new ArbolTareas();
                arbol.raiz = tarea;

                EstadoGlobal.arboles.Add(arbol);
            }
            actualizarGridView();
        }

        private void dgvTareas_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvTareas.SelectedRows[0];
            int posicion = dgvTareas.Rows.IndexOf(selected);

            NodoTarea tarea = tareasRaiz[posicion];
            ArbolTareas arbol = EstadoGlobal.arboles[posicion];
            EstadoGlobal.tareas = new Stack<NodoTarea>();
            EstadoGlobal.tareas.Push(tarea);
            EstadoGlobal.arbolActual = arbol;

            VerSubtarea verSubtarea = new VerSubtarea(actualizarGridView);
            verSubtarea.Show();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvTareas.SelectedRows[0];
            int posicion = dgvTareas.Rows.IndexOf(selected);

            NodoTarea tarea = tareasRaiz[posicion];
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la tarea " + tarea.nombre + " y todas sus subtareas?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                ArbolTareas arbol = new ArbolTareas();
                arbol.EliminarTarea(tarea, null);
                int posicionNodo = 0;

                foreach (NodoTarea nodo in tareasRaiz)
                {
                    if (tarea.id == nodo.id)
                    {
                        break;
                    }
                    posicionNodo++;
                }

                tareasRaiz.RemoveAt(posicionNodo);
                actualizarGridView();
            }
        }

        private bool validarCampos()
        {
            bool validado = true;

            DateTime fecha = DateTime.Today;  //Extrae fecha actual
            if (txtNombre.Text == "") //vefica que no quede vacío el campo
            {
                validado = false; //si está vacío validado es falso
                errorProvider1.SetError(txtNombre, "Ingresar nombre"); //manda a llamar a errorprovider
                                                                       //en los parámetros de setError se identifica a quién se esta validando y el mensaje a mostrar
            }
            if(dtpFechaVencimiento.Value.Date < fecha) //Compara que la fecha ingresada no sea menor a la actual
            {
                validado = false;
                errorProvider1.SetError(dtpFechaVencimiento, "Ingresar una fecha valida, no menor a la actual");
             
            }

            return validado;
        }
        private void BorrarMesaje()
        {
            //borra los mensajes para que no se muestren y pueda limpiar
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(dtpFechaVencimiento, "");
        }

        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            if (modificarTarea == false)
            {
                modificarTarea = true;
                btnModificarTarea.Text = "Cancelar Modificar Tarea";
                btnAddTarea.Text = "Modificar Tarea";
                DataGridViewRow selected = dgvTareas.SelectedRows[0];
                int posicion = dgvTareas.Rows.IndexOf(selected);

                modificarNodoTarea = tareasRaiz[posicion];

                groupBoxFormulario.Text = "Modificar tarea";
                txtNombre.Text = modificarNodoTarea.nombre;
                dtpFechaVencimiento.Value = modificarNodoTarea.fechaVencimiento;
            } else
            {
                modificarTarea = false;
                modificarNodoTarea = null;
                txtNombre.Clear();
                dtpFechaVencimiento.Value = DateTime.Today;
                btnModificarTarea.Text = "Modificar Tarea";
                btnAddTarea.Text = "Agregar Tarea";
                groupBoxFormulario.Text = "Agregar tarea";
            }
        }

        private void btnCompletarTarea_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvTareas.SelectedRows[0];
            int posicion = dgvTareas.Rows.IndexOf(selected);

            NodoTarea tarea = tareasRaiz[posicion];
            if (tarea.completado == 0)
            {
                tarea.completado = 1;
            } else
            {
                tarea.completado = 0;
            }

            ArbolTareas arbol = new ArbolTareas();
            arbol.ModificarTarea(tarea, tarea);
            actualizarGridView();
        }
    }
}
