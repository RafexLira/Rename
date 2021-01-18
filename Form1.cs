using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using System.IO;


namespace Rename
{
    public partial class Form1 : Form

    {

        List<string> Arquivos = new List<string>();
        public FileInfo NovoArquivo;
        public FileInfo NovoDiretorio;
        public string DirEntrada;
        // public string DirSaida = @"C:\User\Rafael\Desktop\NewRafael";
        public string DirSaida;
        public string DirSaidaCopy;



        public Form1()
        {
            InitializeComponent();
            RbAutomatico.Checked = true;
            GbManual.Enabled = false;
        }

        private void RbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (GbManual.Enabled == false)
            {
                GbManual.Enabled = true;
            }
            else
            {
                GbManual.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetArquivos();
        }
        private void BtnRenomear_Click(object sender, EventArgs e)
        {
            Processar();
        }
        private void BtnSaida_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();

            fbd.Description = "Salvar em ";


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirSaida = fbd.SelectedPath;
                txtOutput.Text = DirSaida;
            }

        }

        void Processar()
        {           
            try
            {              
                foreach (var arquivo in Arquivos)
                {
                   

                    NovoArquivo = new FileInfo(arquivo);                   
                    NovoArquivo.CopyTo(Path.Combine(DirSaida, NovoArquivo.Name.Replace("_.", ".").Replace("_", " ")
                        .Replace("-.", ".").Replace("-", " ").Replace(",", " ").Replace("_", " ").Replace("-", " ")
                        .Replace("(", "").Replace(").", "").Replace(")", "").Replace("(J)", "").Replace("[!]", "").Replace("(PD)", "")
                        .Replace("[A]", "").Replace("[B]", "").Replace("[C]", "").Replace("[D]", "").Replace("[E]", "")
                        .Replace("[F]", "").Replace("[A]", "").Replace("(C)", "")
                        .Replace("[G]", "").Replace("[H]", "").Replace("[I]", "").Replace("[J]", "").Replace("[L]", "")
                        .Replace("[K]", "").Replace("[L]", "").Replace("[M]", "").Replace("[N]", "").Replace("[O]", "")
                        .Replace("[P]", "").Replace("[Q]", "").Replace("[R]", "").Replace("[S]", "").Replace("[T]", "")
                        .Replace("[U]", "").Replace("[W]", "").Replace("[X]", "").Replace("[Y]", "").Replace("[Z]", "")
                        .Replace("(J).", "").Replace("[!].", "").Replace("(PD).", "").Replace("[A].", "")
                        .Replace("[B].", "").Replace("[C].", "").Replace("[D].", "").Replace("[E].", "").Replace("[F].", "")
                        .Replace("[G].", "").Replace("[H].", "").Replace("[I].", "").Replace("[J].", "").Replace("[L].", "")
                        .Replace("[K].", "").Replace("[L].", "").Replace("[M].", "").Replace("[N].", "").Replace("[O].", "")
                        .Replace("[P].", "").Replace("[Q].", "").Replace("[R].", "").Replace("[S].", "").Replace("[T].", "")
                        .Replace("[U].", "").Replace("[W].", "").Replace("[X].", "").Replace("[Y].", "").Replace("[Z].", "")
                        .Replace("[A].", "").Replace("(C).", "").Replace("(K).", "").Replace("(U).", "").Replace("(K)", "")

                        .Replace(" A ", "").Replace(" E ", "").Replace(" I ", "").Replace(" O ", "")
                        .Replace(" U ", "")


                        .Replace("(World)", "").Replace("(U)", "").Replace("(E)", "").Replace("(EU)", "").Replace("(US)", "")
                        .Replace("(EUA)", "").Replace("(USA)", "").Replace("(BR)", "").Replace("T-BR", "")
                        .Replace("(En)", "").Replace("(Fr)", "").Replace("(De)", "").Replace("(Es)", "")
                        .Replace("(It)", "").Replace("(Alt)", "").Replace("(Europe)", "").Replace("(Rev 1)", "")
                        .Replace("(Rev 2)", "").Replace("(Rev 3)", "").Replace("(Rev 4)", "").Replace("(Rev 5)", "")
                        .Replace("(Asia)", "").Replace("(A)", "").Replace("(Brazil)", "").Replace("(Pt-Br)", "")
                        .Replace("(Korea)", "").Replace("(Ch)", "").Replace("(Chine)", "").Replace("(China)", "").Replace("(J)", "").Replace("(Japan)", "").Replace("(Usa,Europe)", "")
                        .Replace("(E).", "").Replace("(EU).", "").Replace("(US).", "")
                        .Replace("(EUA).", "").Replace("(USA).", "").Replace("(BR).", "").Replace("T-BR.", "").Replace("(UE)", "")
                        .Replace("(UE)", "").Replace("(Unl)", "").Replace("(UJE)", "")
                        .Replace("(World).", "")
                        .Replace("(En).", "").Replace("(Fr).", "").Replace("(De).", "").Replace("(Es).", "")
                        .Replace("(It).", "").Replace("(Alt).", "").Replace("(Europe).", "").Replace("(Rev 1).", "")
                        .Replace("(Rev 2).", "").Replace("(Rev 3).", "").Replace("(Rev 4).", "").Replace("(Rev 5).", "")
                        .Replace("(Asia).", "").Replace("(A).", "").Replace("(Brazil).", "").Replace("(Pt-Br).", "")
                        .Replace("(Korea).", "").Replace("(Ch).", "").Replace("(Chine).", "").Replace("(China).", "")
                        .Replace("(J).", "").Replace("(Japan).", "").Replace("(Usa,Europe).", "")
                        .Replace("(UE).", "")
                        
                        .Replace("(Beta)", "").Replace("(Beta).", "").Replace("(REV01)", "").Replace("(REV02)", "").Replace("(REV03)", "")
                        .Replace("(REV04)", "").Replace("(REV05)", "")
                        .Replace("(REV)", "").Replace("(REV00)", "").Replace("(REV 00)", "").Replace("(REV01).", "")
                        .Replace("(REV02).", "").Replace("(REV03).", "").Replace("(REV04).", "").Replace("(REV05).", "")
                        .Replace("(REV).", "").Replace("(REV00).", "").Replace("(REV 00).", "")

                        .Replace("(PD)", "").Replace("(M1)", "").Replace("(M2)", "").Replace("(M3)", "")
                        .Replace("(M4)", "").Replace("(M5)", "").Replace("(Unl).", "").Replace("(UJE).", "").Replace("(UE).", "")
                        .Replace("PD).", "").Replace("(M1).", "").Replace("(M2).", "").Replace("(M3).", "")
                        .Replace("(M4).", "").Replace("M5", "").Replace("M6", "").Replace("Eng", "").Replace("Unl", "")
                        .Replace("(M5).", "").Replace("[t1].", ".").Replace("[t1]", "").Replace("Spa", "")
                        .Replace("Ita", "").Replace("PD", "").Replace("M3", "").Replace("J", "").Replace("M1", "").Replace("M2", "")
                        .Replace("M3", "").Replace("M4", "").Replace("M5", "").Replace("[b1]", "")

                        .Replace("  ", " ").Replace("   ", " ").Replace("    ", " ")
                        .Replace("     ", " ")

                        ));
                    if (File.Exists(arquivo))
                    {
                        File.Delete(arquivo);
                    }
                    //verificar a barra de progresso
                    //verificar se o arquivo já existe

                }
                MessageBox.Show("Arquivos Processados com sucesso!");
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message + " \n Erro ao tentar processar aquivos");
            }
        }
        void GetArquivos()
        {
            ofd1 = new OpenFileDialog();
            ofd1.Multiselect = true;
            ofd1.FileName = "";
            ofd1.InitialDirectory = @"C:\";
            ofd1.Filter = "Roms(*.iso;*.bin;*.rar;*.zip;*.cue;*.gba;*.gbc;*.gb;*.sms;*.gen;*.nes;*.z64;*.v64;*.rom;*.nds;*.smc;)| *.iso;*.bin;*.rar;*.zip;*.cue;*.gba;*.gbc;*.gb;*.sms;*.gen;*.nes;*.z64;*.v64;*.rom;*.nds;*.smc" + "|All Files|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 1;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            if (ofd1.ShowDialog()== DialogResult.OK)
            {
                foreach (string arquivo in ofd1.FileNames)
                {
                    listBox1.Items.Add(arquivo);
                    Arquivos.Add(arquivo);
                }
            }
        }
    }
}

//files.MoveTo(Path.Combine(DirSaida, files.Name.Replace(",", "").Replace("_", " ").Replace("-", " ").Replace("(", "").Replace("(U)", "").Replace("(E)", "").Replace("(EU)", "").Replace("US", "").Replace("EUA", "").Replace("USA", "").Replace("BR", "").Replace("T-BR", "").Replace(")", "").Replace("(J)", "").Replace("[!]", "").Replace("(PD)", "").Replace("[A]", "").Replace("[B]", "").Replace("[C]", "").Replace("[D]", "").Replace("[E]", "").Replace("[F]", "").Replace("[G]", "").Replace("[H]", "").Replace("[I]", "").Replace("[J]", "").Replace("[L]", "").Replace("[K]", "").Replace("[L]", "").Replace("[M]", "").Replace("[N]", "").Replace("[O]", "").Replace("[P]", "").Replace("[Q]", "").Replace("[R]", "").Replace("[S]", "").Replace("[T]", "").Replace("[U]", "").Replace("[W]", "").Replace("[X]", "").Replace("[Y]", "").Replace("[Z]", "").Replace("[A]", "").Replace("(C)", "").Replace("(World)", "").Replace("(Beta)", "").Replace("(En)", "").Replace("(Fr)", "").Replace("(De)", "".Replace("(Es)", "").Replace("(It)", "").Replace("(Alt)", "").Replace("(Europe)", "").Replace("(Rev 1)", "").Replace("(Rev 2)", "").Replace("(Rev 3)", "").Replace("(Rev 4)", "").Replace("(Rev 5)", "").Replace("(Asia)", "").Replace("(A)", "").Replace("(Brazil)", "").Replace("(Pt-Br)", "").Replace("(K)", "").Replace("(Korea)", "").Replace("(Ch)", "").Replace("(Chine)", "").Replace("(China)", "").Replace("(J)", "").Replace("(Japan)", "").Replace("(Usa,Europe)", "").Replace("(UE)", "").Replace("(Unl)", "").Replace("(UJE)", "").Replace("(REV01)", "").Replace("(REV02)", "").Replace("(REV03)", "").Replace("(REV04)", "").Replace("(REV05)", "").Replace("(REV)", "").Replace("(REV00)", "").Replace("(REV 00)", "").Replace("(UE)", "").Replace("PD)", "").Replace("(M1)", "").Replace("(M2)", "").Replace("(M3)", "").Replace("(M4)", "").Replace("(M5)", "").Replace("  ", " ").Replace("   ", " ").Replace("    ", " ").Replace("     ", " "
//    )))); ; ;