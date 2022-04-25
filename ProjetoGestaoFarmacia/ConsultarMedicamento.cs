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
        public ConsultarMedicamento()
        {
            InitializeComponent();
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         String connectionString = @"Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" ;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM TB_MEDICAMENTO",sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                TabelaMedicamentos.DataSource = dtbl;
            }
        }
    }
}
