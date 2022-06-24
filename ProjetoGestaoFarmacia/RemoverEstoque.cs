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
    public partial class RemoverEstoque : Form
    {
        public int MedicamentoID;
        public int FarmaciaID;
        public RemoverEstoque(int MedicamentoId, int FarmaciaId)
        {
            InitializeComponent();
            this.MedicamentoID = MedicamentoId;
            this.FarmaciaID = FarmaciaId;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            int quantidade;
            bool isNumber = int.TryParse(InserirQuantidade.Text, out quantidade);
            if (isNumber)
            {
                try
                {
                    String ObterQuantidadeDeRemediosQuery = "SELECT medicamento_quantidade FROM TB_MEDICAMENTO WHERE medicamento_id = '" + MedicamentoID + "' and" + " medicamento_farmacia = '" + FarmaciaID + "' ";
                    SqlCommand commandRequestQuantidadeRemedio = new SqlCommand(ObterQuantidadeDeRemediosQuery, connection);
                    int QuantidadeFinal = (int)commandRequestQuantidadeRemedio.ExecuteScalar();
                    QuantidadeFinal = QuantidadeFinal - quantidade;
                    if (QuantidadeFinal <0 || quantidade <= 0)
                    {
                        this.Alert("Quantidade inválida!", Form_Alert.enmType.Error);
                    } else { 
                    String UpdateQuantidadeQuery = "UPDATE TB_MEDICAMENTO SET medicamento_quantidade = '" + QuantidadeFinal + "' WHERE medicamento_id = '" + MedicamentoID + "' and" + " medicamento_farmacia = '" + FarmaciaID + "' ";
                    SqlCommand insCmd = new SqlCommand(UpdateQuantidadeQuery, connection);
                    insCmd.ExecuteNonQuery();
                    this.Alert("Quantidade removida!", Form_Alert.enmType.Success);
                    }
                }
                catch (Exception)
                {
                    this.Alert("Erro ao adicionar!", Form_Alert.enmType.Error);
                    this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Insira um valor válido!", Form_Alert.enmType.Error);
            }
        }

        private void RemoverEstoque_Load(object sender, EventArgs e)
        {

        }
    }
}
