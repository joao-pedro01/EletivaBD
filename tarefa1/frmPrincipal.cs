using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        public FormPrincipal()
        {
            this.WindowState = FormWindowState.Maximized;// Inicia o código em tela cheia
            InitializeComponent();
        }

        private void itemConsProd_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto();
            frm.Show(); //Chama o forms
        }

        private void itemConsCli_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.Show(); //Chama o forms
        }
    }
}
