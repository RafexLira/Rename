namespace Rename
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BtnSaida = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.BtnRenomear = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TxtRemover = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RbAutomatico = new System.Windows.Forms.RadioButton();
            this.RbManual = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAcrescentar = new System.Windows.Forms.TextBox();
            this.GbManual = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.GbManual.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renomear roms ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(25, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BtnSaida
            // 
            this.BtnSaida.Location = new System.Drawing.Point(25, 47);
            this.BtnSaida.Name = "BtnSaida";
            this.BtnSaida.Size = new System.Drawing.Size(75, 23);
            this.BtnSaida.TabIndex = 3;
            this.BtnSaida.Text = "Salver em:";
            this.BtnSaida.UseVisualStyleBackColor = true;
            this.BtnSaida.Click += new System.EventHandler(this.BtnSaida_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(127, 49);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(189, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // BtnRenomear
            // 
            this.BtnRenomear.Location = new System.Drawing.Point(429, 412);
            this.BtnRenomear.Name = "BtnRenomear";
            this.BtnRenomear.Size = new System.Drawing.Size(127, 51);
            this.BtnRenomear.TabIndex = 5;
            this.BtnRenomear.Text = "Renomear";
            this.BtnRenomear.UseVisualStyleBackColor = true;
            this.BtnRenomear.Click += new System.EventHandler(this.BtnRenomear_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(429, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 316);
            this.listBox1.TabIndex = 7;
            // 
            // TxtRemover
            // 
            this.TxtRemover.Location = new System.Drawing.Point(84, 33);
            this.TxtRemover.MaxLength = 5;
            this.TxtRemover.Name = "TxtRemover";
            this.TxtRemover.Size = new System.Drawing.Size(63, 20);
            this.TxtRemover.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Remover :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // RbAutomatico
            // 
            this.RbAutomatico.AutoSize = true;
            this.RbAutomatico.Location = new System.Drawing.Point(238, 32);
            this.RbAutomatico.Name = "RbAutomatico";
            this.RbAutomatico.Size = new System.Drawing.Size(78, 17);
            this.RbAutomatico.TabIndex = 12;
            this.RbAutomatico.TabStop = true;
            this.RbAutomatico.Text = "Automático";
            this.RbAutomatico.UseVisualStyleBackColor = true;
            // 
            // RbManual
            // 
            this.RbManual.AutoSize = true;
            this.RbManual.Location = new System.Drawing.Point(84, 32);
            this.RbManual.Name = "RbManual";
            this.RbManual.Size = new System.Drawing.Size(60, 17);
            this.RbManual.TabIndex = 13;
            this.RbManual.TabStop = true;
            this.RbManual.Text = "Manual";
            this.RbManual.UseVisualStyleBackColor = true;
            this.RbManual.CheckedChanged += new System.EventHandler(this.RbManual_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Substituir por:";
            // 
            // TxtAcrescentar
            // 
            this.TxtAcrescentar.Location = new System.Drawing.Point(248, 33);
            this.TxtAcrescentar.MaxLength = 5;
            this.TxtAcrescentar.Name = "TxtAcrescentar";
            this.TxtAcrescentar.Size = new System.Drawing.Size(68, 20);
            this.TxtAcrescentar.TabIndex = 14;
            // 
            // GbManual
            // 
            this.GbManual.Controls.Add(this.textBox5);
            this.GbManual.Controls.Add(this.label9);
            this.GbManual.Controls.Add(this.label10);
            this.GbManual.Controls.Add(this.textBox6);
            this.GbManual.Controls.Add(this.textBox3);
            this.GbManual.Controls.Add(this.label7);
            this.GbManual.Controls.Add(this.label8);
            this.GbManual.Controls.Add(this.textBox4);
            this.GbManual.Controls.Add(this.textBox1);
            this.GbManual.Controls.Add(this.label5);
            this.GbManual.Controls.Add(this.label6);
            this.GbManual.Controls.Add(this.textBox2);
            this.GbManual.Controls.Add(this.TxtRemover);
            this.GbManual.Controls.Add(this.label4);
            this.GbManual.Controls.Add(this.label2);
            this.GbManual.Controls.Add(this.TxtAcrescentar);
            this.GbManual.Location = new System.Drawing.Point(12, 264);
            this.GbManual.Name = "GbManual";
            this.GbManual.Size = new System.Drawing.Size(364, 199);
            this.GbManual.TabIndex = 16;
            this.GbManual.TabStop = false;
            this.GbManual.Text = "Manual";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(84, 132);
            this.textBox5.MaxLength = 5;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 20);
            this.textBox5.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Substituir por:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Remover :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(248, 132);
            this.textBox6.MaxLength = 5;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 99);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 20);
            this.textBox3.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Substituir por:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Remover :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(248, 99);
            this.textBox4.MaxLength = 5;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 67);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Substituir por:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Remover :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 67);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.BtnSaida);
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 102);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecionar";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.progressBar1.Location = new System.Drawing.Point(12, 492);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RbAutomatico);
            this.groupBox3.Controls.Add(this.RbManual);
            this.groupBox3.Location = new System.Drawing.Point(12, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 56);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbManual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnRenomear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbManual.ResumeLayout(false);
            this.GbManual.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button BtnSaida;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button BtnRenomear;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TxtRemover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RbAutomatico;
        private System.Windows.Forms.RadioButton RbManual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAcrescentar;
        private System.Windows.Forms.GroupBox GbManual;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}

