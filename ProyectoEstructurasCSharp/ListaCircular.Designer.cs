
namespace ProyectoEstructurasCSharp
{
    partial class ListaCircular
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarLista = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatoBuscar = new System.Windows.Forms.TextBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatoBorrar = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(205, 196);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.btnEliminarLista);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnGuarda);
            this.groupBox2.Controls.Add(this.txtArchivo);
            this.groupBox2.Controls.Add(this.btnContar);
            this.groupBox2.Controls.Add(this.lblLista);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDatoBuscar);
            this.groupBox2.Controls.Add(this.txtDato);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDatoBorrar);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 273);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnEliminarLista
            // 
            this.btnEliminarLista.Location = new System.Drawing.Point(61, 235);
            this.btnEliminarLista.Name = "btnEliminarLista";
            this.btnEliminarLista.Size = new System.Drawing.Size(149, 23);
            this.btnEliminarLista.TabIndex = 39;
            this.btnEliminarLista.Text = "Eliminar Lista";
            this.btnEliminarLista.UseVisualStyleBackColor = true;
            this.btnEliminarLista.Click += new System.EventHandler(this.btnEliminarLista_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombre del archivo";
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(6, 193);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(75, 23);
            this.btnGuarda.TabIndex = 38;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(87, 196);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtArchivo.TabIndex = 37;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(187, 156);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(59, 23);
            this.btnContar.TabIndex = 35;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(149, 31);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(29, 13);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "Lista";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(187, 127);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 23);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato";
            // 
            // txtDatoBuscar
            // 
            this.txtDatoBuscar.Location = new System.Drawing.Point(110, 130);
            this.txtDatoBuscar.Name = "txtDatoBuscar";
            this.txtDatoBuscar.Size = new System.Drawing.Size(69, 20);
            this.txtDatoBuscar.TabIndex = 34;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(78, 25);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(45, 20);
            this.txtDato.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Dato a buscar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Introducir y mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(187, 98);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(47, 23);
            this.btnBorrar.TabIndex = 31;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Dato a borrar";
            // 
            // txtDatoBorrar
            // 
            this.txtDatoBorrar.Location = new System.Drawing.Point(110, 98);
            this.txtDatoBorrar.Name = "txtDatoBorrar";
            this.txtDatoBorrar.Size = new System.Drawing.Size(69, 20);
            this.txtDatoBorrar.TabIndex = 30;
            // 
            // ListaCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 274);
            this.Controls.Add(this.groupBox2);
            this.Name = "ListaCircular";
            this.Text = "Lista Circular";
            this.Load += new System.EventHandler(this.ListaCircular_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDatoBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatoBorrar;
        private System.Windows.Forms.Button btnEliminarLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}