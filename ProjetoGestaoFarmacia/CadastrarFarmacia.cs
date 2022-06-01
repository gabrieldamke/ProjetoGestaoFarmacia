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
        public string Nome = "";
        public string Senha = "";
        public CadastrarFarmacia() 
        {
            InitializeComponent();
        }
        public CadastrarFarmacia (string nome, string senha) : this()
        {
            Nome = nome;
            Senha = senha;
        }
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String check = "select count(*) from [TB_FARMACIA] where farmacia_cnpj = '" + InserirCNPJ.Text + "' ";
            SqlCommand command = new SqlCommand(check, connection);
            connection.Open();
            int aux = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
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
            } else if (aux != 1) { 
           
            string connectionString = ConfigurationManager.ConnectionStrings["IdealFarma"].ConnectionString;
            Farmacia farmacia = new Farmacia(InserirNome.Text, InserirTelefone.Text, InserirRazaoSocial.Text, InserirCNPJ.Text, InserirEndereco.Text);
            FarmaciaDAL dal = new FarmaciaDAL(new SqlConnection(connectionString));
            dal.Inserir1(farmacia);
                connection.Open();
                String ObterIdFarmaciaQuery = "SELECT * FROM TB_FARMACIA WHERE farmacia_id = (SELECT MAX(farmacia_id) FROM TB_FARMACIA)";
                SqlCommand commandRequestId = new SqlCommand(ObterIdFarmaciaQuery, connection);
                int IdNovaFarmacia = (int)commandRequestId.ExecuteScalar();
                String ObterIdFarmaceuticoQuery = "SELECT * FROM TB_FARMACEUTICO WHERE farmaceutico_id = (SELECT MAX(farmaceutico_id) FROM TB_FARMACEUTICO)";
                SqlCommand commandRequestIdFarmaceutico = new SqlCommand(ObterIdFarmaceuticoQuery, connection);
                int IdNovoFarmaceutico = (int)commandRequestIdFarmaceutico.ExecuteScalar();
                String InsertIdFarmaciaQuery = "UPDATE TB_FARMACEUTICO SET farmaceutico_farmacia = '" + IdNovaFarmacia + "' WHERE farmaceutico_id = '" + IdNovoFarmaceutico + "' ";
                SqlCommand insCmd = new SqlCommand(InsertIdFarmaciaQuery, connection);
                insCmd.Parameters.AddWithValue("@farmaceutico_farmacia", IdNovaFarmacia);
                insCmd.ExecuteNonQuery();
                TelaPrincipal telaPrincipal = new TelaPrincipal(IdNovoFarmaceutico);
                connection.Close();
                this.Hide();
                telaPrincipal.ShowDialog();
            } else
            {
                StatusLabel.Text = "CNPJ já existe no banco de dados";
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InserirNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
