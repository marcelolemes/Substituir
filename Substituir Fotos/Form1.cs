using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
namespace Substituir_Fotos
{
    public partial class Form1 : Form
    {

        String[] Diretorio = new String[] { };
        valores[] relat = new valores[] { };
        valores valor = new valores();
        List<String> arquivos = new List<String>(); //apenas nomes que serão processados
        List<String> arquivos2 = new List<String>(); //manipulador de arquivos encontrados

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (camCurso2.ShowDialog() == DialogResult.OK)
            {
                camCurso.Text = camCurso2.SelectedPath;
            }
            else
            {
                MessageBox.Show("Digite por favor um caminho válido");
            }
        }

        private void btnOri_Click(object sender, EventArgs e)
        {

            try
            {
                camImg2.InitialDirectory = Directory.GetCurrentDirectory();

            }
            catch
            { camImg2.InitialDirectory = Directory.GetCurrentDirectory(); }

            if (camImg2.ShowDialog() == DialogResult.OK) // confirma se foi obtido sucesso na hora de selecionar arquivos
            {
                camImg.Text = camImg2.FileName;
                if (camImg2.FileNames.Length > 1)
                {//caso haja mais de um arquivo selecionado recebe em uma LIST
                    arquivos.AddRange(camImg2.FileNames);
                }
            }
            else
            {
                if (camImg.Text.Length < 5 || camImg.Text.Equals("Multiplos arquivos selecionados"))
                {
                    MessageBox.Show("Digite algum número de imagem por favor");
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
         

                
                {  // ação caso um arquivo seja selecionado

                    if (camImg.Text.Length < 4) // caso nada esteja na caixa de texto de imagem, lança uma mensagem
                    {
                        MessageBox.Show("Digite algum número de imagem por favor");
                    }
                    else
                    {

                        String[] parcial = camImg.Text.Split('\\');
                        nomeFoto = parcial[parcial.Length - 1];


                        // MessageBox.Show("Nome foto " + nomeFoto);
                        if (camCurso.Text.Length < 3)
                        {
                            MessageBox.Show("Por favor, digite o caminho de destino");
                        }
                        else
                        {
                            try // recebendo diretorios que começam com 20
                            {
                                Diretorio = (Directory.GetDirectories(camCurso.Text, "20*"));
                            }
                            catch
                            {
                                MessageBox.Show("Falha ao obter pasta de destino, por favor tente novamente");
                            }
                            //  MessageBox.Show(Diretorio.Length + " albuns");

                            foreach (String a in Diretorio)
                            {

                                arquivos2.Clear();
                                arquivos2.AddRange(Directory.GetFileSystemEntries(a, nomeFoto, SearchOption.AllDirectories)); //pesquisando arquivos com o mesmo nome
                                if (arquivos2.Count > 0)
                                {
                                    foreach (String b in arquivos2)
                                    {
                                        //correndo os arquivos e caso o arquivo de origem e o de destino não sendo iguais, ele será copiado

                                        try
                                        {
                                            File.Copy(camImg.Text, b);
                                        }
                                        catch
                                        {
                                            if (File.Equals(camImg.Text, b) == true) { }
                                            else
                                            {
                                                File.Delete(b);
                                                File.Copy(camImg.Text, b);
                                            }
                                        }

                                    }

                                }
                            }




                        }

                        // fim da busca de um arquivo
                    }


                }
                //MessageBox.Show("Arquivo " + camImg.Text);








            }
            
            {// jogar para todos os álbuns caso assim marcado na checkbox
                try
                {
                    Diretorio = (Directory.GetDirectories(camCurso.Text, "20*"));
                    foreach (String a in Diretorio)
                    {
                        String[] parcial = camImg.Text.Split('\\');
                        string nomeFoto = parcial[parcial.Length - 1];

                        if (!File.Exists(a + "\\" + nomeFoto))
                        {
                            File.Copy(camImg.Text, a + "\\" + nomeFoto);
                        }
                        //  MessageBox.Show("de "+camImg.Text+" para"+ a + "\\" + nomeFoto);
                    }
                }
                catch
                {

                    MessageBox.Show("ERRO!", "Falha ao substituir!");
                }

            }
            // fim botão 
            MessageBox.Show("FIM!", "FIM!");
        }

        private void camImg_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void camImg_DragDrop(object sender, DragEventArgs e)
        {// caso sejam arrastados arquivos para o caminho
            Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
            if (a.Length > 1)
            {
                foreach (String s in a)
                {
                    arquivos.Add(s);
                    camImg.Text = "Multiplos arquivos selecionados";
                }
            }
            else
                camImg.Text = a.GetValue(0).ToString();

            //   MessageBox.Show("Tamanho de a "+a.Length);

        }

        private void camImg_TextChanged(object sender, EventArgs e)
        {

        }

        private void camImg2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void camCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void camCurso_DragEnter(object sender, DragEventArgs e)
        {
            Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
            camCurso.Text = a.GetValue(0).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                camCurso.Text = Clipboard.GetText(TextDataFormat.Text);
            }
        }

        private void camCurso_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                camCurso.Text = Clipboard.GetText(TextDataFormat.Text);
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
