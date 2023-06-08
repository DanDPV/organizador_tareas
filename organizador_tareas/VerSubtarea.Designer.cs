
namespace organizador_tareas
{
    partial class VerSubtarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.groupBoxFormulario = new System.Windows.Forms.GroupBox();
            this.btnCompletarTarea = new System.Windows.Forms.Button();
            this.btnModificarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.btnAddTarea = new System.Windows.Forms.Button();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.groupBoxFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(76, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vista subtarea";
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblNombreTarea.Location = new System.Drawing.Point(77, 52);
            this.lblNombreTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(17, 25);
            this.lblNombreTarea.TabIndex = 4;
            this.lblNombreTarea.Text = ".";
            this.lblNombreTarea.Click += new System.EventHandler(this.lblNombreTarea_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(13, 105);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(704, 438);
            this.dgvTareas.TabIndex = 5;
            this.dgvTareas.DoubleClick += new System.EventHandler(this.dgvTareas_DoubleClick);
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
            this.groupBoxFormulario.Location = new System.Drawing.Point(732, -7);
            this.groupBoxFormulario.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxFormulario.Size = new System.Drawing.Size(259, 563);
            this.groupBoxFormulario.TabIndex = 6;
            this.groupBoxFormulario.TabStop = false;
            // 
            // btnCompletarTarea
            // 
            this.btnCompletarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCompletarTarea.FlatAppearance.BorderSize = 0;
            this.btnCompletarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarTarea.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompletarTarea.Location = new System.Drawing.Point(2, 473);
            this.btnCompletarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompletarTarea.Name = "btnCompletarTarea";
            this.btnCompletarTarea.Size = new System.Drawing.Size(253, 42);
            this.btnCompletarTarea.TabIndex = 9;
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
            this.btnModificarTarea.Location = new System.Drawing.Point(2, 413);
            this.btnModificarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(253, 42);
            this.btnModificarTarea.TabIndex = 8;
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
            this.btnEliminarTarea.Location = new System.Drawing.Point(2, 350);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(255, 42);
            this.btnEliminarTarea.TabIndex = 5;
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
            this.btnAddTarea.Location = new System.Drawing.Point(2, 286);
            this.btnAddTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTarea.Name = "btnAddTarea";
            this.btnAddTarea.Size = new System.Drawing.Size(255, 42);
            this.btnAddTarea.TabIndex = 4;
            this.btnAddTarea.Text = "Agregar Tarea";
            this.btnAddTarea.UseVisualStyleBackColor = false;
            this.btnAddTarea.Click += new System.EventHandler(this.btnAddTarea_Click);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(26, 202);
            this.dtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 27);
            this.dtpFechaVencimiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 147);
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
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(26, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.button1.Location = new System.Drawing.Point(13, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 85);
            this.button1.TabIndex = 7;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // VerSubtarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxFormulario);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.lblNombreTarea);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "VerSubtarea";
            this.Text = "VerSubtarea";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerSubtarea_FormClosing);
            this.Load += new System.EventHandler(this.VerSubtarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.groupBoxFormulario.ResumeLayout(false);
            this.groupBoxFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.GroupBox groupBoxFormulario;
        private System.Windows.Forms.Button btnAddTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnModificarTarea;
        private System.Windows.Forms.Button btnCompletarTarea;
    }
}