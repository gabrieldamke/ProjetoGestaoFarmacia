using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class EditarDadosFarmacia : Form
    {
        public int FarmaciaID;
        public EditarDadosFarmacia(int FarmaciaId)
        {
            InitializeComponent();
            FarmaciaID = FarmaciaId;
        }

        private void EditarDadosFarmacia_Load(object sender, EventArgs e)
        {

        }

        public void RetornarDadosFarmaceutico(int IDfarmacia)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            IDfarmacia = FarmaciaID;
            // Definir nome
            String ObterNomeFarmaciaQuery = "select farmacia_nome from [TB_FARMACIA] where farmacia_id = '" + IDfarmacia + "' ";
            SqlCommand cmdGetNomeFarmacia = new SqlCommand(ObterNomeFarmaciaQuery, connection);
            InserirNome.Text = (string)cmdGetNomeFarmacia.ExecuteScalar();
            // Definir Telefone
            String ObterTelefoneFarmaciaQuery = "select farmacia_telefone from [TB_FARMACIA] where farmacia_id = '" + IDfarmacia + "' ";
            SqlCommand cmdGetTelefoneFarmacia = new SqlCommand(ObterTelefoneFarmaciaQuery, connection);
            InserirTelefone.Text = (string)cmdGetTelefoneFarmacia.ExecuteScalar();
            // Definir Endereço
            String ObterEnderecoFarmaciaQuery = "select farmaceutico_endereco from [TB_FARMACEUTICO] where farmacia_id = '" + IDfarmacia + "' ";
            SqlCommand cmdGetEnderecoFarmacia = new SqlCommand(ObterEnderecoFarmaciaQuery, connection);
            InserirEndereco.Text = (string)cmdGetEnderecoFarmacia.ExecuteScalar();
            // Definir CNPJ
            String ObterCNPJFarmaciaQuery = "select farmacia_cnpj from [TB_FARMACIA] where farmaceutico_id = '" + IDfarmacia + "' ";
            SqlCommand cmdGetCNPJFarmacia = new SqlCommand(ObterCNPJFarmaciaQuery, connection);
            InserirCNPJ.Text = (string)cmdGetCNPJFarmacia.ExecuteScalar();
            // Definir Razao social
            String ObterRazaoSocialFarmaciaQuery = "select farmacia_razaoSocial from [TB_FARMACIA] where farmaceutico_id = '" + IDfarmacia + "' ";
            SqlCommand cmdGetEmailFarmaceutico = new SqlCommand(ObterRazaoSocialFarmaciaQuery, connection);
            InserirRazaoSocial.Text = (string)cmdGetEmailFarmaceutico.ExecuteScalar();


            connection.Close();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            String ObterCNPJFarmaceuticoQuery = "select farmacia_cnpj from [TB_FARMACIA] where farmacia_id = '" + FarmaciaID + "' ";
            SqlCommand cmdGetEmailFarmaceutico = new SqlCommand(ObterCNPJFarmaceuticoQuery, connection);
            String CNPJAtual = (string)cmdGetEmailFarmaceutico.ExecuteScalar();
            String check = "select count(*) from [TB_FARMACIA] where farmacia_cnpj = '" + InserirCNPJ.Text + "' ";
            SqlCommand command = new SqlCommand(check, connection);
            int aux = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            if (InserirTelefone.Text == "" || InserirCNPJ.Text == "" || InserirEndereco.Text == "" || InserirNome.Text == "" || InserirRazaoSocial.Text == "")
            {
                this.Alert("Preencha todos os campos!", Form_Alert.enmType.Error);
            }
            else
            if (!Regex.Match(InserirTelefone.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                this.Alert("Telefone Inválido!", Form_Alert.enmType.Error);
            }
            else
            if (!Regex.Match(InserirCNPJ.Text, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)").Success)
            {
                this.Alert("CNPJ é inválido!", Form_Alert.enmType.Error);
            }
            else if (aux == 1 && InserirCNPJ.Text != CNPJAtual)
            {
                this.Alert("Esse CNPJ já foi cadastrado!", Form_Alert.enmType.Error);
            }
            else
            {
                connection.Open();
                String UpdateFuncionarioQuery = "UPDATE TB_FARMACIA SET farmacia_nome = '" + InserirNome.Text + "', farmacia_telefone = '" + InserirTelefone.Text + "', farmacia_razaosocial = '" + InserirRazaoSocial.Text + "', farmacia_cnpj = '" + InserirCNPJ.Text + "', farmacia_endereco = '" + InserirEndereco.Text + "' WHERE farmacia_id = '" + FarmaciaID + "' ";
                SqlCommand insCmd = new SqlCommand(UpdateFuncionarioQuery, connection);
                insCmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
