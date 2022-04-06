using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;// Inicia o código em tela cheia
            InitializeComponent();
        }

        private void itemMenuCliente_Click(object sender, EventArgs e)
        {

        }

        private void itemMenuProduto_Click(object sender, EventArgs e)
        {

        }

        private void itemMenuCategoria_Click(object sender, EventArgs e)
        {

        }

        private void itemMenuSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
