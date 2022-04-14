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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void cadastrarProduto_Click(object sender, EventArgs e)
        {
            var Op = MessageBox.Show("Deseja cadastrar produto?", "Produto | Eletiva Prog. BD", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (Op == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Logo sera implementado a função de cadastrar produto!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Op = MessageBox.Show("Deseja fazer outra operação?", "Produto | Eletiva Prog. BD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(Op == System.Windows.Forms.DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
