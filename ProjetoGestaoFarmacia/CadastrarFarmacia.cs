using BibliotecaDeClasses1;
using ProjetoGestaoFarmacia.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGestaoFarmacia
{
    public partial class CadastrarFarmacia : Form
    {
        public CadastrarFarmacia()
        {
            InitializeComponent();
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            StatusLabel.Visible = false;
            if (InserirTelefone.Text == "" || InserirCNPJ.Text == "" || InserirEndereco.Text == "" || InserirNome.Text == "" || InserirRazaoSocial.Text == "" )
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Existe campos vazios. Por favor preencha!";
            } else
            if (!Regex.Match(InserirTelefone.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Insira seu telefone no formato (xx) 9xxxx-xxxx";
            } else
            if (!Regex.Match(InserirCNPJ.Text, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)").Success)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Insira um CNPJ válido";
            } else { 
           
            string connectionString = ConfigurationManager.ConnectionStrings["IdealFarma"].ConnectionString;
            Farmacia farmacia = new Farmacia(InserirNome.Text, InserirTelefone.Text, InserirRazaoSocial.Text, InserirCNPJ.Text, InserirEndereco.Text);
            FarmaciaDAL dal = new FarmaciaDAL(new SqlConnection(connectionString));
            dal.Inserir1(farmacia);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
