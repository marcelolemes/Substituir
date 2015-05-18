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

        public Sub()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(caminhoCurso.Text)) // Verifcando se o caminho inserido é válido
            {

                albumFormandos = (Directory.GetDirectories(caminhoCurso.Text, "20*"));  // Listando todos os álbuns que começam com "20" e agrupando numa variável
                pastaSubs = (Directory.GetDirectories(caminhoCurso.Text, "*Subs*").First());
                MessageBox.Show(pastaSubs);

            }

            else {
                                
            }
        }
    }
}
