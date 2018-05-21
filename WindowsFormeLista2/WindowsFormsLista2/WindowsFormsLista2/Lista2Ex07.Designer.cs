namespace WindowsFormsLista2
{
    partial class Lista2Ex07
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbResultadoParImpar = new System.Windows.Forms.Label();
            this.lbResultadoNegativoPositivo = new System.Windows.Forms.Label();
            this.lbResultadoMaiorQue10 = new System.Windows.Forms.Label();
            this.lbNumeroMaiorIgual30 = new System.Windows.Forms.Label();
            this.lbNumeroMenorMenos10 = new System.Windows.Forms.Label();
            this.lbResultadoMenorIgual50 = new System.Windows.Forms.Label();
            this.lbNumeroDiferente1 = new System.Windows.Forms.Label();
            this.ntnResultados = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um numero ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(64, 71);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(162, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(110, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Green;
            this.groupBox2.Controls.Add(this.lbNumeroDiferente1);
            this.groupBox2.Controls.Add(this.lbResultadoMenorIgual50);
            this.groupBox2.Controls.Add(this.lbNumeroMenorMenos10);
            this.groupBox2.Controls.Add(this.lbNumeroMaiorIgual30);
            this.groupBox2.Controls.Add(this.lbResultadoMaiorQue10);
            this.groupBox2.Controls.Add(this.lbResultadoNegativoPositivo);
            this.groupBox2.Controls.Add(this.lbResultadoParImpar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(47, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 254);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbResultadoParImpar
            // 
            this.lbResultadoParImpar.AutoSize = true;
            this.lbResultadoParImpar.Location = new System.Drawing.Point(198, 54);
            this.lbResultadoParImpar.Name = "lbResultadoParImpar";
            this.lbResultadoParImpar.Size = new System.Drawing.Size(22, 13);
            this.lbResultadoParImpar.TabIndex = 1;
            this.lbResultadoParImpar.Text = "-----";
            // 
            // lbResultadoNegativoPositivo
            // 
            this.lbResultadoNegativoPositivo.AutoSize = true;
            this.lbResultadoNegativoPositivo.Location = new System.Drawing.Point(198, 76);
            this.lbResultadoNegativoPositivo.Name = "lbResultadoNegativoPositivo";
            this.lbResultadoNegativoPositivo.Size = new System.Drawing.Size(22, 13);
            this.lbResultadoNegativoPositivo.TabIndex = 2;
            this.lbResultadoNegativoPositivo.Text = "-----";
            // 
            // lbResultadoMaiorQue10
            // 
            this.lbResultadoMaiorQue10.AutoSize = true;
            this.lbResultadoMaiorQue10.Location = new System.Drawing.Point(198, 98);
            this.lbResultadoMaiorQue10.Name = "lbResultadoMaiorQue10";
            this.lbResultadoMaiorQue10.Size = new System.Drawing.Size(22, 13);
            this.lbResultadoMaiorQue10.TabIndex = 3;
            this.lbResultadoMaiorQue10.Text = "-----";
            // 
            // lbNumeroMaiorIgual30
            // 
            this.lbNumeroMaiorIgual30.AutoSize = true;
            this.lbNumeroMaiorIgual30.Location = new System.Drawing.Point(198, 167);
            this.lbNumeroMaiorIgual30.Name = "lbNumeroMaiorIgual30";
            this.lbNumeroMaiorIgual30.Size = new System.Drawing.Size(22, 13);
            this.lbNumeroMaiorIgual30.TabIndex = 4;
            this.lbNumeroMaiorIgual30.Text = "-----";
            // 
            // lbNumeroMenorMenos10
            // 
            this.lbNumeroMenorMenos10.AutoSize = true;
            this.lbNumeroMenorMenos10.Location = new System.Drawing.Point(198, 144);
            this.lbNumeroMenorMenos10.Name = "lbNumeroMenorMenos10";
            this.lbNumeroMenorMenos10.Size = new System.Drawing.Size(22, 13);
            this.lbNumeroMenorMenos10.TabIndex = 5;
            this.lbNumeroMenorMenos10.Text = "-----";
            // 
            // lbResultadoMenorIgual50
            // 
            this.lbResultadoMenorIgual50.AutoSize = true;
            this.lbResultadoMenorIgual50.Location = new System.Drawing.Point(198, 121);
            this.lbResultadoMenorIgual50.Name = "lbResultadoMenorIgual50";
            this.lbResultadoMenorIgual50.Size = new System.Drawing.Size(22, 13);
            this.lbResultadoMenorIgual50.TabIndex = 6;
            this.lbResultadoMenorIgual50.Text = "-----";
            // 
            // lbNumeroDiferente1
            // 
            this.lbNumeroDiferente1.AutoSize = true;
            this.lbNumeroDiferente1.Location = new System.Drawing.Point(198, 189);
            this.lbNumeroDiferente1.Name = "lbNumeroDiferente1";
            this.lbNumeroDiferente1.Size = new System.Drawing.Size(22, 13);
            this.lbNumeroDiferente1.TabIndex = 7;
            this.lbNumeroDiferente1.Text = "-----";
            // 
            // ntnResultados
            // 
            this.ntnResultados.BackColor = System.Drawing.Color.DarkCyan;
            this.ntnResultados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntnResultados.Location = new System.Drawing.Point(203, 177);
            this.ntnResultados.Name = "ntnResultados";
            this.ntnResultados.Size = new System.Drawing.Size(116, 23);
            this.ntnResultados.TabIndex = 4;
            this.ntnResultados.Text = "Resultados";
            this.ntnResultados.UseVisualStyleBackColor = false;
            this.ntnResultados.Click += new System.EventHandler(this.ntnResultados_Click);
            // 
            // Lista2Ex07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(523, 488);
            this.Controls.Add(this.ntnResultados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lista2Ex07";
            this.Text = "Lista2Ex07";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNumeroDiferente1;
        private System.Windows.Forms.Label lbResultadoMenorIgual50;
        private System.Windows.Forms.Label lbNumeroMenorMenos10;
        private System.Windows.Forms.Label lbNumeroMaiorIgual30;
        private System.Windows.Forms.Label lbResultadoMaiorQue10;
        private System.Windows.Forms.Label lbResultadoNegativoPositivo;
        private System.Windows.Forms.Label lbResultadoParImpar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ntnResultados;
    }
}