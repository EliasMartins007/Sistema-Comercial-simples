using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaComercial_Manha
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        public void desabilitarCamposManutencao()
        {
            txtCodigo.Enabled = false;
            txtProduto.Enabled = false;
            cmbUnidade.Enabled = false;
        }

        public void habilitarCamposManutencao()
        {
            txtCodigo.Enabled = true;
            txtProduto.Enabled = true;
            cmbUnidade.Enabled = true;
            txtCodigo.Focus();
        }

        public void limparCamposManutencao()
        {
            txtCodigo.Clear();
            txtProduto.Clear();
            cmbUnidade.SelectedIndex = -1;
            habilitarCamposManutencao();
        }

        public void PreencherComboBoxUnidade()
        {
            if (clsConexao.AbrirConexao())
            {
                string sqlUnidade = "SELECT * FROM unidade ORDER BY des_unidade";
                MySqlDataAdapter datUnidade = 
                    new MySqlDataAdapter(sqlUnidade, clsConexao.getConexao());
                DataSet dasUnidade = new DataSet();
                //Preenche o datSet com o datUnidade
                datUnidade.Fill(dasUnidade, "Unidade");
                //Identifica de qual tabela será preenchido o ComboBox
                cmbUnidade.DataSource = dasUnidade.Tables[0];
                //Identica qual o campo será preenchido o ComboBox
                cmbUnidade.DisplayMember = "des_unidade";
                cmbUnidade.SelectedIndex = -1;
                clsConexao.FecharConexao();
            }
        }
        
        public int PesquisarCodigoUnidade(string unidade)
        {
            int codigoUnidade = 0;
            if (clsConexao.AbrirConexao())
            {
                DataSet dasUnidade = new DataSet();
                string sql  = "SELECT * " +
                              "FROM unidade " +
                              "where des_unidade= '" +
                               unidade + "'";
                MySqlCommand sqlUnidade = new MySqlCommand(sql, clsConexao.getConexao());
                DataTable tabUnidade = new DataTable();
                tabUnidade.Load(sqlUnidade.ExecuteReader());
                codigoUnidade = int.Parse(tabUnidade.Rows[0]["cod_unidade"].ToString());
                clsConexao.FecharConexao();
            }
            return codigoUnidade;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = clsUsuario.Usuario;
            txtProdutoPesquisar.Focus();
            desabilitarCamposManutencao();
            PreencherComboBoxUnidade();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (clsConexao.AbrirConexao())
            {
                MySqlDataAdapter datProduto;
                //Local onde serão colocados os dados
                DataSet dasProduto = new DataSet();
                string sqlSelecao = "";
                //Comando SQL
                if (txtProdutoPesquisar.Text == "")
                {
                    sqlSelecao = 
                        "SELECT cod_produto, nom_produto, des_unidade "+
                        "FROM produto, unidade "+ 
                        "WHERE produto.cod_unidade = unidade.cod_unidade "+
                        "ORDER BY nom_produto";
                }
                else
                {
                    sqlSelecao =
                        "SELECT cod_produto, nom_produto, des_unidade " +
                        "FROM produto, unidade " +
                        "WHERE produto.cod_unidade = unidade.cod_unidade " +
                        "AND nom_produto LIKE '%" +
                        txtProdutoPesquisar.Text.ToUpper() + 
                        "%' ORDER BY nom_produto";
                }
                datProduto = new MySqlDataAdapter(sqlSelecao, clsConexao.getConexao());
                //Preenche o objetoDataset através do comando SQL
                datProduto.Fill(dasProduto, "Produto");
                //Verifica se existe o registro no objetoDataSet
                if (dasProduto.Tables[0].Rows.Count >= 1)
                {
                    dgvProduto.DataSource = dasProduto;
                    dgvProduto.DataMember = "Produto";
                    dgvProduto.Columns[0].HeaderText = "Código";
                    dgvProduto.Columns[1].HeaderText = "Produto";
                    dgvProduto.Columns[2].HeaderText = "Unidade";

                    dgvProduto.Columns[0].ReadOnly = true;
                    dgvProduto.Columns[1].ReadOnly = true;
                    dgvProduto.Columns[2].ReadOnly = true;
                }
                clsConexao.FecharConexao();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCamposManutencao();
            PreencherComboBoxUnidade();
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Captura o registro que foi selecionado no DataGrid
            int registroAtual = int.Parse(dgvProduto.CurrentRow.Index.ToString());
            //Preenche os campos da página de manutenção
            txtCodigo.Text = dgvProduto.Rows[registroAtual].Cells[0].Value.ToString();
            //Preencher comboBox Unidade    
            PreencherComboBoxUnidade();
            //Pesquisar item no ComboBox
            txtProduto.Text = dgvProduto.Rows[registroAtual].Cells[1].Value.ToString();
            int item = cmbUnidade.FindStringExact(dgvProduto.Rows[registroAtual].Cells[2].Value.ToString());
            cmbUnidade.SelectedIndex=item;
            //Selecionar Página Manutenção
            tabProduto.SelectedTab=tabManutencao;
            habilitarCamposManutencao();
            txtCodigo.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirmaExclusao;
            confirmaExclusao = MessageBox.Show("Confirma a exclusão?", "Exclusão", MessageBoxButtons.YesNo);

            if (confirmaExclusao == DialogResult.Yes)
            {
                if (clsConexao.AbrirConexao())
                {
                    string sql = "DELETE FROM Produto " +
                                 "WHERE cod_produto = '" + int.Parse(txtCodigo.Text) + "' ";
                    //Inicializa o objeto excluir
                    MySqlCommand sqlExcluir = new MySqlCommand(sql, clsConexao.getConexao());
                    sqlExcluir.ExecuteNonQuery();
                   clsConexao.FecharConexao();

                    //Limpa os campos da tela de manutenão
                    limparCamposManutencao();

                    //Refaz o dataGrid
                    btnPesquisar_Click(null, null);

                    //Seleciona a página de pesquisa
                    tabProduto.SelectedTab = tabPesquisa;
                }
            }
        }

        //**** Incluir um registro novo ****//
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codigoUnidade = PesquisarCodigoUnidade(cmbUnidade.Text); 
                
            if (clsConexao.AbrirConexao())
            {
                string sql = "insert into produto values('" +
                            int.Parse(txtCodigo.Text) + "','" +
                            txtProduto.Text + "','" +
                            codigoUnidade.ToString() + "')";
                            
                //Inicializa o objeto inserir
                MySqlCommand inserir = new MySqlCommand(sql, clsConexao.getConexao());
                //Executa o sql
                inserir.ExecuteNonQuery();
                clsConexao.FecharConexao();
            }
            //Refaz o dataGrid
            btnPesquisar_Click(null, null);
            //Seleciona a página de pesquisa
            tabProduto.SelectedTab = tabPesquisa;
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
