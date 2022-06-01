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
    public partial class EditarFuncionarioTabela : Form
    {
        public int OperadorID;
        public int FarmaciaID;
        public EditarFuncionarioTabela(int FarmaceuticoId)
        {
            InitializeComponent();
            OperadorID = FarmaceuticoId;
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            String ObterIdFarmaciaQuery = "SELECT farmaceutico_farmacia FROM TB_FARMACEUTICO WHERE farmaceutico_id = '" + OperadorID + "' ";
            SqlCommand commandRequestIdFarmacia = new SqlCommand(ObterIdFarmaciaQuery, connection);
            int IdFarmacia = (int)commandRequestIdFarmacia.ExecuteScalar();
            connection.Close();
            FarmaciaID = IdFarmacia;
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarFuncionarioTabela_Load(object sender, EventArgs e)
        {
            FuncionariosTable.DataSource = GetFarmaceuticosList();
        }
        private DataTable GetFarmaceuticosList()
        {

            DataTable dtFarmaceuticos = new DataTable();



            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT farmaceutico_id, farmaceutico_nome, farmaceutico_email, farmaceutico_farmacia FROM TB_FARMACEUTICO WHERE farmaceutico_farmacia = '" + FarmaciaID + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            dtFarmaceuticos.Load(reader);


            return dtFarmaceuticos;

        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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
                EditarFuncionario editarFuncionario = new EditarFuncionario(Convert.ToInt32(InserirIdFarmaceutico.Text)) ;
                editarFuncionario.ShowDialog();
            }

        }
    }
}
