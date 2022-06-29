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
    public partial class DadosFinanceiros : Form
    {
        public int FarmaciaID;
        public DadosFinanceiros(int farmaciaId)
        {
            InitializeComponent();
            FarmaciaID = farmaciaId;
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void DadosFinanceiros_Load(object sender, EventArgs e)
        {
           /* try { */ 
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            String ObterNomeFarmaciaQuery = "select farmacia_nome from [TB_FARMACIA] where farmacia_id = '" + FarmaciaID + "' ";
            SqlCommand cmdGetNomeFarmacia = new SqlCommand(ObterNomeFarmaciaQuery, connection);
            lblFarmacia.Text = (string)cmdGetNomeFarmacia.ExecuteScalar();
            String ObterLblItensEstoque = "select SUM(medicamento_quantidade) from [TB_MEDICAMENTO] where medicamento_farmacia = '" + FarmaciaID + "' ";
            SqlCommand cmdGetSomaItensEstoque = new SqlCommand(ObterLblItensEstoque, connection);
            int ItensEstoque = (int)cmdGetSomaItensEstoque.ExecuteScalar();
            LblItensEstoque.Text = ItensEstoque.ToString();
            String LblTotalVendasQuery = "select COUNT(*) from [TB_VENDA] where venda_farmacia = '" + FarmaciaID + "' ";
            SqlCommand cmdGetCount = new SqlCommand(LblTotalVendasQuery, connection);
            int TotalVendas = (int)cmdGetCount.ExecuteScalar();
            LblTotalVendas.Text = TotalVendas.ToString();
            String SumTotalValorVendas = "select SUM(venda_valor) from [TB_VENDA] where venda_farmacia = '" + FarmaciaID + "' ";
            SqlCommand cmdGetSumValor = new SqlCommand(SumTotalValorVendas, connection);
            decimal valorSomas = (decimal)cmdGetSumValor.ExecuteScalar();
            decimal totalVendasDeciamal = Convert.ToDecimal(TotalVendas);
            LblMediaCliente.Text = (valorSomas / totalVendasDeciamal).ToString();
                connection.Close();
           /* } catch(Exception)
            {
                this.Alert("Erro ao carregar!", Form_Alert.enmType.Error);
            } */


        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
