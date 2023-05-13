
namespace organizador_tareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxFormulario = new System.Windows.Forms.GroupBox();
            this.btnModificarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.btnAddTarea = new System.Windows.Forms.Button();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCompletarTarea = new System.Windows.Forms.Button();
            this.groupBoxFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFormulario
            // 
            this.groupBoxFormulario.Controls.Add(this.btnCompletarTarea);
            this.groupBoxFormulario.Controls.Add(this.btnModificarTarea);
            this.groupBoxFormulario.Controls.Add(this.btnEliminarTarea);
            this.groupBoxFormulario.Controls.Add(this.btnAddTarea);
            this.groupBoxFormulario.Controls.Add(this.dtpFechaVencimiento);
            this.groupBoxFormulario.Controls.Add(this.label2);
            this.groupBoxFormulario.Controls.Add(this.txtNombre);
            this.groupBoxFormulario.Controls.Add(this.label1);
            this.groupBoxFormulario.Location = new System.Drawing.Point(971, 50);
            this.groupBoxFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFormulario.Size = new System.Drawing.Size(324, 462);
            this.groupBoxFormulario.TabIndex = 0;
            this.groupBoxFormulario.TabStop = false;
            this.groupBoxFormulario.Text = "Agregar tarea";
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.Location = new System.Drawing.Point(11, 293);
            this.btnModificarTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(265, 33);
            this.btnModificarTarea.TabIndex = 7;
            this.btnModificarTarea.Text = "Modificar Tarea";
            this.btnModificarTarea.UseVisualStyleBackColor = true;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(11, 246);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(265, 33);
            this.btnEliminarTarea.TabIndex = 6;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // btnAddTarea
            // 
            this.btnAddTarea.Location = new System.Drawing.Point(11, 196);
            this.btnAddTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTarea.Name = "btnAddTarea";
            this.btnAddTarea.Size = new System.Drawing.Size(265, 33);
            this.btnAddTarea.TabIndex = 4;
            this.btnAddTarea.Text = "Agregar Tarea";
            this.btnAddTarea.UseVisualStyleBackColor = true;
            this.btnAddTarea.Click += new System.EventHandler(this.btnAddTarea_Click);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(11, 130);
            this.dtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaVencimiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha vencimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(11, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(13, 89);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(952, 555);
            this.dgvTareas.TabIndex = 1;
            this.dgvTareas.DoubleClick += new System.EventHandler(this.dgvTareas_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de tareas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCompletarTarea
            // 
            this.btnCompletarTarea.Location = new System.Drawing.Point(11, 344);
            this.btnCompletarTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompletarTarea.Name = "btnCompletarTarea";
            this.btnCompletarTarea.Size = new System.Drawing.Size(265, 33);
            this.btnCompletarTarea.TabIndex = 8;
            this.btnCompletarTarea.Text = "Completar Tarea";
            this.btnCompletarTarea.UseVisualStyleBackColor = true;
            this.btnCompletarTarea.Click += new System.EventHandler(this.btnCompletarTarea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 689);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.groupBoxFormulario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFormulario.ResumeLayout(false);
            this.groupBoxFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFormulario;
        private System.Windows.Forms.Button btnAddTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnModificarTarea;
        private System.Windows.Forms.Button btnCompletarTarea;
    }
}

