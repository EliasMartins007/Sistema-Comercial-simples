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
    public partial class frmSistemaComercial : Form
    {
        public frmSistemaComercial()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ////Abrir conexão com o banco de dados
            //bool conexao = clsConexao.AbrirConexao();
            //bool validacao = false;
            //if (conexao)
            //{
            //    //Verificar se usuário existe
            //    string senha = "";
            //    validacao = true;
            //    string sql = "SELECT * FROM Usuario WHERE nom_usuario='" +
            //                    txtUsuario.Text.ToUpper() + "'";

            //    MySqlCommand sqlLogin = new MySqlCommand(sql, clsConexao.getConexao());
            //    DataTable tabLogin = new DataTable();
            //    tabLogin.Load(sqlLogin.ExecuteReader());
            //    if (tabLogin.Rows.Count > 0)
            //    {
            //        //Verificar se senha esta correta
            //        senha = tabLogin.Rows[0]["des_senha"].ToString();
            //        if (senha != txtSenha.Text)
            //        {
            //            MessageBox.Show("A senha esta incorreta!", "Erro na Senha");
            //            txtSenha.Focus();
            //            validacao = false;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Não existe usuário com este nome!", "Erro no Usuário");
            //        txtUsuario.Focus();
            //        validacao = false;
            //    }
            //    clsConexao.FecharConexao();
            //}
            //else 
            //{
            //    MessageBox.Show("Não consegui abrir a conexao!", "Erro no Banco de Dados");
            //    txtUsuario.Focus();
            //}
            //if (validacao)
            //{   //Se passou pela validação de usuário e senha
            //    //Guardar o nome do usuário na variãvel global: usuario
            //    clsUsuario.Usuario = txtUsuario.Text;
            //    timCapsLock.Enabled = false;
            //    //Instanciando a classe criando o objetoPrincipal
            //    frmPrincipal objPrincipal = new frmPrincipal();
            //    Hide();
            //    objPrincipal.ShowDialog();
            //    Show();
            //}


            //teste sem banco  16/06/2020 elias

            //Se passou pela validação de usuário e senha
            //Guardar o nome do usuário na variãvel global: usuario
            clsUsuario.Usuario = txtUsuario.Text;
            timCapsLock.Enabled = false;
            //Instanciando a classe criando o objetoPrincipal
            frmPrincipal objPrincipal = new frmPrincipal();
            Hide();
            objPrincipal.ShowDialog();
            Show();

        }

        private void timCapsLock_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                panCapsLock.Visible = true;
            else
                panCapsLock.Visible = false;
        }

        private void frmSistemaComercial_Load(object sender, EventArgs e)
        {
            timCapsLock.Enabled = true;
            txtSenha.Clear();
            txtUsuario.Text = "Digite seu nome...";
            txtUsuario.ForeColor = Color.Silver;
            txtUsuario.Focus();
            txtUsuario.Select(0, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUsuario.Text == "Digite seu nome...")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnEntrar_Click(null, null);
        }
    }
}
