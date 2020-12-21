namespace ProyectoEstructurasCSharp
{
    partial class FormularioCola
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCola = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnFrente = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(199, 124);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.lblCola);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtArchivo);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnFrente);
            this.groupBox2.Controls.Add(this.btnDesencolar);
            this.groupBox2.Controls.Add(this.btnEncolar);
            this.groupBox2.Controls.Add(this.txtDato);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 172);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(279, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar cola";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(187, 23);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(28, 13);
            this.lblCola.TabIndex = 10;
            this.lblCola.Text = "Cola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del archivo";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(93, 124);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtArchivo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 124);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnFrente
            // 
            this.btnFrente.Location = new System.Drawing.Point(93, 77);
            this.btnFrente.Name = "btnFrente";
            this.btnFrente.Size = new System.Drawing.Size(75, 23);
            this.btnFrente.TabIndex = 6;
            this.btnFrente.Text = "Frente";
            this.btnFrente.UseVisualStyleBackColor = true;
            this.btnFrente.Click += new System.EventHandler(this.btnFrente_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(93, 48);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolar.TabIndex = 5;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(93, 19);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 23);
            this.btnEncolar.TabIndex = 4;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(42, 20);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(45, 20);
            this.txtDato.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormularioCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 180);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormularioCola";
            this.Text = "Cola";
            this.Load += new System.EventHandler(this.FormularioCola_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnFrente;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnEliminar;
    }
}