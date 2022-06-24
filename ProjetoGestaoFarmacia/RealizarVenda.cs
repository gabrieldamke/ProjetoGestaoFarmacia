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
    public partial class RealizarVenda : Form
    {
        public int FarmaceuticoID;
        public int FarmaciaID;
        public string NomeUsuarioLogado = "";
        public RealizarVenda(int farmaceuticoId, int farmaciaId)
        {
            InitializeComponent();
            FarmaceuticoID = farmaceuticoId;
            FarmaciaID = farmaciaId;

        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        void NovaVenda()
        {
            String CriarNovaVendaQuery = "INSERT INTO TB_VENDA (venda_farmacia, venda_farmaceutico) VALUES('" + FarmaciaID + "', '" + FarmaceuticoID + "')";
            SqlCommand CreateNewVenda = new SqlCommand(CriarNovaVendaQuery, connection);
            String CriarNovaVenda = (string)CreateNewVenda.ExecuteScalar();
            String ObterIdVendaAtual = "SELECT SCOPE_IDENTITY() from TB_VENDA ";
            SqlCommand ObterIdVenda = new SqlCommand(ObterIdVendaAtual, connection);
            decimal NovoID = (decimal)ObterIdVenda.ExecuteScalar();
            VendaIDLbl.Text = NovoID.ToString();
        }

        void NovoItemVenda ()
        {
            String ObterIdVendaAtual = "SELECT SCOPE_IDENTITY() from TB_VENDA ";
            SqlCommand ObterIdVenda = new SqlCommand(ObterIdVendaAtual, connection);
            decimal NovoID = (decimal)ObterIdVenda.ExecuteScalar();
            String CriarNovoItemVendaQuery = "INSERT INTO TB_ITEMVENDA (itemvenda_venda, itemvenda_medicamento, itemvenda_quantidade) VALUES('" + NovoID + "', '" + InsertIdMedicamento + "', '" + InserirQtd + "' )";
            SqlCommand CreateNewItemVenda = new SqlCommand(CriarNovoItemVendaQuery, connection);
            String CriarNovoITemVenda = (string)CreateNewItemVenda.ExecuteScalar();


        }
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(FarmaceuticoID);
            telaPrincipal.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void RealizarVenda_Load(object sender, EventArgs e)
        {
           
            connection.Open();
            NovaVenda();
            String ObterNomeQuery = "select farmaceutico_nome from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoID + "' ";
            SqlCommand command = new SqlCommand(ObterNomeQuery, connection);
            NomeUsuarioLogado = (string)command.ExecuteScalar();
            NomeDoUsuario.Text = NomeUsuarioLogado;
            NomeOperador.Text = NomeUsuarioLogado;
            String ObterNomeFarmaciaQuery = "select farmacia_nome from [TB_FARMACIA] where farmacia_id = '" + FarmaciaID + "' ";
            SqlCommand cmdGetFarmaciaName = new SqlCommand(ObterNomeFarmaciaQuery, connection);
            NomeEmpresa.Text = (string)cmdGetFarmaciaName.ExecuteScalar();
            LblVendID.Text = Convert.ToString(FarmaceuticoID);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarMedicamento consultarMedicamento = new ConsultarMedicamento(FarmaciaID);
            consultarMedicamento.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarEstoque consultarEstoque = new ConsultarEstoque(FarmaciaID);
            consultarEstoque.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarClientes consultarClientes = new ConsultarClientes(FarmaciaID);
            consultarClientes.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
