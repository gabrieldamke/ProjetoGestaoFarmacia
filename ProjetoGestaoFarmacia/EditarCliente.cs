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
    public partial class EditarCliente : Form
    {
        public int ClienteID;
        public int FarmaciaID;
        public EditarCliente(int clienteId, int FarmaciaId)
        {
            InitializeComponent();
            ClienteID = clienteId;
            FarmaciaID = FarmaciaId;
        }
        public void RetornarDadosCliente()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            // Definir nome
            String ObterNomeClienteQuery = "select cliente_nome from [TB_CLIENTE] where cliente_id = '" + ClienteID + "' ";
            SqlCommand cmdGetNomeCliente = new SqlCommand(ObterNomeClienteQuery, connection);
            InserirUsuario.Text = (string)cmdGetNomeCliente.ExecuteScalar();
            // Definir Telefone
            String ObterTelefoneClienteQuery = "select cliente_telefone from [TB_CLIENTE] where cliente_id = '" + ClienteID + "' ";
            SqlCommand cmdGetTelefoneCliente = new SqlCommand(ObterTelefoneClienteQuery, connection);
            InserirTelefone.Text = (string)cmdGetTelefoneCliente.ExecuteScalar();
            // Definir Endereço
            String ObterEnderecoClienteQuery = "select cliente_endereco from [TB_CLIENTE] where cliente_id = '" + ClienteID + "' ";
            SqlCommand cmdGetEnderecoCliente = new SqlCommand(ObterEnderecoClienteQuery, connection);
            InserirEndereco.Text = (string)cmdGetEnderecoCliente.ExecuteScalar();
            // Definir RG
            String ObterRGClienteQuery = "select cliente_rg from [TB_CLIENTE] where cliente_id = '" + ClienteID + "' ";
            SqlCommand cmdGetRGCliente = new SqlCommand(ObterRGClienteQuery, connection);
            InserirRG.Text = (string)cmdGetRGCliente.ExecuteScalar();
            // Definir Genero
            String ObterGeneroClienteQuery = "select cliente_genero from [TB_CLIENTE] where cliente_id = '" + ClienteID + "' ";
            SqlCommand cmdGetGeneroCliente = new SqlCommand(ObterGeneroClienteQuery, connection);
            String Genero = (string)cmdGetGeneroCliente.ExecuteScalar();
            if (Genero == "Masculino")
            {
                Masculino.Checked = true;
            }
            else if (Genero == "Feminino")
            {
                Feminino.Checked = true;
            }
            // Definir Email
            String ObterEmailClienteQuery = "select cliente_email from [TB_CLIENTE] where cliente_id = '" + ClienteID + "' ";
            SqlCommand cmdGetEmailCliente = new SqlCommand(ObterEmailClienteQuery, connection);
            InserirEmail.Text = (string)cmdGetEmailCliente.ExecuteScalar();


            connection.Close();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void EditarCliente_Load(object sender, EventArgs e)
        {
            RetornarDadosCliente();
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            string Genero = "";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            // Verificar RG existente
            String check = "select count(*) from [TB_CLIENTE] where cliente_rg = '" + InserirRG.Text + "' ";
            SqlCommand command = new SqlCommand(check, connection);
            int aux = Convert.ToInt32(command.ExecuteScalar().ToString());
            String ObterRGClienteQuery = "select cliente_rg from [TB_CLIENTE] where cliente_id = '" + ClienteID + "' ";
            SqlCommand cmdGetRGCliente = new SqlCommand(ObterRGClienteQuery, connection);
            string rgCliente = (string)cmdGetRGCliente.ExecuteScalar();
            connection.Close();

            if (Masculino.Checked && Feminino.Checked)
            {
                this.Alert("Escolha apenas um genêro!", Form_Alert.enmType.Error);
            }
            else if (!Masculino.Checked && !Feminino.Checked)
            {
                this.Alert("Escolha um genêro!", Form_Alert.enmType.Error);
            }
            else if (Masculino.Checked)
            {
                Genero = "Masculino";
            }
            else if (Feminino.Checked)
            {
                Genero = "Feminino";
            }

            if (InserirUsuario.Text == "" || InserirRG.Text == "" || InserirTelefone.Text == "" || InserirEndereco.Text == "")
            {
                this.Alert("Existe campos vazios!", Form_Alert.enmType.Error);
            }

            else if (!Regex.Match(InserirUsuario.Text, "^[A-Za-z]+(([,.] |[ '-])[A-Za-z]+)*([.,'-]?)$").Success)
            {
                this.Alert("Deve inserir nome e sobrenome!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success && InserirEmail.Text != "")
            {
                this.Alert("Deve inserir um email válido!", Form_Alert.enmType.Error);
            }
            else if (aux == 1 && InserirRG.Text != rgCliente)
            {
                this.Alert("RG já cadastrado!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirTelefone.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                this.Alert("Insira um telefone válido!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirRG.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success )
            {
                this.Alert("Insira um RG válido!", Form_Alert.enmType.Error);
            }
            else
            {
                connection.Open();
                String UpdateFuncionarioQuery = "UPDATE TB_CLIENTE SET cliente_nome = '" + InserirUsuario.Text + "', cliente_telefone = '" + InserirTelefone.Text + "', cliente_rg = '" + InserirRG.Text + "', cliente_genero = '" + Genero + "', cliente_email = '" + InserirEmail.Text + "', cliente_endereco = '" + InserirEndereco.Text + "' WHERE cliente_id = '" + ClienteID + "' ";
                SqlCommand insCmd = new SqlCommand(UpdateFuncionarioQuery, connection);
                insCmd.ExecuteNonQuery();
                connection.Close();
                this.Alert("Dados alterados com sucesso!", Form_Alert.enmType.Success);
                this.Close();
            }
        }
    }
}
