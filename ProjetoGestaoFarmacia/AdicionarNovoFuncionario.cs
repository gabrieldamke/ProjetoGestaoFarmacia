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
    public partial class AdicionarNovoFuncionario : Form
    {
        public int OperadorID;
        public int FarmaciaID;
        public AdicionarNovoFuncionario(int farmaceuticoID)
        {
            InitializeComponent();
            OperadorID = farmaceuticoID;
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            String ObterIdFarmaciaQuery = "SELECT farmaceutico_farmacia FROM TB_FARMACEUTICO WHERE farmaceutico_id = '" + OperadorID + "' ";
            SqlCommand commandRequestIdFarmacia = new SqlCommand(ObterIdFarmaciaQuery, connection);
            int IdFarmacia = (int)commandRequestIdFarmacia.ExecuteScalar();
            connection.Close();
            FarmaciaID = IdFarmacia;

        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable GetFarmaciasList()
        {

            DataTable dtFarmaceuticos = new DataTable();



            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT farmaceutico_id, farmaceutico_nome, farmaceutico_email, farmaceutico_farmacia FROM TB_FARMACEUTICO", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            dtFarmaceuticos.Load(reader);


            return dtFarmaceuticos;

        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String VerificarFarmaceuticoExisteQuery = "SELECT * FROM TB_FARMACEUTICO WHERE farmaceutico_id = '" + InserirIdFarmaceutico.Text + "' ";
            SqlCommand commandVerificarFarmaciaExiste = new SqlCommand(VerificarFarmaceuticoExisteQuery, connection);
            connection.Open();
            SqlDataReader reader = commandVerificarFarmaciaExiste.ExecuteReader();


            if (!reader.HasRows)
            {
                this.Alert("ID não encontrado", Form_Alert.enmType.Error);
            }
            else
            {
                connection.Close();
                connection.Open();
                String InsertNovoFuncionarioQuery = "UPDATE TB_FARMACEUTICO SET farmaceutico_farmacia = '" + FarmaciaID + "' WHERE farmaceutico_id = '" + InserirIdFarmaceutico.Text + "' ";
                SqlCommand insCmd = new SqlCommand(InsertNovoFuncionarioQuery, connection);
                insCmd.ExecuteNonQuery();
                connection.Close();
                this.Alert("Funcionário adicionado!", Form_Alert.enmType.Success);
                this.Close();
            }
            GerenciarFuncionarios gerenciarFuncionarios = new GerenciarFuncionarios(OperadorID);
            gerenciarFuncionarios.ShowDialog();
            this.Close();
        }

        private void AdicionarNovoFuncionario_Load(object sender, EventArgs e)
        {
            FuncionariosTable.DataSource = GetFarmaciasList();
        }

        private void FuncionariosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
