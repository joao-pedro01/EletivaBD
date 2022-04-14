using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            this.WindowState = FormWindowState.Maximized;// Inicia o código em tela cheia
            InitializeComponent();
        }

        private void itemConsClie_Click(object sender, EventArgs e)
        {
            frmPrincipal form = new frmPrincipal();
            frmCliente frm = new frmCliente();
            frm.Show(); //Chama o forms
            
        }

        private void itemConsProd_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto();
            frm.Show(); //Chama o forms
        }

        private void itemSair_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja sair?", "APP Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Você escolhe ficar!", "Eletiva Prog. BD", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
