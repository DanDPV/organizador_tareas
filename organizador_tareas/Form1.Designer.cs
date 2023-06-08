
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
            this.btnCompletarTarea = new System.Windows.Forms.Button();
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
            this.groupBoxFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFormulario
            // 
            this.groupBoxFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.groupBoxFormulario.Controls.Add(this.btnCompletarTarea);
            this.groupBoxFormulario.Controls.Add(this.btnModificarTarea);
            this.groupBoxFormulario.Controls.Add(this.btnEliminarTarea);
            this.groupBoxFormulario.Controls.Add(this.btnAddTarea);
            this.groupBoxFormulario.Controls.Add(this.dtpFechaVencimiento);
            this.groupBoxFormulario.Controls.Add(this.label2);
            this.groupBoxFormulario.Controls.Add(this.txtNombre);
            this.groupBoxFormulario.Controls.Add(this.label1);
            this.groupBoxFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFormulario.Location = new System.Drawing.Point(728, -8);
            this.groupBoxFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxFormulario.Size = new System.Drawing.Size(263, 571);
            this.groupBoxFormulario.TabIndex = 0;
            this.groupBoxFormulario.TabStop = false;
            // 
            // btnCompletarTarea
            // 
            this.btnCompletarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCompletarTarea.FlatAppearance.BorderSize = 0;
            this.btnCompletarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarTarea.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompletarTarea.Location = new System.Drawing.Point(4, 444);
            this.btnCompletarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompletarTarea.Name = "btnCompletarTarea";
            this.btnCompletarTarea.Size = new System.Drawing.Size(257, 42);
            this.btnCompletarTarea.TabIndex = 8;
            this.btnCompletarTarea.Text = "Completar Tarea";
            this.btnCompletarTarea.UseVisualStyleBackColor = false;
            this.btnCompletarTarea.Click += new System.EventHandler(this.btnCompletarTarea_Click);
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnModificarTarea.FlatAppearance.BorderSize = 0;
            this.btnModificarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTarea.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarTarea.Location = new System.Drawing.Point(4, 389);
            this.btnModificarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(257, 42);
            this.btnModificarTarea.TabIndex = 7;
            this.btnModificarTarea.Text = "Modificar Tarea";
            this.btnModificarTarea.UseVisualStyleBackColor = false;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnEliminarTarea.FlatAppearance.BorderSize = 0;
            this.btnEliminarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarea.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTarea.Location = new System.Drawing.Point(4, 329);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(257, 42);
            this.btnEliminarTarea.TabIndex = 6;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // btnAddTarea
            // 
            this.btnAddTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnAddTarea.FlatAppearance.BorderSize = 0;
            this.btnAddTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTarea.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddTarea.Location = new System.Drawing.Point(2, 274);
            this.btnAddTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTarea.Name = "btnAddTarea";
            this.btnAddTarea.Size = new System.Drawing.Size(259, 42);
            this.btnAddTarea.TabIndex = 4;
            this.btnAddTarea.Text = "Agregar Tarea";
            this.btnAddTarea.UseVisualStyleBackColor = false;
            this.btnAddTarea.Click += new System.EventHandler(this.btnAddTarea_Click);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpFechaVencimiento.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpFechaVencimiento.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaVencimiento.CalendarTrailingForeColor = System.Drawing.Color.DarkOrange;
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(21, 199);
            this.dtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(213, 27);
            this.dtpFechaVencimiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(17, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha vencimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.txtNombre.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Location = new System.Drawing.Point(21, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(10, 72);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(714, 451);
            this.dgvTareas.TabIndex = 1;
            this.dgvTareas.DoubleClick += new System.EventHandler(this.dgvTareas_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de tareas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(991, 560);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.groupBoxFormulario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
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

