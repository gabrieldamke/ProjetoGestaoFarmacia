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
    public partial class ConsultarEstoque : Form
    {
        int FarmaciaID;
        public ConsultarEstoque(int farmaciaID)
        {
            InitializeComponent();
            FarmaciaID = farmaciaID;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                String VerificarRemedioExisteQuery2 = "SELECT * FROM TB_MEDICAMENTO WHERE medicamento_nome = '" + InserirMedicamento.Text + "' and" + " medicamento_farmacia = '" + FarmaciaID + "' ";
                SqlCommand commandVerificarRemedioExiste2 = new SqlCommand(VerificarRemedioExisteQuery2, connection);
                connection.Open();
                SqlDataReader reader2 = commandVerificarRemedioExiste2.ExecuteReader();


                if (!reader2.HasRows)
                {
                    this.Alert("Remédio Inexistente", Form_Alert.enmType.Error);
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    String ObterIdRemedioQuery = "SELECT medicamento_id FROM TB_MEDICAMENTO WHERE medicamento_nome = '" + InserirMedicamento.Text + "' and" + " medicamento_farmacia = '" + FarmaciaID + "' ";
                    SqlCommand commandRequestIdRemedio = new SqlCommand(ObterIdRemedioQuery, connection);
                    int IDRemedio = (int)commandRequestIdRemedio.ExecuteScalar();
                    connection.Close();
                    AdicionarEstoque adicionarEstoque = new AdicionarEstoque(IDRemedio, FarmaciaID);
                    adicionarEstoque.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                this.Alert("Erro ao selecionar!", Form_Alert.enmType.Error);
                this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
            }

        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private DataTable GetMedicamentoEspecificoList()
        {

            DataTable dtMedicamentos = new DataTable();



            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT medicamento_id, medicamento_nome, medicamento_quantidade FROM TB_MEDICAMENTO where medicamento_farmacia = '" + FarmaciaID + "' ", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                dtMedicamentos.Load(reader);
            }
            catch (Exception)
            {
                this.Alert("Erro ao carregar tabela!", Form_Alert.enmType.Error);
                this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
            }
            connection.Close();
            return dtMedicamentos;

        }
        private void ConsultarEstoque_Load(object sender, EventArgs e)
        {

            String VerificarRemedioExisteQuery = "SELECT medicamento_nome, medicamento_quantidade FROM TB_MEDICAMENTO WHERE medicamento_farmacia = '" + FarmaciaID + "' ";
            SqlCommand commandVerificarRemedioExiste = new SqlCommand(VerificarRemedioExisteQuery, connection);
            connection.Open();
            SqlDataReader reader = commandVerificarRemedioExiste.ExecuteReader();


            if (!reader.HasRows)
            {
                this.Alert("Não há remédios cadastrados", Form_Alert.enmType.Warning);
            }
            else
            {
                MedicamentosTable.DataSource = GetMedicamentoEspecificoList();
            }
            connection.Close();
        }

        private void BotaoSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                String VerificarRemedioExisteQuery2 = "SELECT * FROM TB_MEDICAMENTO WHERE medicamento_nome = '" + InserirMedicamento.Text + "' and" + " medicamento_farmacia = '" + FarmaciaID + "' ";
                SqlCommand commandVerificarRemedioExiste2 = new SqlCommand(VerificarRemedioExisteQuery2, connection);
                connection.Open();
                SqlDataReader reader2 = commandVerificarRemedioExiste2.ExecuteReader();


                if (!reader2.HasRows)
                {
                    this.Alert("Remédio Inexistente", Form_Alert.enmType.Error);
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    String ObterIdRemedioQuery = "SELECT medicamento_id FROM TB_MEDICAMENTO WHERE medicamento_nome = '" + InserirMedicamento.Text + "' and" + " medicamento_farmacia = '" + FarmaciaID + "' ";
                    SqlCommand commandRequestIdRemedio = new SqlCommand(ObterIdRemedioQuery, connection);
                    int IDRemedio = (int)commandRequestIdRemedio.ExecuteScalar();
                    connection.Close();
                    RemoverEstoque remover = new RemoverEstoque(IDRemedio, FarmaciaID);
                    remover.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                this.Alert("Erro ao selecionar!", Form_Alert.enmType.Error);
                this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
            }
        }
    }
}
