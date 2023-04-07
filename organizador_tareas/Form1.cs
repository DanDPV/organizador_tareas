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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<NodoTarea> tareasRaiz;

        private void btnAddTarea_Click(object sender, EventArgs e)
        {
            ArbolTareas arbol = new ArbolTareas();
            arbol.AgregarTarea(txtNombre.Text, dtpFechaVencimiento.Value, null);

            EstadoGlobal.arboles.Add(arbol);
            tareasRaiz.Add(arbol.raiz);

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

        private void Form1_Load(object sender, EventArgs e)
        {
            tareasRaiz = new List<NodoTarea>();
            EstadoGlobal.arboles = new List<ArbolTareas>();
            dgvTareas.AutoGenerateColumns = false;
            DataGridViewColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "nombre";
            colNombre.HeaderText = "Nombre";
            dgvTareas.Columns.Add(colNombre);

            DataGridViewColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fechaVencimiento";
            colFecha.HeaderText = "Fecha de Vencimiento";
            dgvTareas.Columns.Add(colFecha);

            tareasRaiz = ArbolTareasRepository.ObtenerTareasPrincipales();
            foreach (NodoTarea tarea in tareasRaiz)
            {
                ArbolTareas arbol = new ArbolTareas();
                arbol.raiz = tarea;

                EstadoGlobal.arboles.Add(arbol);
            }
            actualizarGridView();
        }
    }
}
