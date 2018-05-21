namespace WindowsFormsLista2
{
    partial class Lista2Ex08Contiacao2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbOpcao = new System.Windows.Forms.MaskedTextBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbOpcao);
            this.groupBox1.Location = new System.Drawing.Point(255, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(73, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o numero do pedido";
            // 
            // mtbOpcao
            // 
            this.mtbOpcao.Location = new System.Drawing.Point(90, 77);
            this.mtbOpcao.Mask = "99";
            this.mtbOpcao.Name = "mtbOpcao";
            this.mtbOpcao.Size = new System.Drawing.Size(100, 20);
            this.mtbOpcao.TabIndex = 3;
            this.mtbOpcao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbOpcao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbOpcao_KeyDown);
            // 
            // txtMenu
            // 
            this.txtMenu.BackColor = System.Drawing.Color.Black;
            this.txtMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.ForeColor = System.Drawing.Color.Lime;
            this.txtMenu.Location = new System.Drawing.Point(94, 74);
            this.txtMenu.Multiline = true;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(602, 358);
            this.txtMenu.TabIndex = 6;
            this.txtMenu.TextChanged += new System.EventHandler(this.txtMenu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(337, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pedido Numero 3";
            // 
            // Lista2Ex08Contiacao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.label1);
            this.Name = "Lista2Ex08Contiacao2";
            this.Text = "Lista2Ex08Contiacao2";
            this.Load += new System.EventHandler(this.Lista2Ex08Contiacao2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbOpcao;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label label1;
    }
}