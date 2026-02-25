using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dadosnecessarios
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void lblDataNasc_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoO;


            //Validação de campos obrigátórios
            if (string.IsNullOrWhiteSpace(txtNumeroCadastrado.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro");
                return; //Interrompe a execução do código caso o campo esteja vazio
            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o seu nome completo");
                return; //Interrompe a execução do código caso o campo esteja vazio
            }
            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("POr favor, selecione a cidade.");
                return;
            }
            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbOutros.Checked)
            {
                MessageBox.Show("Por favor, selecione o gênero.");
                return;
            }

            //Agora, caso todos os campos estejam preenchidos, a validação prossegue
            numeroCadastro = Convert.ToInt32(txtNumeroCadastrado.Text);
            nomeUsuario = txtNomeCompleto.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoO = rbOutros.Checked;


            //Formatar a data para exibir apenas a data (sem a hora)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            //Determina o gênero selecionado
            string generoSelecionado = "Não informado"; //Caso nenhum gênero seja selecionado

            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else 
                generoSelecionado = "Outros";

           //Exibir as informações em MessageBox
            MessageBox.Show("Número cadastrado: " + numeroCadastro);
            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data de nascimento: " + dataFormatada);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Gênero: " + generoSelecionado);

            

        }

        private void txtNumeroCadastrado_Leave(object sender, EventArgs e)
        {
            txtNumeroCadastrado.Clear();
        }

        private void txtNomeCompleto_Leave(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
        }
    }
}
