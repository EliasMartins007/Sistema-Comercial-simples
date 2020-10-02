using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SistemaComercial_Manha
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void tsmProduto_Click(object sender, EventArgs e)
        {
            //Instanciando a classe criando o objProduto
            frmProduto objProduto = new frmProduto();
            Hide(); //Esconder o formulário Principal
            objProduto.ShowDialog();
            Show();//Exibi o formulário Principal
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = clsUsuario.Usuario;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sair do sistema sem retornar a tela de Login
            Process.GetCurrentProcess().Kill();
        }

        private void tsbProduto_Click(object sender, EventArgs e)
        {
            tsmProduto_Click(null, null);
        }
    }
}
