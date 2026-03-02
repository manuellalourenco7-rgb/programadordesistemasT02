using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControledeEstoque
{
    public partial class frmControleEstoque : Form
    {
 
        public class Produto
        {
            public string Nome { get; set; }
            public string Quantidade { get; set; }
        }

        public List<Produto> produtos;
        public frmControleEstoque()
        {
            InitializeComponent();
            produtos = new List<Produto>();
        }

        private void DisplayData()
        {
            DataTable dt = new DataTable();
            dt = ConvertToDatatable();
            dataGridView1.DataSource = dt;
        }

        private void ClearData()
        {
            txtProduto.Text = "";
            txtQuantidade.Text = "";
        }

        public DataTable ConvertToDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Produto");
            dt.Columns.Add("Quantidade");
            foreach (var item in produtos)
            {
                var row = dt.NewRow();
                row["Produto"] = item.Nome;
                row["Quantidade"] = item.Quantidade;
                dt.Rows.Add(row);
            }
            return dt;
        }
        private void VerificarEstoque()
        {
            foreach (var item in produtos)
            {
                if (int.Parse(item.Quantidade) < 5)
                {
                    MessageBox.Show($"Alerta: Baixo estoque do produto {item.Nome}. Reabasteça!");
                }
            }
        }
        private void AddToList(string text1, string text2)
        {
            produtos.Add(new Produto { Nome = text1, Quantidade = text2 });
        }
        private void UpdateToList(string text1, string text2)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            produtos[index] = new Produto { Nome = text1, Quantidade = text2 };
        }
        private void DeleteToList()
        {
            int index = dataGridView1.SelectedRows[0].Index;
            produtos.RemoveAt(index);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != "" && txtQuantidade.Text != "")
            {
                AddToList(txtProduto.Text, txtQuantidade.Text);
                //MessageBox.Show("Registrado com sucesso!");
                DisplayData();
                ClearData();
                VerificarEstoque();
            }
            else
            {
                MessageBox.Show("Forneça detalhes!");
            }
        }


        private void btnReabastecer_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != "" && txtQuantidade.Text != "")
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    UpdateToList(txtProduto.Text, txtQuantidade.Text);
                    //MessageBox.Show("Registrado com sucesso!");
                    DisplayData();
                    ClearData();
                    VerificarEstoque();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione o produto que deseja atualizar.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                DeleteToList();
                //MessageBox.Show("Deletado com sucesso!");
                DisplayData();
                ClearData();
                VerificarEstoque();
            }
            else
            {
                MessageBox.Show("Por favor, selecione o produto que deseja deletar.");
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillInputControls(e.RowIndex);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillInputControls(e.RowIndex);
        }
        private void FillInputControls(int Index)
        {
            if (Index > -1)
            {
                txtProduto.Text = dataGridView1.Rows[Index].Cells[0].Value.ToString();
                txtQuantidade.Text = dataGridView1.Rows[Index].Cells[1].Value.ToString();
            }
        }
    }
}
