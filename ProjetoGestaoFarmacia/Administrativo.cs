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
    public partial class Administrativo : Form
    {
        int FarmaceuticoID ;
        int FarmaciaID;
        public Administrativo(int FarmaceuticoId)
        {
            InitializeComponent();
            FarmaceuticoID = FarmaceuticoId;
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            String ObterIdFarmaciaQuery = "SELECT farmaceutico_farmacia FROM TB_FARMACEUTICO WHERE farmaceutico_id = '" + FarmaceuticoID + "' ";
            SqlCommand commandRequestId = new SqlCommand(ObterIdFarmaciaQuery, connection);
            int IdFarmacia = (int)commandRequestId.ExecuteScalar();
            connection.Close(); 
            FarmaciaID = IdFarmacia;
        }

        private void Administrativo_Load(object sender, EventArgs e)
        {

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RealizarVenda_Click(object sender, EventArgs e)
        {
            GerenciarFuncionarios gerenciarFuncionarios = new GerenciarFuncionarios(FarmaceuticoID);
            gerenciarFuncionarios.ShowDialog();
            this.Close();
        }

        private void AlterarDados_Click(object sender, EventArgs e)
        {
            EditarDadosFarmacia editarDadosFarmacia = new EditarDadosFarmacia(FarmaciaID);
            editarDadosFarmacia.ShowDialog();
            this.Close();
        }
    }
}
