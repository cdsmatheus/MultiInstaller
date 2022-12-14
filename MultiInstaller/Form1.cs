using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MultiInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lista dos Instaladores sem o Caminho Completo
        List<string> arquivos;
        //Lista dos Instaladores com o Caminho Completo
        List<string> arquivosFull;
        string nomeArquivo;
        private void btnInstall_Click(object sender, EventArgs e)
        {
            //caso o usuário clique no botão instalar sem ter selecionado 
            //algum instalador
            if(lstProgramas.Items.Count <= 0)
            {
                MessageBox.Show("Selecione ao menos um Instalador");
            }
            else
            {
                //conta o numero de instaladores na lista
                int numInstaladores = lstProgramas.Items.Count;
                //para cada item encontrado na lista...
                for(int i = 0; i <= numInstaladores - 1; i++)
                {
                    //captura o nome do arquivo
                    nomeArquivo = lstProgramas.Items[i].ToString();
                    //caso o nome do arquivo termine em .msi
                    if (nomeArquivo.EndsWith(".msi"))
                    {
                        lblAviso.ForeColor = Color.Blue;
                        lblAviso.Text = "Instalando " + nomeArquivo;
                        Process p = new Process();
                        //instancia o processo do MSI Install
                        p.StartInfo.FileName = "msiexec.exe";
                        //adiciona os parametros de instalação silenciosa
                        //(o nome do arquivo não deve conter espaços)
                        p.StartInfo.Arguments = "/i "+ arquivosFull[i].ToString() + " /quiet /qn /norestart";
                        //inicia o processo
                        try
                        {
                            p.Start();
                            //aguarda a finalização do processo
                            p.WaitForExit();
                        }
                        catch
                        {
                            p.Kill();
                        }
                        
                    }
                    else if(nomeArquivo.EndsWith(".exe"))
                    {
                        lblAviso.ForeColor = Color.Blue;
                        lblAviso.Text = "Instalando " + nomeArquivo;
                        Process p = new Process();
                        //instancia o processo do MSI Install
                        p.StartInfo.FileName = arquivosFull[i].ToString();
                        //adiciona os parametros de instalação silenciosa
                        //(o nome do arquivo não deve conter espaços)
                        p.StartInfo.Arguments = "/S /VERYSILENT /SUPPRESSMSGBOXES /exenoui /qn /NORESTART";
                        //inicia o processo
                        try
                        {
                            p.Start();
                            //aguarda a finalização do processo
                            p.WaitForExit();
                        }
                        catch
                        {
                            p.Kill();
                        }
                    }
                }
                //ao fim da instalação de todos os programas...
                //limpa a lista visual de instaladores
                lstProgramas.Items.Clear();
                //limpa a lista virtual de instaladores sem o caminho
                arquivos.Clear();
                //limpa a lista virtual de instaladores com o caminho
                arquivosFull.Clear();
                //Mostra que o trabalho foi concluído
                lblAviso.ForeColor = Color.Green;
                lblAviso.Text = "Concluído";
                MessageBox.Show("Trabalho Concluído");
            }
        }
        private void btnSelInstal_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "MSI Files (*.msi)|*.msi|EXE Files (*.exe)|*.exe";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                arquivos = openFileDialog1.SafeFileNames.ToList();
                arquivosFull = openFileDialog1.FileNames.ToList();
                for (int i = 0; i <= arquivos.Count - 1; i++)
                {
                    lstProgramas.Items.Add(arquivos[i].ToString());
                }
            }
        }
    }
}
