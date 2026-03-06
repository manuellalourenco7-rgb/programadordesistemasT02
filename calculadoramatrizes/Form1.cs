using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoramatrizes
{

    public partial class frmMatriz : Form
    {
        public frmMatriz()
        {
            InitializeComponent();
        }

        private void frmMatriz_Load(object sender, EventArgs e)
        {
            cmbDimensao.SelectedIndex = 0; // 2x2 por padrão
        }

        private void cmbDimensao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigurarGrids();
        }

        private void ConfigurarGrids()
        {
            int ordem = cmbDimensao.SelectedIndex == 0 ? 2 : 3;
            ConfigurarGrid(dgvMatrizA, ordem);
            ConfigurarGrid(dgvMatrizB, ordem);
            ConfigurarGrid(dgvResultado, ordem);
        }

        private void ConfigurarGrid(DataGridView grid, int ordem)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.ColumnCount = ordem;
            for (int i = 0; i < ordem; i++)
            {
                grid.Columns[i].Width = 60;
                grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            grid.RowCount = ordem;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.EditMode = DataGridViewEditMode.EditOnEnter;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private Matriz LerMatriz(DataGridView grid)
        {
            int linhas = grid.RowCount;
            int colunas = grid.ColumnCount;
            var m = new Matriz(linhas, colunas);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    double valor = 0;
                    var cellValue = grid.Rows[i].Cells[j].Value;
                    if (cellValue != null && double.TryParse(cellValue.ToString(), out valor))
                    {
                        m[i, j] = valor;
                    }
                }
            }
            return m;
        }

        private void ExibirMatriz(Matriz m, DataGridView grid)
        {
            int linhas = m.Linhas;
            int colunas = m.Colunas;

            if (grid.ColumnCount != colunas)
            {
                ConfigurarGrid(grid, linhas);
            }

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    grid.Rows[i].Cells[j].Value = m[i, j].ToString("F2");
                }
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                var a = LerMatriz(dgvMatrizA);
                var b = LerMatriz(dgvMatrizB);
                var resultado = Matriz.Somar(a, b);
                ExibirMatriz(resultado, dgvResultado);
                lblStatus.Text = "Soma realizada com sucesso!";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Erro na soma.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                var a = LerMatriz(dgvMatrizA);
                var b = LerMatriz(dgvMatrizB);
                var resultado = Matriz.Subtrair(a, b);
                ExibirMatriz(resultado, dgvResultado);
                lblStatus.Text = "Subtração realizada!";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Erro na subtração.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                var a = LerMatriz(dgvMatrizA);
                var b = LerMatriz(dgvMatrizB);
                var resultado = Matriz.Multiplicar(a, b);
                ExibirMatriz(resultado, dgvResultado);
                lblStatus.Text = "Multiplicação realizada!";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Erro na multiplicação.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Tela limpa.";
            lblStatus.ForeColor = Color.Black;

            int ordem = cmbDimensao.SelectedIndex == 0 ? 2 : 3;
            ConfigurarGrid(dgvMatrizA, ordem);
            ConfigurarGrid(dgvMatrizB, ordem);
            ConfigurarGrid(dgvResultado, ordem);
        }
    }
}
