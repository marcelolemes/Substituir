using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SubstituirFotos2
{
    public partial class Sub : Form
    {
        List<String> arquivosPastaSubs = new List<String>(); //Arquivos à serem substituidos
        List<String> arquivosEncontrados = new List<String>(); //Arquivos encontrados, que batem com o nome dos arquivos da pasta substituir
        String[] albumFormandos = new String[] { };
        String pastaSubs;
        String nomeFoto;
        static int qtdFoto;

        public Sub()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            substituir();
         
        }

        private void caminhoCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           // BackgroundWorker worker = sender as BackgroundWorker;
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //label2.Text = qtdFoto.ToString();
        }




        private void substituir() {
            if (Directory.Exists(caminhoCurso.Text)) // Verifcando se o caminho inserido é válido
            {

                albumFormandos = (Directory.GetDirectories(caminhoCurso.Text, "*"));  // Listando todos os álbuns que começam com "20" e agrupando numa variável
                pastaSubs = (Directory.GetDirectories(caminhoCurso.Text, "*ubsti*").First());
                arquivosPastaSubs.AddRange(Directory.GetFileSystemEntries(pastaSubs, "*.jp*", SearchOption.AllDirectories)); // Listando todas as fotos da pasta substituir
                qtdFoto = 0;
                progressBar1.Maximum = arquivosPastaSubs.Count();
                foreach (String s in arquivosPastaSubs) // Percorrendo o laço dos arquivos à serem substituidos
                {


                    String[] parcial = s.Split('\\'); // Obtendo o nome da foto, extraindo com caminho geral do arquivo
                    nomeFoto = parcial[parcial.Length - 1];
                    
                    
                        qtdFoto++;

                        progressBar1.Value = qtdFoto;
                       // MessageBox.Show(progressBar1.Value.ToString());
                        // label2.Text = "Por favor aguarde!"; // Marcando na que o processo ainda está ocorrendo
                     
                    
                    foreach (String a in albumFormandos) // Laço perconrrendo a pasta dos formandos apenas
                    {
                        arquivosEncontrados.Clear(); // Limpando a lista de arquivos encontrados pela pesquisa
                        arquivosEncontrados.AddRange(Directory.GetFileSystemEntries(a, nomeFoto, SearchOption.AllDirectories)); // Listando os arquivos com o mesmo nome do arquivo à ser substituido
                        foreach (String b in arquivosEncontrados) // Laço que percorre os arquivos encontrados pela pesquisa
                        {

                            try
                            {
                                File.Copy(s, b); // Tenta copiar o arquivo
                            }
                            catch
                            { // Tratamento da exceção causada pela tentativa de copiar o arquivo

                                if (File.Equals(s, b) == true) { } // Caso origem e destino sejam iguais, não faz nada

                                else
                                { // Caso origem e destino não sejam iguais
                                    File.Delete(b); // Deleta o arquivo já existente
                                    File.Copy(s, b); // Copia o novo
                                }
                            }

                        }

                    }
                }
            }

            else
            {
                MessageBox.Show("Por favor, insira um caminho válido");
            }
        }
    }
}
