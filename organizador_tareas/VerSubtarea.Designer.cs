﻿
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
            this.btnCompletarTarea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.groupBoxFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vista subtarea";
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTarea.Location = new System.Drawing.Point(67, 64);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(19, 29);
            this.lblNombreTarea.TabIndex = 4;
            this.lblNombreTarea.Text = ".";
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(17, 113);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(952, 555);
            this.dgvTareas.TabIndex = 5;
            this.dgvTareas.DoubleClick += new System.EventHandler(this.dgvTareas_DoubleClick);
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
            this.groupBoxFormulario.Location = new System.Drawing.Point(976, 64);
            this.groupBoxFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFormulario.Size = new System.Drawing.Size(317, 462);
            this.groupBoxFormulario.TabIndex = 6;
            this.groupBoxFormulario.TabStop = false;
            this.groupBoxFormulario.Text = "Agregar tarea";
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.Location = new System.Drawing.Point(10, 300);
            this.btnModificarTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(265, 33);
            this.btnModificarTarea.TabIndex = 8;
            this.btnModificarTarea.Text = "Modificar Tarea";
            this.btnModificarTarea.UseVisualStyleBackColor = true;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(11, 244);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(265, 33);
            this.btnEliminarTarea.TabIndex = 5;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 108);
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
            // btnCompletarTarea
            // 
            this.btnCompletarTarea.Location = new System.Drawing.Point(11, 354);
            this.btnCompletarTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompletarTarea.Name = "btnCompletarTarea";
            this.btnCompletarTarea.Size = new System.Drawing.Size(265, 33);
            this.btnCompletarTarea.TabIndex = 9;
            this.btnCompletarTarea.Text = "Completar Tarea";
            this.btnCompletarTarea.UseVisualStyleBackColor = true;
            this.btnCompletarTarea.Click += new System.EventHandler(this.btnCompletarTarea_Click);
            // 
            // VerSubtarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxFormulario);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.lblNombreTarea);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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