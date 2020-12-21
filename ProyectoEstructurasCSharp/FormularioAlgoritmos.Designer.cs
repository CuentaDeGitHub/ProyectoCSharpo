
namespace ProyectoEstructurasCSharp
{
    partial class FormularioAlgoritmos
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
            this.btnCountingSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnCockTail = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCountingSort
            // 
            this.btnCountingSort.Location = new System.Drawing.Point(94, 34);
            this.btnCountingSort.Name = "btnCountingSort";
            this.btnCountingSort.Size = new System.Drawing.Size(75, 23);
            this.btnCountingSort.TabIndex = 0;
            this.btnCountingSort.Text = "Counting ";
            this.btnCountingSort.UseVisualStyleBackColor = true;
            this.btnCountingSort.Click += new System.EventHandler(this.btnCountingSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el algoritmo ";
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(94, 63);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(75, 23);
            this.btnBubble.TabIndex = 2;
            this.btnBubble.Text = "Bubble";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnCockTail
            // 
            this.btnCockTail.Location = new System.Drawing.Point(94, 92);
            this.btnCockTail.Name = "btnCockTail";
            this.btnCockTail.Size = new System.Drawing.Size(75, 23);
            this.btnCockTail.TabIndex = 3;
            this.btnCockTail.Text = "Cocktail";
            this.btnCockTail.UseVisualStyleBackColor = true;
            this.btnCockTail.Click += new System.EventHandler(this.btnCockTail_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(94, 121);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(75, 23);
            this.btnShell.TabIndex = 4;
            this.btnShell.Text = "Shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.Location = new System.Drawing.Point(94, 150);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(75, 23);
            this.btnRadix.TabIndex = 5;
            this.btnRadix.Text = "Radix";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(94, 179);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(75, 23);
            this.btnInsertion.TabIndex = 6;
            this.btnInsertion.Text = "Insertion";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // FormularioAlgoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 212);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnCockTail);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCountingSort);
            this.Name = "FormularioAlgoritmos";
            this.Text = "FormularioAlgoritmos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountingSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnCockTail;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnRadix;
        private System.Windows.Forms.Button btnInsertion;
    }
}