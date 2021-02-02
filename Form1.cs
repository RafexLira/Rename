using System;
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
        //OBSERVACOES
        //ADICIONAR CONTADOR PARA EXPOR A QUANTIDADE DE ROMS NO DIRETÓRIO DE ORIGEM 

        List<string> Arquivos = new List<string>();
        public FileInfo NovosArquivos;
        public string DirSaida;
        public int Qtd_Origem = 0;
        public int Qtd_Saida = 0;
       
        public Form1()
        {
            InitializeComponent();
            RbAutomatico.Checked = true;
            GbManual.Enabled = false;

            TxtRemover.Text = "(USA, Europe)";
            TxtAcrescentar.Text = "";

            TxtRemover1.Text = "(USA)";           
            TxtAcrescentar1.Text = "";

            TxtRemover2.Text = "[!]";
            TxtAcrescentar2.Text = "";

            TxtRemover3.Text = "(?)";
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
            if (listBox1.Text != null)
            { 
                txtOutput.Enabled = true;
                BtnSaida.Enabled = true;
                TxtQtd_Origem.Text = Qtd_Origem.ToString();
            }
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
                    ProcessarAutomatico();
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
                try
                {   //CONFIGURAR PEGADA DOS ARQUIVOS E DIRETÓRIO
                    //verificar se os textbox podem ser nulos   
                foreach (var x in Arquivos)
                {
                    Qtd_Saida++;
                    NovosArquivos = new FileInfo(x);
                    NovosArquivos.CopyTo(Path.Combine(DirSaida, RefatoryReplaceManual(NovosArquivos.Name)));
                    progressBar1.Maximum = Qtd_Origem;
                    progressBar1.Value = Qtd_Saida;
                }
                progressBar1.Value = Qtd_Origem;
                if (Qtd_Origem!= Qtd_Saida)
                {
                    MessageBox.Show("Alguns arquivos não foram transferidos devido a duplicidade de nomes!");
                }
                MessageBox.Show("Arquivos renomeados com sucesso!");
                    progressBar1.Value = 0;
                    txtOutput.Text = "";
                    listBox1.Items.Clear();
                    Arquivos.Clear();
                    Qtd_Saida = 0;
                    Qtd_Origem = 0;
                    TxtQtd_Origem.Text = "";
            }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                    var a = DirSaida + "\\" + Path.GetFileName(RefatoryReplaceManual(NovosArquivos.Name));

                if (File.Exists(a))
                    {                   
                        Arquivos.Remove(NovosArquivos.FullName);
                        ProcessarAutomatico();
                    }
                }                                              
        }
        void ProcessarAutomatico()
        {             
            try
            { 
                foreach (var x in Arquivos)
                {
                    Qtd_Saida++;
                    NovosArquivos = new FileInfo(x);
                    NovosArquivos.CopyTo(Path.Combine(DirSaida,RefatoryReplace(NovosArquivos.Name)));
                   
                    progressBar1.Maximum = Qtd_Origem;
                    progressBar1.Value = Qtd_Saida;                  
                }
                progressBar1.Value = Qtd_Origem;
                if (Qtd_Origem != Qtd_Saida)
                {
                    MessageBox.Show("Alguns arquivos não foram transferidos devido a duplicidade de nomes!");
                }
                MessageBox.Show("Arquivos renomeados com sucesso!");
                progressBar1.Value = 0;
                listBox1.Items.Clear();
                Arquivos.Clear();
                Qtd_Saida = 0;
                Qtd_Origem = 0;
                TxtQtd_Origem.Text = "";
                txtOutput.Text = "";
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
            return _Files
              //PALAVRAS COM COLCHETES
            .Replace("[b1]", "").Replace("[b2]", "").Replace("[b3]", "").Replace("[b4]", "").Replace("[b5]", "")
            .Replace("[t1]", "").Replace("[t2]", "").Replace("[t3]", "")

            //LETRAS COM COLCHETES

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
           .Replace("3 D", " 3D ").Replace("3-D", " 3D ")

           //PALAVRAS ISOLADAS
           .Replace(" T-BR ", "").Replace(" Spa ", "").Replace(" Ita ", "")

           //VERSOES
           .Replace("(Rev 2)", "").Replace("(Rev 3)", "").Replace("(Rev 4)", "").Replace("(Rev 5)", "")
           .Replace("(Beta)", "").Replace("(Beta)", "").Replace("(REV01)", "").Replace("(REV02)", "").Replace("(REV03)", "")
           .Replace("(REV04)", "").Replace("(REV05)", "")
           .Replace("(REV)", "").Replace("(REV00)", "").Replace("(REV 00)", "").Replace("(REV01)", "")
           .Replace("(REV02)", "").Replace("(REV03)", "").Replace("(REV04)", "").Replace("(REV05)", "")
           .Replace("(REV)", "").Replace("(REV00)", "").Replace("(REV 00)", "").Replace("(Rev 1)", "").Replace("V1.2", "")
           .Replace("V1.3", "").Replace("V1.4", "").Replace("V2.1", "").Replace("V2.2", "").Replace("V2.3", "")
           .Replace("V2.4", "").Replace("V3.1", "").Replace("V3.2", "").Replace("V3.3", "").Replace("V3.4", "").Replace("V0.1", "")
           .Replace("V0.2", "").Replace("V0.3", "").Replace("Vol.", "").Replace("Vol. 1","").Replace("Vol. 2", "")
           .Replace("Vol. 3", "").Replace("Vol. I", "").Replace("Vol. II", "").Replace("Vol. III", "").Replace("V1.00", "")
           .Replace("V2.00", "").Replace("V1.0", "").Replace("V2.0", "")

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
                                    .Replace("(Japan)", "").Replace("(USA, Europe)", "").Replace("[BR]","")

                                    //OUTROS
                                    .Replace("(PD)", "").Replace("(M1)", "").Replace("(M2)", "").Replace("(M3)", "")
                                    .Replace("(M4)", "").Replace("(M5)", "").Replace("(Unl)", "").Replace("(UJE)", "").Replace("(UE)", "")
                                    .Replace("PD)", "").Replace("(M1)", "").Replace("(M2)", "").Replace("(M3)", "")
                                    .Replace("(M4)", "").Replace("Eng", "").Replace("Unl", "").Replace("[h1C]", "")
                                    .Replace("(M5)", "").Replace("[t1]", "").Replace("[t1]", "").Replace("[BF]", "").Replace("[T+Spa]", "")
                                    .Replace(" PD ", "").Replace(" M3 ", "").Replace(" M1 ", "").Replace(" M2 ", "")
                                    .Replace(" M3 ", "").Replace(" M4 ", "").Replace(" M5 ", "").Replace(" M6 ", "").Replace("[b1]", "")
                                    .Replace("[BIOS]","").Replace("[a]","").Replace("[a1]", "").Replace("[a2]", "").Replace("[a3]", "")
                                    .Replace("[a4]", "").Replace("[c1]", "").Replace("[c2]", "").Replace("[c3]", "").Replace("[c4]", "")
                                
                                    //CARACTERES ESPECIAIS
                                    .Replace("_", " ").Replace("-", " ").Replace(",", " ").Replace("_", " ").Replace("-", " ")
                                    .Replace("(", "").Replace(")", "").Replace(")", "").Replace("  ", " ").Replace("   ", " ")
                                    .Replace("    ", " ").Replace("     ", " ").Replace("[]","").Replace("[!]", "").Replace("[?]", "")
                                    .Replace("???", "").Replace(" .", ".").Replace("!!!", "").Replace("!", "").Replace("?", "")
                                    .Replace("..", ".").Replace("()", "").Replace("...", ".").Trim();
        }       
        string RefatoryReplaceManual(string _Files)
        {
            return _Files.Replace(TxtRemover.Text, TxtAcrescentar.Text)
                         .Replace(TxtRemover1.Text, TxtAcrescentar1.Text)
                         .Replace(TxtRemover2.Text, TxtAcrescentar2.Text)
                         .Replace(TxtRemover3.Text, TxtAcrescentar3.Text).Trim();
        }
        void GetArquivos()
        {
            ofd1 = new OpenFileDialog();
            ofd1.Multiselect = true;
            ofd1.FileName = "";
            //ofd1.InitialDirectory = @"C:\";
            ofd1.Filter = "Roms(*.iso;*.bin;*.rar;*.zip;*.cue;*.gba;*.gbc;*.gb;*.sms;*.gen;*.nes;*.z64;*.v64;*.rom;*.nds;*.smc;*.j64;*.gdi;*.cdi;*.gg;*.adf;*.lnx;)| *.iso;*.bin;*.rar;*.zip;*.cue;*.gba;*.gbc;*.gb;*.sms;*.gen;*.nes;*.z64;*.v64;*.rom;*.nds;*.smc;*.j64;*.gdi;*.cdi;*.gg;*.adf;*.lnx;" + "|All Files|*.*";
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
                    Qtd_Origem++;
                    listBox1.Items.Add(Path.GetFileName(arquivo));
                    Arquivos.Add(arquivo);
                }
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Arquivos.Clear();
            txtOutput.Enabled = false;
            BtnSaida.Enabled = false;
            txtOutput.Text = "";
            
            Qtd_Saida = 0;
            Qtd_Origem = 0;
        }
     
    }
}

