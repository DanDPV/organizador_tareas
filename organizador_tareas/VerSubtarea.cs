using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organizador_tareas
{
    public partial class VerSubtarea : Form
    {
        public VerSubtarea()
        {
            InitializeComponent();
        }

        List<NodoTarea> tareasRaiz;

        private void VerSubtarea_Load(object sender, EventArgs e)
        {
            tareasRaiz = new List<NodoTarea>();
            dgvTareas.AutoGenerateColumns = false;
            tareasRaiz = EstadoGlobal.tareas.Peek().subTareas;
            lblNombreTarea.Text = EstadoGlobal.tareas.Peek().nombre;
            actualizarGridView();
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
                }
            } else
            {
                dgvTareas.DataSource = null;
            }
        }

        private void btnAddTarea_Click(object sender, EventArgs e)
        {
            BorrarMesaje();
            if (validarCampos())
            {
                EstadoGlobal.arbolActual.AgregarTarea(txtNombre.Text, dtpFechaVencimiento.Value, EstadoGlobal.tareas.Peek());
                actualizarGridView();
                dgvTareas.DataSource = EstadoGlobal.tareas.Peek().subTareas;
            }
          
        }

        private void dgvTareas_DoubleClick(object sender, EventArgs e)
        {
             DataGridViewRow selected = dgvTareas.SelectedRows[0];
             int posicion = dgvTareas.Rows.IndexOf(selected);

             NodoTarea tarea = tareasRaiz[posicion];
             EstadoGlobal.tareas.Push(tarea);

             tareasRaiz = EstadoGlobal.tareas.Peek().subTareas;
             lblNombreTarea.Text = EstadoGlobal.tareas.Peek().nombre;
             dgvTareas.Columns.Clear();
             actualizarGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EstadoGlobal.tareas.Count == 1)
            {
                this.Close();
                return;
            }

            EstadoGlobal.tareas.Pop();
            tareasRaiz = EstadoGlobal.tareas.Peek().subTareas;
            lblNombreTarea.Text = EstadoGlobal.tareas.Peek().nombre;
            actualizarGridView();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvTareas.SelectedRows[0];
            int posicion = dgvTareas.Rows.IndexOf(selected);

            NodoTarea tarea = tareasRaiz[posicion];
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la tarea " + tarea.nombre + " y todas sus subtareas?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                EstadoGlobal.arbolActual.EliminarTarea(tarea, EstadoGlobal.tareas.Peek());
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
            if (dtpFechaVencimiento.Value.Date < fecha) //Compara que la fecha ingresada no sea menor a la actual
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
    }
}
