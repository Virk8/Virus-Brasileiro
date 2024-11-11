using System.Collections.Immutable;
using System.Threading;
using System.Windows.Forms;
using Windows.Foundation.Diagnostics;
using System.Collections.Generic;
using System.Resources;
using System.IO;
using System.Xml.Linq;
using Virus_Brasileiro.Properties;

namespace Virus_Brasileiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string caminhoPasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".cache");
            string caminhoArquivo = Path.Combine(caminhoPasta, "☭.virk");
                if (File.Exists(caminhoArquivo))
                {
                    button3.Hide();
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Texto1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            Task.Delay(350).Wait();
            Form2.Hide();
            button3.Hide();

            string caminhoPasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".cache");
            string caminhoArquivo = Path.Combine(caminhoPasta, "☭.virk");
            // Verificar se o arquivo existe, caso contrário, cria um com valor inicial
            File.WriteAllText(caminhoArquivo, "1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
