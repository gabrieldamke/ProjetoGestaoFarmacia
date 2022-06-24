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
    public partial class DetalhesMedicamento : Form
    {
        public readonly int MedicamentoID;
        public readonly int FarmaciaID;
        public DetalhesMedicamento(int medicamentoId, int FarmaciaId)
        {
            InitializeComponent();
            MedicamentoID = medicamentoId;
            FarmaciaID = FarmaciaId;
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void DetalhesMedicamento_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                
                connection.Open();
                string ObterNomeRemedioQuery = "SELECT medicamento_nome FROM TB_MEDICAMENTO WHERE medicamento_id = '" + MedicamentoID + "' ";
                SqlCommand commandRequestNomeRemedio = new SqlCommand(ObterNomeRemedioQuery, connection);
                string NomeRemedio = (string)commandRequestNomeRemedio.ExecuteScalar();
                NomeMedicamento.Text = NomeRemedio;
                string ObterDescricaoRemedioQuery = "SELECT medicamento_descricao FROM TB_MEDICAMENTO WHERE medicamento_id = '" + MedicamentoID + "' ";
                SqlCommand commandRequestDescricaoRemedio = new SqlCommand(ObterDescricaoRemedioQuery, connection);
                string DescricaoRemedio = (string)commandRequestDescricaoRemedio.ExecuteScalar();
                DescricaoMedicamento.Text = DescricaoRemedio;
                string ObterValorRemedioQuery = "SELECT medicamento_valor FROM TB_MEDICAMENTO WHERE medicamento_id = '" + MedicamentoID + "' ";
                SqlCommand commandRequestValorRemedio = new SqlCommand(ObterValorRemedioQuery, connection);
                double ValorRemedio = (double)commandRequestValorRemedio.ExecuteScalar();
                ValorMedicamento.Text = ValorRemedio.ToString();
                string ObterReceitaRemedioQuery = "SELECT medicamento_receitamedica FROM TB_MEDICAMENTO WHERE medicamento_id = '" + MedicamentoID + "' ";
                SqlCommand commandRequestReceitaRemedio = new SqlCommand(ObterReceitaRemedioQuery, connection);
                int ReceitaRemedio = (int)commandRequestReceitaRemedio.ExecuteScalar();
                if ( ReceitaRemedio == 1) {
                    PrecisaDeReceita.Checked = true;
                }

                connection.Close();
                               
            }
            catch
            {
                this.Alert("Erro ao selecionar!", Form_Alert.enmType.Error);
                this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
            } 
        }


        private void AdicionarEstoque_Click(object sender, EventArgs e)
        {
            AdicionarEstoque adicionarestoque = new AdicionarEstoque(MedicamentoID, FarmaciaID);
        }

        void RetornarDetalhesMedicamento ()
        {
         
        }
    }
}
