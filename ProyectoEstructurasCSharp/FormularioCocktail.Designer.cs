
namespace ProyectoEstructurasCSharp
{
    partial class FormularioCocktail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIntercambios = new System.Windows.Forms.Label();
            this.lblComparaciones = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txTamaño = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intercambios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Comparaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiempo";
            // 
            // lblIntercambios
            // 
            this.lblIntercambios.AutoSize = true;
            this.lblIntercambios.Location = new System.Drawing.Point(222, 90);
            this.lblIntercambios.Name = "lblIntercambios";
            this.lblIntercambios.Size = new System.Drawing.Size(40, 13);
            this.lblIntercambios.TabIndex = 6;
            this.lblIntercambios.Text = ". . . . . .";
            // 
            // lblComparaciones
            // 
            this.lblComparaciones.AutoSize = true;
            this.lblComparaciones.Location = new System.Drawing.Point(222, 66);
            this.lblComparaciones.Name = "lblComparaciones";
            this.lblComparaciones.Size = new System.Drawing.Size(43, 13);
            this.lblComparaciones.TabIndex = 7;
            this.lblComparaciones.Text = ". . . . . . ";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(222, 114);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(40, 13);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = ". . . . . .";
            // 
            // txTamaño
            // 
            this.txTamaño.Location = new System.Drawing.Point(64, 6);
            this.txTamaño.Name = "txTamaño";
            this.txTamaño.Size = new System.Drawing.Size(37, 20);
            this.txTamaño.TabIndex = 9;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(64, 59);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(37, 20);
            this.txtMax.TabIndex = 10;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(64, 33);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(37, 20);
            this.txtMin.TabIndex = 11;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(15, 85);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(86, 23);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(15, 114);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(86, 23);
            this.btnAleatorio.TabIndex = 15;
            this.btnAleatorio.Text = "Crear aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(222, 13);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(52, 13);
            this.lblOriginal.TabIndex = 17;
            this.lblOriginal.Text = ". . . . . . . .";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Arreglo original";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Arreglo ordenado";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(222, 40);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(52, 13);
            this.lblOrdenado.TabIndex = 20;
            this.lblOrdenado.Text = ". . . . . . . .";
            // 
            // FormularioCocktail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 147);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txTamaño);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblComparaciones);
            this.Controls.Add(this.lblIntercambios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioCocktail";
            this.Text = "FormularioCocktail";
            this.Load += new System.EventHandler(this.FormularioCocktail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIntercambios;
        private System.Windows.Forms.Label lblComparaciones;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txTamaño;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOrdenado;
    }
}