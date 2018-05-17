namespace WindowsFormsLista2
{
    partial class Lista2Ex01
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
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Resultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diga um numero";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(89, 61);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(81, 20);
            this.txt_Numero.TabIndex = 1;
            this.txt_Numero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Numero_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Resultado);
            this.groupBox1.Location = new System.Drawing.Point(41, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.AutoSize = true;
            this.lb_Resultado.Location = new System.Drawing.Point(70, 40);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(16, 13);
            this.lb_Resultado.TabIndex = 1;
            this.lb_Resultado.Text = "---";
            this.lb_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lista2Ex01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(264, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label1);
            this.Name = "Lista2Ex01";
            this.Text = "Lista2Ex01";
            this.Load += new System.EventHandler(this.Lista2Ex01_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Resultado;
    }
}