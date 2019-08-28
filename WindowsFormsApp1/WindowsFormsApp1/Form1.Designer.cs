namespace WindowsFormsApp1
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
            this.centi = new System.Windows.Forms.Label();
            this.txtCen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // centi
            // 
            this.centi.AutoSize = true;
            this.centi.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centi.Location = new System.Drawing.Point(59, 92);
            this.centi.Name = "centi";
            this.centi.Size = new System.Drawing.Size(183, 25);
            this.centi.TabIndex = 0;
            this.centi.Text = "grados centigrados ";
            // 
            // txtCen
            // 
            this.txtCen.Location = new System.Drawing.Point(283, 96);
            this.txtCen.Name = "txtCen";
            this.txtCen.Size = new System.Drawing.Size(100, 20);
            this.txtCen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "grados fahrenheit";
            // 
            // txtFar
            // 
            this.txtFar.Location = new System.Drawing.Point(283, 156);
            this.txtFar.Name = "txtFar";
            this.txtFar.Size = new System.Drawing.Size(100, 20);
            this.txtFar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "aecpetar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCen);
            this.Controls.Add(this.centi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label centi;
        private System.Windows.Forms.TextBox txtCen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFar;
        private System.Windows.Forms.Button button1;
    }
}

