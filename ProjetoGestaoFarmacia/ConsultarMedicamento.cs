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
    public partial class ConsultarMedicamento : Form
    {
        public int FarmaciaID;
        public ConsultarMedicamento(int FarmaciaId)
        {
            InitializeComponent();
            FarmaciaID = FarmaciaId;
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            if (InserirMedicamento.Text == "")
            {
                MedicamentosTable.DataSource = GetAllMedicamentosList();
            }
            else
            {
                MedicamentosTable.DataSource = GetMedicamentoEspecificoList();
            }
        }

        private void BotaoFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable GetAllMedicamentosList()
        {

            DataTable dtMedicamentos = new DataTable();



            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT medicamento_id, medicamento_nome, medicamento_valor, medicamento_descricao FROM TB_MEDICAMENTO where medicamento_farmacia  = '" + FarmaciaID + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            dtMedicamentos.Load(reader);


            return dtMedicamentos;

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
            SqlCommand cmd = new SqlCommand("SELECT medicamento_id, medicamento_nome, medicamento_valor, medicamento_descricao FROM TB_MEDICAMENTO where medicamento_nome = '" + InserirMedicamento.Text + "' and" + " medicamento_farmacia = '" + FarmaciaID + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            dtMedicamentos.Load(reader);


            return dtMedicamentos;

        }
        private void TabelaMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarMedicamento_Load(object sender, EventArgs e)
        {
            MedicamentosTable.DataSource = GetAllMedicamentosList();
        }

        private void BotaoSelecionar_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String VerificarRemedioExisteQuery = "SELECT * FROM TB_MEDICAMENTO WHERE medicamento_nome = '" + InserirMedicamento.Text + "' ";
            SqlCommand commandVerificarRemedioExiste = new SqlCommand(VerificarRemedioExisteQuery, connection);
            connection.Open();
            SqlDataReader reader = commandVerificarRemedioExiste.ExecuteReader();


            if (!reader.HasRows)
            {
                this.Alert("Remédio não encontrado", Form_Alert.enmType.Error);
            }
            else
            {
                connection.Close();
                try
                {
                    connection.Open();
                    String ObterIdRemedioQuery = "SELECT medicamento_id FROM TB_MEDICAMENTO WHERE medicamento_nome = '" + InserirMedicamento.Text + "' and" + " medicamento_farmacia = '" + FarmaciaID + "' ";
                    SqlCommand commandRequestIdRemedio = new SqlCommand(ObterIdRemedioQuery, connection);
                    int IDRemedio = (int)commandRequestIdRemedio.ExecuteScalar();
                    DetalhesMedicamento detalhesMedicamento = new DetalhesMedicamento(IDRemedio, FarmaciaID);
                    detalhesMedicamento.ShowDialog();
                    connection.Close();
                    this.Close();
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
