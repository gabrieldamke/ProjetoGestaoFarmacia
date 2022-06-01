using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGestaoFarmacia
{
    public partial class EscolherFarmaciaCadastro : Form
    {
        public EscolherFarmaciaCadastro()
        {
            InitializeComponent();

        }

        private void InserirRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void EscolherFarmaciaCadastro_Load(object sender, EventArgs e)
        {
            FarmaciasTable.DataSource = GetFarmaciasList();

        }
        private DataTable GetFarmaciasList()
        {

            DataTable dtFarmacias = new DataTable();



            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT farmacia_id, farmacia_nome, farmacia_cnpj FROM TB_FARMACIA", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            dtFarmacias.Load(reader);


            return dtFarmacias;

        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String VerificarFarmaciaExisteQuery = "SELECT * FROM TB_FARMACIA WHERE farmacia_id = '" + InserirIdFarmacia.Text + "' ";
            SqlCommand commandVerificarFarmaciaExiste = new SqlCommand(VerificarFarmaciaExisteQuery, connection);
            connection.Open();
            SqlDataReader reader = commandVerificarFarmaciaExiste.ExecuteReader();
            
            
            if (!reader.HasRows)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "O código da farmácia informada não é válido";
            }
            else
            {
                connection.Close();
                connection.Open();
                StatusLabel.Visible = false;
                String ObterIdFarmaceuticoQuery = "SELECT * FROM TB_FARMACEUTICO WHERE farmaceutico_id = (SELECT MAX(farmaceutico_id) FROM TB_FARMACEUTICO)";
                SqlCommand commandRequestIdFarmaceutico = new SqlCommand(ObterIdFarmaceuticoQuery, connection);
                int IdNovoFarmaceutico = (int)commandRequestIdFarmaceutico.ExecuteScalar();
                String InsertIdFarmaciaQuery = "UPDATE TB_FARMACEUTICO SET farmaceutico_farmacia = '" + InserirIdFarmacia.Text + "' WHERE farmaceutico_id = '" + IdNovoFarmaceutico + "' ";
                SqlCommand insCmd = new SqlCommand(InsertIdFarmaciaQuery, connection);
                insCmd.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            
        }
    }
}
