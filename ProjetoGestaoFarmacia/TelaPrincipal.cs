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
    public partial class TelaPrincipal : Form
    {
        int IDFarmacia;
        int UserID;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public TelaPrincipal(int id)
        {

           
            InitializeComponent();
            UserID = id;
            connection.Open();
            String ObterNomeQuery = "select farmaceutico_nome from [TB_FARMACEUTICO] where farmaceutico_id = '" +UserID + "' ";
            SqlCommand command = new SqlCommand(ObterNomeQuery, connection);
            string NomeUsuarioLogado = (string)command.ExecuteScalar();
            String ObterIdFarmaciaQuery = "SELECT farmaceutico_farmacia FROM TB_FARMACEUTICO WHERE farmaceutico_id = '" + UserID + "' ";
            SqlCommand commandRequestId = new SqlCommand(ObterIdFarmaciaQuery, connection);
            int IdFarmacia = (int)commandRequestId.ExecuteScalar();
            IDFarmacia = IdFarmacia;
            connection.Close();
            NomeDoUsuario.Text = NomeUsuarioLogado;
            ImprimirDadosFarmacia();
        }

        public void ImprimirDadosFarmacia ()
        {
            connection.Open();
            String ObterFarmaciaQuery = "select farmaceutico_farmacia from [TB_FARMACEUTICO] where farmaceutico_id = '" + UserID + "' ";
            SqlCommand command = new SqlCommand(ObterFarmaciaQuery, connection);
            int FarmaciaId = (int)command.ExecuteScalar();
            // Definir nome
            String ObterNomeFarmaciaQuery = "select farmacia_nome from [TB_FARMACIA] where farmacia_id = '" + FarmaciaId + "' ";
            SqlCommand cmdGetNomeFarmacia = new SqlCommand(ObterNomeFarmaciaQuery, connection);
            FarmaciaNome.Text = (string)cmdGetNomeFarmacia.ExecuteScalar();
            // Definir CNPJ
            String ObterCNPJFarmaciaQuery = "select farmacia_cnpj from [TB_FARMACIA] where farmacia_id = '" + FarmaciaId + "' ";
            SqlCommand cmdGetCNPJFarmacia = new SqlCommand(ObterCNPJFarmaciaQuery, connection);
            FarmaciaCNPJ.Text = (string)cmdGetCNPJFarmacia.ExecuteScalar();
            // Definir Endereço
            String ObterEnderecoFarmaciaQuery = "select farmacia_endereco from [TB_FARMACIA] where farmacia_id = '" + FarmaciaId + "' ";
            SqlCommand cmdGetEnderecoFarmacia = new SqlCommand(ObterEnderecoFarmaciaQuery, connection);
            FarmaciaEndereco.Text = (string)cmdGetEnderecoFarmacia.ExecuteScalar();

            String ObterTelefoneFarmaciaQuery = "select farmacia_telefone from [TB_FARMACIA] where farmacia_id = '" + FarmaciaId + "' ";
            SqlCommand cmdGetTelefoneFarmacia = new SqlCommand(ObterTelefoneFarmaciaQuery, connection);
            FarmaciaTelefone.Text = (string)cmdGetTelefoneFarmacia.ExecuteScalar();
            connection.Close();
        }
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarMedicamento Consulta = new ConsultarMedicamento(IDFarmacia);
            Hide();
            Consulta.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NomeDoUsuario_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            RealizarVenda realizarVenda = new RealizarVenda(UserID, IDFarmacia);
            realizarVenda.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo(UserID);
            administrativo.ShowDialog();
            
        }

        private void DtAtual_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarMedicamentos_Click(object sender, EventArgs e)
        {
            Medicamentos medicamentos = new Medicamentos(IDFarmacia);
            medicamentos.ShowDialog();
        }

        private void VerificarReceitas_Click(object sender, EventArgs e)
        {
            ConsultarEstoque consultarEstoque = new ConsultarEstoque(IDFarmacia);
            consultarEstoque.ShowDialog();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(IDFarmacia);
            clientes.ShowDialog();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            ImprimirDadosFarmacia();
            } catch (Exception)
            {
                this.Alert("Erro ao Atualizar dados!", Form_Alert.enmType.Error);
            }
        }
    }
}
