
namespace ProyectoEstructurasCSharp
{
    partial class Menu
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
            this.btnFormEstructuras = new System.Windows.Forms.Button();
            this.btnFormAlgoritmos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormEstructuras
            // 
            this.btnFormEstructuras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormEstructuras.Location = new System.Drawing.Point(22, 12);
            this.btnFormEstructuras.Name = "btnFormEstructuras";
            this.btnFormEstructuras.Size = new System.Drawing.Size(105, 45);
            this.btnFormEstructuras.TabIndex = 0;
            this.btnFormEstructuras.Text = "Estructuras";
            this.btnFormEstructuras.UseVisualStyleBackColor = true;
            this.btnFormEstructuras.Click += new System.EventHandler(this.btnFormEstructuras_Click);
            // 
            // btnFormAlgoritmos
            // 
            this.btnFormAlgoritmos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormAlgoritmos.Location = new System.Drawing.Point(22, 77);
            this.btnFormAlgoritmos.Name = "btnFormAlgoritmos";
            this.btnFormAlgoritmos.Size = new System.Drawing.Size(105, 45);
            this.btnFormAlgoritmos.TabIndex = 1;
            this.btnFormAlgoritmos.Text = "Algoritmos";
            this.btnFormAlgoritmos.UseVisualStyleBackColor = true;
            this.btnFormAlgoritmos.Click += new System.EventHandler(this.btnFormAlgoritmos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 132);
            this.Controls.Add(this.btnFormAlgoritmos);
            this.Controls.Add(this.btnFormEstructuras);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormEstructuras;
        private System.Windows.Forms.Button btnFormAlgoritmos;
    }
}