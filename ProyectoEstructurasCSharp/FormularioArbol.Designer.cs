﻿
namespace ProyectoEstructurasCSharp
{
    partial class FormularioArbol
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
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnPostOrden = new System.Windows.Forms.RadioButton();
            this.rbtnPreOrden = new System.Windows.Forms.RadioButton();
            this.rbtnOrden = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIdentif = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnDetAlt = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNodo
            // 
            this.txtNodo.BackColor = System.Drawing.Color.Snow;
            this.txtNodo.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.txtNodo.ForeColor = System.Drawing.Color.Black;
            this.txtNodo.Location = new System.Drawing.Point(155, 424);
            this.txtNodo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(102, 23);
            this.txtNodo.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 38);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(12, 456);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 38);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(12, 500);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 38);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbtnPostOrden);
            this.groupBox1.Controls.Add(this.rbtnPreOrden);
            this.groupBox1.Controls.Add(this.rbtnOrden);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(275, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorrer";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "Recorrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnPostOrden
            // 
            this.rbtnPostOrden.AutoSize = true;
            this.rbtnPostOrden.Location = new System.Drawing.Point(11, 65);
            this.rbtnPostOrden.Name = "rbtnPostOrden";
            this.rbtnPostOrden.Size = new System.Drawing.Size(107, 24);
            this.rbtnPostOrden.TabIndex = 2;
            this.rbtnPostOrden.TabStop = true;
            this.rbtnPostOrden.Text = "Post Orden";
            this.rbtnPostOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnPreOrden
            // 
            this.rbtnPreOrden.AutoSize = true;
            this.rbtnPreOrden.Location = new System.Drawing.Point(11, 42);
            this.rbtnPreOrden.Name = "rbtnPreOrden";
            this.rbtnPreOrden.Size = new System.Drawing.Size(99, 24);
            this.rbtnPreOrden.TabIndex = 1;
            this.rbtnPreOrden.TabStop = true;
            this.rbtnPreOrden.Text = "Pre Orden";
            this.rbtnPreOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnOrden
            // 
            this.rbtnOrden.AutoSize = true;
            this.rbtnOrden.Location = new System.Drawing.Point(11, 19);
            this.rbtnOrden.Name = "rbtnOrden";
            this.rbtnOrden.Size = new System.Drawing.Size(71, 24);
            this.rbtnOrden.TabIndex = 0;
            this.rbtnOrden.TabStop = true;
            this.rbtnOrden.Text = "Orden";
            this.rbtnOrden.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Encontrar el maximo y minimo";
            // 
            // btnIdentif
            // 
            this.btnIdentif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentif.Location = new System.Drawing.Point(526, 422);
            this.btnIdentif.Name = "btnIdentif";
            this.btnIdentif.Size = new System.Drawing.Size(86, 38);
            this.btnIdentif.TabIndex = 28;
            this.btnIdentif.Text = "Identificar";
            this.btnIdentif.UseVisualStyleBackColor = true;
            this.btnIdentif.Click += new System.EventHandler(this.btnIdentif_Click);
            // 
            // btnCar
            // 
            this.btnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.Location = new System.Drawing.Point(526, 510);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(111, 38);
            this.btnCar.TabIndex = 30;
            this.btnCar.Text = "Cargar arbol";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnDetAlt
            // 
            this.btnDetAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetAlt.Location = new System.Drawing.Point(526, 466);
            this.btnDetAlt.Name = "btnDetAlt";
            this.btnDetAlt.Size = new System.Drawing.Size(149, 38);
            this.btnDetAlt.TabIndex = 29;
            this.btnDetAlt.Text = "Determinar altura";
            this.btnDetAlt.UseVisualStyleBackColor = true;
            this.btnDetAlt.Click += new System.EventHandler(this.btnDetAlt_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(667, 511);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 38);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar arbol";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormularioArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 560);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnDetAlt);
            this.Controls.Add(this.btnIdentif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNodo);
            this.Name = "FormularioArbol";
            this.Text = "FormularioArbol";
            this.Load += new System.EventHandler(this.FormularioArbol_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Arbol_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnPostOrden;
        private System.Windows.Forms.RadioButton rbtnPreOrden;
        private System.Windows.Forms.RadioButton rbtnOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIdentif;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnDetAlt;
        private System.Windows.Forms.Button btnGuardar;
    }
}