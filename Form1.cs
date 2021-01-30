﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using System.IO;
using System.Linq;


namespace Rename
{
    public partial class Form1 : Form

    {
        List<string> ArquivoTeste = new List<string>();

        List<string> Arquivos = new List<string>();
        public FileInfo NovosArquivos;
        public string DirSaida;
       
        public Form1()
        {
            InitializeComponent();
            RbAutomatico.Checked = true;
            GbManual.Enabled = false;

            TxtRemover.Text = "(U)";
            TxtAcrescentar.Text = "";

            TxtRemover1.Text = "-";           
            TxtAcrescentar1.Text = " ";

            TxtRemover2.Text = "[!]";
            TxtAcrescentar2.Text = "";

            TxtRemover3.Text = "[USA]";
            TxtAcrescentar3.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (listBox1.Text != null) txtOutput.Enabled = true ;
        }
        private void BtnRenomear_Click(object sender, EventArgs e)
        {

            if (DirSaida != null)
            {
                if (RbManual.Checked == true)
                {
                    ProcessarManual();
                }
                if (RbAutomatico.Checked == true)
                {
                    //VerificarDuplicidade();
                    ProcessarAutomatico();
                    //VerificarDuplicidade();
                }
               
            }
            else
            {
                MessageBox.Show("A pasta de saída do arquivo não pode ser nulo");
            }

        }

       
        private void BtnSaida_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;

            fbd.Description = "Salvar em ";


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirSaida = fbd.SelectedPath;
                txtOutput.Text = DirSaida;
            }

        }
    
        void ProcessarManual()
        {
            foreach (var x in Arquivos)
            {
             
                try
                {
                    //CONFIGURAR PEGADA DOS ARQUIVOS E DIRETÓRIO
                    //verificar se os textbox podem ser nulos                   

                    NovosArquivos = new FileInfo(x);                 
                    NovosArquivos.MoveTo(Path.Combine(DirSaida, NovosArquivos.Name.Replace(TxtRemover.Text, TxtAcrescentar.Text)
                   .Replace(TxtRemover1.Text, TxtAcrescentar1.Text).Replace(TxtRemover2.Text, TxtAcrescentar2.Text)
                   .Replace(TxtRemover3.Text, TxtAcrescentar3.Text).ToUpper().Trim()
                   ));

                    MessageBox.Show("Arquivos renomeados com sucesso!");
                    listBox1.Items.Clear();
                    Arquivos.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    var a = DirSaida + "\\" + Path.GetFileName(RefatoryReplace(NovosArquivos.Name));

                    if (File.Exists(a))
                    {
                        Arquivos.Remove(NovosArquivos.FullName);
                        ProcessarAutomatico();

                    }
                }                   
               
            }
        }
        void ProcessarAutomatico()
        {          
            // aintes de iniciaro processo o programa deve limpar a pasta de origem 
            //caso ela seja diferente de null ou vazia
            //aplicar conceito no processo manual.. bug 
            try
            { 
                foreach (var x in Arquivos)
                {
                    NovosArquivos = new FileInfo(x);
                    NovosArquivos.CopyTo(Path.Combine(DirSaida,RefatoryReplace(NovosArquivos.Name)));  
                }
                MessageBox.Show("Arquivos renomeados com sucesso!");
                listBox1.Items.Clear();
                Arquivos.Clear();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                var a = DirSaida + "\\" + Path.GetFileName(RefatoryReplace(NovosArquivos.Name));                
                
                if (File.Exists(a))
                {
                    Arquivos.Remove(NovosArquivos.FullName);
                    ProcessarAutomatico();                   
                   
                }
            }                          

        }

       string RefatoryReplace(string _Files)
        {

                                 //LETRAS COM COCHETES
                                 return _Files
                                .Replace("[A]", "").Replace("[B]", "").Replace("[C]", "").Replace("[D]", "").Replace("[E]", "")
                                .Replace("[F]", "").Replace("[G]", "").Replace("[H]", "").Replace("[I]", "").Replace("[J]", "")
                                .Replace("[K]", "").Replace("[L]", "").Replace("[M]", "").Replace("[N]", "").Replace("[O]", "")
                                .Replace("[P]", "").Replace("[Q]", "").Replace("[R]", "").Replace("[S]", "").Replace("[T]", "")
                                .Replace("[U]", "").Replace("[V]", "").Replace("[W]", "").Replace("[X]", "").Replace("[Y]", "").Replace("[Z]", "")

                                //LETRAS COM PARÊNTESES
                                .Replace("(A)", "").Replace("(B)", "").Replace("(C)", "").Replace("(D)", "").Replace("(E)", "").Replace("(F)", "")
                                .Replace("(G)", "").Replace("(H)", "").Replace("(I)", "").Replace("(J)", "")
                                .Replace("(L)", "").Replace("(M)", "").Replace("(N)", "").Replace("(O)", "").Replace("(P)", "").Replace("(Q)", "")
                                .Replace("(R)", "").Replace("(S)", "").Replace("(T)", "").Replace("(U)", "")
                                .Replace("(V)", "").Replace("(W)", "").Replace("(X)", "").Replace("(Y)", "").Replace("(Z)", "")

                                //LETRAS ISOLADAS
                                .Replace(" A ", "").Replace(" E ", "").Replace(" I ", "").Replace(" O ", "").Replace(" U ", "")

                                //PALAVRAS ISOLADAS
                                .Replace(" T-BR ", "").Replace(" Spa ", "").Replace(" Ita ", "")

                                //VERSOES
                                .Replace("(Rev 2)", "").Replace("(Rev 3)", "").Replace("(Rev 4)", "").Replace("(Rev 5)", "")
                                .Replace("(Beta)", "").Replace("(Beta)", "").Replace("(REV01)", "").Replace("(REV02)", "").Replace("(REV03)", "")
                                .Replace("(REV04)", "").Replace("(REV05)", "")
                                .Replace("(REV)", "").Replace("(REV00)", "").Replace("(REV 00)", "").Replace("(REV01)", "")
                                .Replace("(REV02)", "").Replace("(REV03)", "").Replace("(REV04)", "").Replace("(REV05)", "")
                                .Replace("(REV)", "").Replace("(REV00)", "").Replace("(REV 00)", "").Replace("(Rev 1)", "")

                               
                                //PAISES ORIGEM E LOCALIZACAO
                                .Replace("(World)", "").Replace("(EU)", "").Replace("(US)", "")
                                .Replace("(UE)", "").Replace("(Unl)", "").Replace("(UJE)", "")
                                .Replace("(EUA)", "").Replace("(USA)", "").Replace("(BR)", "")
                                .Replace("(En)", "").Replace("(Fr)", "").Replace("(De)", "").Replace("(Es)", "")
                                .Replace("(It)", "").Replace("(Alt)", "").Replace("(Europe)", "")

                                .Replace("(Asia)", "").Replace("(Brazil)", "").Replace("(Pt-Br)", "")
                                .Replace("(Korea)", "").Replace("(Ch)", "").Replace("(Chine)", "").Replace("(China)", "")
                                .Replace("(Japan)", "").Replace("(Usa,Europe)", "")
                                .Replace("(EU)", "").Replace("(US)", "")
                                .Replace("(BR)", "").Replace("(UE)", "")
                                .Replace("(World)", "").Replace("(UE)", "").Replace("(Unl)", "").Replace("(UJE)", "")
                                .Replace("(En)", "").Replace("(Fr)", "").Replace("(De)", "").Replace("(Es)", "")
                                .Replace("(It)", "").Replace("(Alt)", "").Replace("(Europe)", "")

                                .Replace("(Asia)", "").Replace("(Brazil)", "").Replace("(Pt-Br)", "")
                                .Replace("(Korea)", "").Replace("(Ch)", "").Replace("(Chine)", "").Replace("(China)", "")
                                .Replace("(Japan)", "").Replace("(Usa,Europe)", "")


                                //OUTROS
                                .Replace("(PD)", "").Replace("(M1)", "").Replace("(M2)", "").Replace("(M3)", "")
                                .Replace("(M4)", "").Replace("(M5)", "").Replace("(Unl)", "").Replace("(UJE)", "").Replace("(UE)", "")
                                .Replace("PD)", "").Replace("(M1)", "").Replace("(M2)", "").Replace("(M3)", "")
                                .Replace("(M4)", "").Replace("M5", "").Replace("M6", "").Replace("Eng", "").Replace("Unl", "")
                                .Replace("(M5)", "").Replace("[t1]", "").Replace("[t1]", "")
                                .Replace("PD", "").Replace("M3", "").Replace("M1", "").Replace("M2", "")
                                .Replace("M3", "").Replace("M4", "").Replace("M5", "").Replace("[b1]", "").Replace("[BIOS]","")

                                //CARACTERES ESPECIAIS
                                .Replace("_", " ").Replace("-", " ").Replace(",", " ").Replace("_", " ").Replace("-", " ")
                                .Replace("(", "").Replace(")", "").Replace(")", "").Replace("  ", " ").Replace("   ", " ")
                                .Replace("    ", " ").Replace("     ", " ").Replace("[!]", "").Replace("[?]", "")
                                .Replace("???", "").Replace(" .", ".").Replace("!!!", "").Trim().ToUpper();
        }
        void GetArquivos()
        {
            ofd1 = new OpenFileDialog();
            ofd1.Multiselect = true;
            ofd1.FileName = "";
            //ofd1.InitialDirectory = @"C:\";
            ofd1.Filter = "Roms(*.iso;*.bin;*.rar;*.zip;*.cue;*.gba;*.gbc;*.gb;*.sms;*.gen;*.nes;*.z64;*.v64;*.rom;*.nds;*.smc;)| *.iso;*.bin;*.rar;*.zip;*.cue;*.gba;*.gbc;*.gb;*.sms;*.gen;*.nes;*.z64;*.v64;*.rom;*.nds;*.smc" + "|All Files|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 1;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;
           
           

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                foreach (var arquivo in ofd1.FileNames)
                {
                    listBox1.Items.Add(arquivo);
                    Arquivos.Add(arquivo);
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Arquivos.Clear();
        }
    }
}

