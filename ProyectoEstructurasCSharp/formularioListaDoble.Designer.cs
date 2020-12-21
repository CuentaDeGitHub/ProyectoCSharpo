
namespace ProyectoEstructurasCSharp
{
    partial class formularioListaDoble
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarLista = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDatoBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.txtDatoBorrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(215, 193);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarLista);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.btnContar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnGuarda);
            this.groupBox2.Controls.Add(this.txtArchivo);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtDatoBuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMostrar);
            this.groupBox2.Controls.Add(this.lblLista);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.txtNodo);
            this.groupBox2.Controls.Add(this.txtDatoBorrar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 283);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminarLista
            // 
            this.btnEliminarLista.Location = new System.Drawing.Point(13, 241);
            this.btnEliminarLista.Name = "btnEliminarLista";
            this.btnEliminarLista.Size = new System.Drawing.Size(234, 23);
            this.btnEliminarLista.TabIndex = 44;
            this.btnEliminarLista.Text = "Eliminar lista doblemente enlazada";
            this.btnEliminarLista.UseVisualStyleBackColor = true;
            this.btnEliminarLista.Click += new System.EventHandler(this.btnEliminarLista_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(188, 160);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(59, 23);
            this.btnContar.TabIndex = 43;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nombre del archivo";
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(4, 190);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(75, 23);
            this.btnGuarda.TabIndex = 42;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(85, 193);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtArchivo.TabIndex = 41;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(188, 131);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 23);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDatoBuscar
            // 
            this.txtDatoBuscar.Location = new System.Drawing.Point(111, 134);
            this.txtDatoBuscar.Name = "txtDatoBuscar";
            this.txtDatoBuscar.Size = new System.Drawing.Size(69, 20);
            this.txtDatoBuscar.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Dato a buscar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 45);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 23);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Introducir y Mostrar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Dato";
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(151, 18);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(29, 13);
            this.lblMostrar.TabIndex = 36;
            this.lblMostrar.Text = "Lista";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(151, 41);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(56, 16);
            this.lblLista.TabIndex = 30;
            this.lblLista.Text = "*,*,*,*,*,*,";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(188, 102);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(47, 23);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(53, 19);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(70, 20);
            this.txtNodo.TabIndex = 31;
            // 
            // txtDatoBorrar
            // 
            this.txtDatoBorrar.Location = new System.Drawing.Point(111, 102);
            this.txtDatoBorrar.Name = "txtDatoBorrar";
            this.txtDatoBorrar.Size = new System.Drawing.Size(69, 20);
            this.txtDatoBorrar.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Dato a borrar";
            // 
            // formularioListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 299);
            this.Controls.Add(this.groupBox2);
            this.Name = "formularioListaDoble";
            this.Text = "Lista doblemente enlazada";
            this.Load += new System.EventHandler(this.formularioListaDoble_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDatoBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.TextBox txtDatoBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarLista;
    }
}