using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGestaoFarmacia
{
    public partial class ConsultarClientes : Form
    {
        public int FarmaciaID;
        public ConsultarClientes(int farmaciaId)
        {
            InitializeComponent();
            FarmaciaID = farmaciaId;
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private DataTable GetClientesList()
        {

            DataTable dtClientes = new DataTable();



            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT cliente_id, cliente_nome, cliente_telefone, cliente_rg FROM TB_CLIENTE where cliente_farmacia = '" + FarmaciaID + "' ", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                dtClientes.Load(reader);
            }
            catch (Exception)
            {
                this.Alert("Erro ao carregar tabela!", Form_Alert.enmType.Error);
                this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
            }
            connection.Close();
            return dtClientes;

        }
        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            try { 
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String VerificarClientesExisteQuery = "SELECT * FROM TB_CLIENTE WHERE cliente_farmacia = '" + FarmaciaID + "' ";
            SqlCommand commandVerificarClienteExiste = new SqlCommand(VerificarClientesExisteQuery, connection);
            connection.Open();
            SqlDataReader reader = commandVerificarClienteExiste.ExecuteReader();
             


            if (!reader.HasRows)
            {
                this.Alert("Não há clientes cadastrados", Form_Alert.enmType.Warning);
            }
            else
            {
                ClientesTable.DataSource = GetClientesList();
            }
            connection.Close();
            } catch (Exception)
            {
                this.Alert("Erro ao inicializar", Form_Alert.enmType.Error);
            }
        }

        private void BotaoConsultar_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String VerificarClienteExisteQuery = "SELECT * FROM TB_CLIENTE WHERE cliente_id = '" + InserirCliente.Text + "' ";
            SqlCommand commandVerificarClienteExiste = new SqlCommand(VerificarClienteExisteQuery, connection);
            connection.Open();
            SqlDataReader reader = commandVerificarClienteExiste.ExecuteReader();

            if (!reader.HasRows)
            {
                this.Alert("Cliente não encontrado", Form_Alert.enmType.Error);
            }
            else
            {
                connection.Close();
                try
                {
                    EditarCliente editarCliente = new EditarCliente(int.Parse(InserirCliente.Text), FarmaciaID);
                    editarCliente.ShowDialog();
                    this.Hide();
                    this.Close();
                }
                catch
                {
                    this.Alert("Erro ao selecionar!", Form_Alert.enmType.Error);
                    this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
                }

            }
        }

        private void BotaoSelecionar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String VerificarClienteExisteQuery = "SELECT * FROM TB_CLIENTE WHERE cliente_id = '" + InserirCliente.Text + "' ";
            SqlCommand commandVerificarClienteExiste = new SqlCommand(VerificarClienteExisteQuery, connection);
            connection.Open();
            SqlDataReader reader = commandVerificarClienteExiste.ExecuteReader();

            if (!reader.HasRows)
            {
                this.Alert("Cliente não encontrado", Form_Alert.enmType.Error);
            }
            else
            {
                connection.Close();
                try
                {
                    int client = int.Parse(InserirCliente.Text);
                    EditarCliente editar = new EditarCliente(client, FarmaciaID);
                    editar.ShowDialog();
                }
                catch
                {
                    this.Alert("Erro ao selecionar!", Form_Alert.enmType.Error);
                    this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
                }

            }


        }
    }
    }

