using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Hoje é quarta! ok?", "Eletiva prog. BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            /*
             * 4 partes
             * 1º parte mensagem do corpo da caixa de dialogo
             * 2º parte titulo
             * 3º parte botões
             * 4º parte icone
            */

            var sair = MessageBox.Show("Deseja sair?", "APP Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(sair == System.Windows.Forms.DialogResult.Yes)
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
