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
            this.TxtRemover3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtAcrescentar3 = new System.Windows.Forms.TextBox();
            this.TxtRemover2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAcrescentar2 = new System.Windows.Forms.TextBox();
            this.TxtRemover1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAcrescentar1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtQtd_Origem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GbManual.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "RENOMEAR ROMS ";
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
            this.BtnSaida.Enabled = false;
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
            this.txtOutput.Enabled = false;
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
            this.TxtRemover.MaxLength = 20;
            this.TxtRemover.Name = "TxtRemover";
            this.TxtRemover.Size = new System.Drawing.Size(81, 20);
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
            this.TxtAcrescentar.MaxLength = 20;
            this.TxtAcrescentar.Name = "TxtAcrescentar";
            this.TxtAcrescentar.Size = new System.Drawing.Size(68, 20);
            this.TxtAcrescentar.TabIndex = 14;
            // 
            // GbManual
            // 
            this.GbManual.Controls.Add(this.TxtRemover3);
            this.GbManual.Controls.Add(this.label9);
            this.GbManual.Controls.Add(this.label10);
            this.GbManual.Controls.Add(this.TxtAcrescentar3);
            this.GbManual.Controls.Add(this.TxtRemover2);
            this.GbManual.Controls.Add(this.label7);
            this.GbManual.Controls.Add(this.label8);
            this.GbManual.Controls.Add(this.TxtAcrescentar2);
            this.GbManual.Controls.Add(this.TxtRemover1);
            this.GbManual.Controls.Add(this.label5);
            this.GbManual.Controls.Add(this.label6);
            this.GbManual.Controls.Add(this.TxtAcrescentar1);
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
            // TxtRemover3
            // 
            this.TxtRemover3.Location = new System.Drawing.Point(84, 132);
            this.TxtRemover3.MaxLength = 20;
            this.TxtRemover3.Name = "TxtRemover3";
            this.TxtRemover3.Size = new System.Drawing.Size(81, 20);
            this.TxtRemover3.TabIndex = 24;
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
            // TxtAcrescentar3
            // 
            this.TxtAcrescentar3.Location = new System.Drawing.Point(248, 132);
            this.TxtAcrescentar3.MaxLength = 20;
            this.TxtAcrescentar3.Name = "TxtAcrescentar3";
            this.TxtAcrescentar3.Size = new System.Drawing.Size(68, 20);
            this.TxtAcrescentar3.TabIndex = 26;
            // 
            // TxtRemover2
            // 
            this.TxtRemover2.Location = new System.Drawing.Point(84, 99);
            this.TxtRemover2.MaxLength = 20;
            this.TxtRemover2.Name = "TxtRemover2";
            this.TxtRemover2.Size = new System.Drawing.Size(81, 20);
            this.TxtRemover2.TabIndex = 20;
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
            // TxtAcrescentar2
            // 
            this.TxtAcrescentar2.Location = new System.Drawing.Point(248, 99);
            this.TxtAcrescentar2.MaxLength = 20;
            this.TxtAcrescentar2.Name = "TxtAcrescentar2";
            this.TxtAcrescentar2.Size = new System.Drawing.Size(68, 20);
            this.TxtAcrescentar2.TabIndex = 22;
            // 
            // TxtRemover1
            // 
            this.TxtRemover1.Location = new System.Drawing.Point(84, 67);
            this.TxtRemover1.MaxLength = 20;
            this.TxtRemover1.Name = "TxtRemover1";
            this.TxtRemover1.Size = new System.Drawing.Size(81, 20);
            this.TxtRemover1.TabIndex = 16;
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
            // TxtAcrescentar1
            // 
            this.TxtAcrescentar1.Location = new System.Drawing.Point(248, 67);
            this.TxtAcrescentar1.MaxLength = 20;
            this.TxtAcrescentar1.Name = "TxtAcrescentar1";
            this.TxtAcrescentar1.Size = new System.Drawing.Size(68, 20);
            this.TxtAcrescentar1.TabIndex = 18;
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
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.progressBar1.Location = new System.Drawing.Point(12, 505);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(661, 412);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(127, 51);
            this.BtnLimpar.TabIndex = 20;
            this.BtnLimpar.Text = "Limpar Lista";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtQtd_Origem
            // 
            this.TxtQtd_Origem.Enabled = false;
            this.TxtQtd_Origem.Location = new System.Drawing.Point(96, 469);
            this.TxtQtd_Origem.Name = "TxtQtd_Origem";
            this.TxtQtd_Origem.ReadOnly = true;
            this.TxtQtd_Origem.Size = new System.Drawing.Size(81, 20);
            this.TxtQtd_Origem.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Qtd Roms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(765, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "V.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtQtd_Origem);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbManual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnRenomear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RENOMEAR ROMS";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox TxtRemover3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtAcrescentar3;
        private System.Windows.Forms.TextBox TxtRemover2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAcrescentar2;
        private System.Windows.Forms.TextBox TxtRemover1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAcrescentar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox TxtQtd_Origem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

