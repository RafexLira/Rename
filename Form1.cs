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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.ofd1.FileName = "OpenFileDialog1";

            this.ofd1.Multiselect = true;
            this.ofd1.FileName = "Selecionar roms";
            this.ofd1.InitialDirectory = @"C:\";
            this.ofd1.Filter = "Roms(*.iso;*.bin;*.rar;*.zip;*.cue;*.gba;*.gbc;*.gb;*.sms;*.gen;*.nes;*.z64;*.v64;*.rom;*.nds;*.smc;)| *.iso;*.bin;*.rar;*.zip;*.cue;*.gba;*.gbc;*.gb;*.sms;*.gen;*.nes;*.z64;*.v64;*.rom;*.nds;*.smc;|";

            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();
            
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                  
                   
                  
                    try
                    {
                        listBox1.Items.Add(arquivo);
                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança");
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem");
                    }
                }
            }
        }//fim e evento botão


          }


}
