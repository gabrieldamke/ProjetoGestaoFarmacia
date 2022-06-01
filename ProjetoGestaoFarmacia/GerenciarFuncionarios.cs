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
    public partial class GerenciarFuncionarios : Form
    {
       public int FarmaceuticoID;
        public GerenciarFuncionarios(int FarmaceuticoId)
        {
            InitializeComponent();
            FarmaceuticoID = FarmaceuticoId;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GerenciarFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionariosTable.DataSource = GetFuncionariosList();
        }
        private DataTable GetFuncionariosList()
        {

            DataTable dtFarmacias = new DataTable();



            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            String GetFarmaciaQuery ="SELECT farmaceutico_farmacia from TB_FARMACEUTICO WHERE farmaceutico_id = '" + FarmaceuticoID + "' ";
            SqlCommand commandRequestIdFarmacia = new SqlCommand(GetFarmaciaQuery, connection);
            int IdFarmacia = (int)commandRequestIdFarmacia.ExecuteScalar();
            SqlCommand cmd = new SqlCommand("SELECT farmaceutico_id, farmaceutico_nome, farmaceutico_email FROM TB_FARMACEUTICO where farmaceutico_farmacia = '" + IdFarmacia + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            dtFarmacias.Load(reader);


            return dtFarmacias;

        }

        private void RealizarVenda_Click(object sender, EventArgs e)
        {
            AdicionarNovoFuncionario adicionarNovoFuncionario = new AdicionarNovoFuncionario(FarmaceuticoID);
            adicionarNovoFuncionario.ShowDialog();
            this.Close();
        }

        private void DemitirFuncionario_Click(object sender, EventArgs e)
        {
            DemitirFuncionario demitirFuncionario = new DemitirFuncionario(FarmaceuticoID);
            demitirFuncionario.ShowDialog();
            this.Close();
        }

        private void AlterarDadosFuncionario_Click(object sender, EventArgs e)
        {
            EditarFuncionarioTabela editarFuncionarioTabela = new EditarFuncionarioTabela(FarmaceuticoID);
            editarFuncionarioTabela.ShowDialog();
            this.Close();
        }
    }
}
