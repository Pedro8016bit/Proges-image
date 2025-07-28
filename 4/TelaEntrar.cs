using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProGEs
{
    public partial class TelaEntrar : UserControl
    {
        public TelaEntrar()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Dashboard_Gestor dash = new Dashboard_Gestor();
            dash.Show();
            TelaInicial tela = new TelaInicial();
            tela.Hide();
        }
    }
}
