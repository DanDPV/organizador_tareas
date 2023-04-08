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
            DataGridViewColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "nombre";
            colNombre.HeaderText = "Nombre";
            dgvTareas.Columns.Add(colNombre);

            DataGridViewColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fechaVencimiento";
            colFecha.HeaderText = "Fecha de Vencimiento";
            dgvTareas.Columns.Add(colFecha);

            tareasRaiz = EstadoGlobal.tareaActual.subTareas;
            lblNombreTarea.Text = EstadoGlobal.tareaActual.nombre;
            actualizarGridView();
        }

        private void actualizarGridView()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = tareasRaiz;

            foreach (DataGridViewRow row in dgvTareas.Rows)
            {
                NodoTarea tarea = (NodoTarea)row.DataBoundItem;
                row.Cells[0].Value = tarea.nombre;
                row.Cells[1].Value = tarea.fechaVencimiento.ToShortDateString();
            }
        }

        private void btnAddTarea_Click(object sender, EventArgs e)
        {
            EstadoGlobal.arbolActual.AgregarTarea(txtNombre.Text, dtpFechaVencimiento.Value, EstadoGlobal.tareaActual);

            actualizarGridView();
        }

        private void dgvTareas_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvTareas.SelectedRows[0];
            int posicion = dgvTareas.Rows.IndexOf(selected);

            NodoTarea tarea = tareasRaiz[posicion];
            EstadoGlobal.tareaActual = tarea;

            tareasRaiz = EstadoGlobal.tareaActual.subTareas;
            lblNombreTarea.Text = EstadoGlobal.tareaActual.nombre;
            actualizarGridView();
        }
    }
}
