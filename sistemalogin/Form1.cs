using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemalogin
{
    public partial class frmLogin : Form
    {
        private readonly string emailCorreto = "usuario@exemplo.com";
        private readonly string senhaCorreta = "senha123";
        private int tentativasRestantes = 3;

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblTentativas.Text = $"Tentativas restantes: {tentativasRestantes}";

            if (txtEmail.Text != emailCorreto)
            {
                MessageBox.Show(
                    "E-mail inválido!");

                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            while (tentativasRestantes > 0)
            {
                if (txtSenha.Text == senhaCorreta)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    return;
                }
                else
                {
                    tentativasRestantes--;
                    lblTentativas.Text = $"Tentativas restantes: {tentativasRestantes}";

                    if (tentativasRestantes == 0)
                    {
                        MessageBox.Show("Conta bloqueada por excesso de tentativas.");

                        txtEmail.Enabled = false;
                        txtSenha.Enabled = false;
                        btnLogin.Enabled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta. Tente novamente");

                        txtSenha.Clear();
                        txtSenha.Focus();
                        return;

                        while (tentativasRestantes < 3)
                        {
                            if (txtEmail.Text == emailCorreto && txtSenha.Text == senhaCorreta)
                            {
                                MessageBox.Show("Login bem-sucedido!");
                                break;
                            }
                            else
                            {
                                tentativasRestantes++;

                                if (tentativasRestantes >= 3)
                                {
                                    MessageBox.Show("Conta bloqueada por excesso de tentativas.");
                                    txtEmail.Enabled = false;
                                    txtSenha.Enabled = false;
                                    btnLogin.Enabled = false;
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Senha incorreta. Tente novamente.");
                                    txtSenha.Clear();
                                    txtSenha.Focus();
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
