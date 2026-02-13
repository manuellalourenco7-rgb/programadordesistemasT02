using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorademedia
{
    public partial class frmCalculadoraMedia : Form
    {
        public frmCalculadoraMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota01 = double.Parse(txtNota01.Text);
            double nota02 = double.Parse(txtNota02.Text);
            double nota03 = double.Parse(txtNota03.Text);
            double nota04 = double.Parse(txtNota04.Text);

            double media = (nota01 + nota02 + nota03 + nota04) / 4;

            txtResultado.Text = Convert.ToString(media);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNota01.Text = String.Empty;
            txtNota02.Text = String.Empty;
            txtNota03.Text = String.Empty;
            txtNota04.Text = String.Empty;
            txtResultado.Text = String.Empty;
        }

        private void frmCalculadoraMedia_Load(object sender, EventArgs e)
        {

        }
    }
}
