using System.Diagnostics;

namespace Virus_Brasileiro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
                ProcessStartInfo pssi = new ProcessStartInfo("cmd", "/c " + "ipconfig -all")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(pssi))
                {
                    string resultado = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                label1.Text = resultado;
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

            label1.Text = string.Empty;
        }
    }
}
