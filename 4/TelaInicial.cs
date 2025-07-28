using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProGEs
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            timer.Start();
        }


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        private void TelaInicial_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        int progresso = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            pgbCarregamento.Minimum = 0;
            pgbCarregamento.Maximum = 100;
            pgbCarregamento.Step = 1;

            pgbCarregamento.Value = progresso;
            progresso += 20;

            if (progresso > 100)
            {
                timer.Stop();
            }

            if (pgbCarregamento.Value == 100)
            {
                TelaEntrar tela_entrarUc = new TelaEntrar();
                pnlFill.Controls.Clear();
                tela_entrarUc.Dock = DockStyle.Fill;
                pnlFill.Controls.Add(tela_entrarUc);
            }
        }

        private void TelaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if(pgbCarregamento.Value <= 50 && e.KeyCode == Keys.P)
            {
                timer.Stop();
                Tela_cad tela = new Tela_cad();
                pnlFill.Controls.Clear();
                tela.Dock = DockStyle.Fill;
                pnlFill.Controls.Add(tela);

            }
        }
    }
}
