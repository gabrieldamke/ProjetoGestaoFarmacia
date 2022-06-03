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
    public partial class AdicionarEstoque : Form
    {
        public int MedicamentoID;
        public int FarmaciaID;
        public AdicionarEstoque(int MedicamentoId, int FarmaciaId)
        {
            InitializeComponent();
            this.MedicamentoID = MedicamentoId;
            this.FarmaciaID = FarmaciaId;

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void AdicionarEstoque_Load(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            String checkMedicamentoExisteEstoque = "select count(*) from [TB_MEDICAMENTO] where medicamento_id = '" + MedicamentoID + "' ";
            SqlCommand command = new SqlCommand(checkMedicamentoExisteEstoque, connection);
            connection.Open();
            int aux = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            if (aux == 1)
            {

            }
            
        }
    }
}
