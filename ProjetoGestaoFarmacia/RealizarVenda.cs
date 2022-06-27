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
            connection.Open();
            String CriarNovaVendaQuery = "INSERT INTO TB_VENDA (venda_farmacia, venda_farmaceutico) VALUES('" + FarmaciaID + "', '" + FarmaceuticoID + "')";
            SqlCommand CreateNewVenda = new SqlCommand(CriarNovaVendaQuery, connection);
            String CriarNovaVenda = (string)CreateNewVenda.ExecuteScalar();
            String ObterIdVendaAtual = "SELECT SCOPE_IDENTITY() from TB_VENDA ";
            SqlCommand ObterIdVenda = new SqlCommand(ObterIdVendaAtual, connection);
            decimal NovoID = (decimal)ObterIdVenda.ExecuteScalar();
            VendaIDLbl.Text = NovoID.ToString();
            connection.Close();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private DataTable GetMedicamentosVendaList()
        {

            DataTable dtItemVenda = new DataTable();
            int LblID = int.Parse(VendaIDLbl.Text);
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT itemvenda_id, itemvenda_medicamento, itemvenda_quantidade FROM TB_ITEMVENDA where itemvenda_venda = '" + LblID + "' ", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                dtItemVenda.Load(reader);

            }
            catch (Exception)
            {
                this.Alert("Erro ao atualizar tabela!", Form_Alert.enmType.Error);
                this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
            }
            connection.Close();

            return dtItemVenda;

        }


        void NovoItemVenda()
        {

            connection.Open();

            int InsertQTD = int.Parse(InserirQtd.Text);
            int InsertMED = int.Parse(InsertIdMedicamento.Text);
            int LblID = int.Parse(VendaIDLbl.Text);
            String VerificarMedNaListaQuery = "SELECT * FROM TB_ITEMVENDA WHERE itemvenda_medicamento = '" + InsertIdMedicamento.Text + "' and" + " itemvenda_venda = '" + LblID + "' ";
            SqlCommand commandVerificarRemedioExiste = new SqlCommand(VerificarMedNaListaQuery, connection);
            SqlDataReader reader = commandVerificarRemedioExiste.ExecuteReader();

            if (reader.HasRows)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    String ObterQuantidadeAtual = "select itemvenda_quantidade from [TB_ITEMVENDA] where itemvenda_medicamento = '" + InsertIdMedicamento.Text + "' and itemvenda_venda = '" + LblID + "' ";
                    SqlCommand cmdGetQuantidadeAtual = new SqlCommand(ObterQuantidadeAtual, connection);
                    int QuantidadeAtual = (int)cmdGetQuantidadeAtual.ExecuteScalar();
                    QuantidadeAtual = QuantidadeAtual + InsertQTD;
                    String UpdateQTDRemedio = "UPDATE TB_ITEMVENDA SET itemvenda_quantidade = '" + QuantidadeAtual + "' where itemvenda_venda = '" + LblID + "' ";
                    SqlCommand insCmd = new SqlCommand(UpdateQTDRemedio, connection);
                    insCmd.ExecuteNonQuery();
                    String ObterValorRemedio = "select medicamento_valor from [TB_MEDICAMENTO] where medicamento_id = '" + InsertIdMedicamento.Text + "' ";
                    SqlCommand cmdGetValorRemedio = new SqlCommand(ObterValorRemedio, connection);
                    decimal ValorMedicamento = (decimal)cmdGetValorRemedio.ExecuteScalar();
                    decimal NewMedicamento = Convert.ToDecimal(ValorMedicamento);
                    String ObterValorAtual = "select venda_valor from [TB_VENDA] where venda_id = '" + LblID + "' ";
                    SqlCommand cmdGetValorAtual = new SqlCommand(ObterValorAtual, connection);
                    decimal ValorAtual = (decimal)cmdGetValorAtual.ExecuteScalar();
                    decimal quantidade = Convert.ToDecimal(InsertQTD);
                    Math.Round(quantidade, 1);
                    ValorAtual = ValorAtual + (quantidade * NewMedicamento);
                    String UpdateVendaValor = "UPDATE TB_VENDA SET venda_valor = @venda_valor where venda_id = @venda_id";
                    SqlCommand cmdUpdateVendaValor = new SqlCommand(UpdateVendaValor, connection);
                    cmdUpdateVendaValor.Parameters.Add(new SqlParameter("@venda_valor", ValorAtual));
                    cmdUpdateVendaValor.Parameters.Add(new SqlParameter("@venda_id", LblID));
                    cmdUpdateVendaValor.ExecuteNonQuery();
                    ValorFinal.Text = ValorAtual.ToString();
                    this.Alert("Quantidade Atualizada!", Form_Alert.enmType.Info);
                    connection.Close();
                }
                catch (Exception)
                {
                    this.Alert("Erro ao atualizar qtd!", Form_Alert.enmType.Error);
                    this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
                    connection.Close();
                }
            }

            else if (InserirQtd != null && InsertQTD != 0)
            {
                try
                {

                    connection.Close();
                    connection.Open();
                    String CriarNovaItemVendaQuery = "INSERT INTO TB_ITEMVENDA (itemvenda_venda, itemvenda_medicamento, itemvenda_quantidade) VALUES('" + LblID + "', '" + InsertMED + "', '" + InsertQTD + "')";
                    SqlCommand CreateNewItemVenda = new SqlCommand(CriarNovaItemVendaQuery, connection);
                    String CriarNovaVenda = (string)CreateNewItemVenda.ExecuteScalar();
                    String ObterValorRemedio = "select medicamento_valor from [TB_MEDICAMENTO] where medicamento_id = '" + InsertIdMedicamento.Text + "' ";
                    SqlCommand cmdGetValorRemedio = new SqlCommand(ObterValorRemedio, connection);
                    decimal ValorMedicamento = (decimal)cmdGetValorRemedio.ExecuteScalar();
                    decimal NewMedicamento = Convert.ToDecimal(ValorMedicamento);
                    String ObterValorAtual = "select venda_valor from [TB_VENDA] where venda_id = '" + LblID + "' ";
                    SqlCommand cmdGetValorAtual = new SqlCommand(ObterValorAtual, connection);
                    decimal ValorAtual = (decimal)cmdGetValorAtual.ExecuteScalar();
                    decimal quantidade = Convert.ToDecimal(InsertQTD);
                    Math.Round(quantidade, 1);
                    ValorAtual = ValorAtual + (quantidade * NewMedicamento);
                    String UpdateVendaValor = "UPDATE TB_VENDA SET venda_valor = @venda_valor where venda_id = @venda_id";
                    SqlCommand cmdUpdateVendaValor = new SqlCommand(UpdateVendaValor, connection);
                    cmdUpdateVendaValor.Parameters.Add(new SqlParameter("@venda_valor", ValorAtual));
                    cmdUpdateVendaValor.Parameters.Add(new SqlParameter("@venda_id", LblID));
                    cmdUpdateVendaValor.ExecuteNonQuery();
                    ValorFinal.Text = ValorAtual.ToString();
                    this.Alert("Item adicionado!", Form_Alert.enmType.Success);
                    connection.Close();
                }
                catch (Exception)
                {
                    this.Alert("Erro ao add produto!", Form_Alert.enmType.Error);
                    this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
                    connection.Close();
                }
            }
            else
            {
                this.Alert("Quantidade inválida!", Form_Alert.enmType.Error);
            }

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

            NovaVenda();
            connection.Open();
            String ObterNomeQuery = "select farmaceutico_nome from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoID + "' ";
            SqlCommand command = new SqlCommand(ObterNomeQuery, connection);
            NomeUsuarioLogado = (string)command.ExecuteScalar();
            NomeDoUsuario.Text = NomeUsuarioLogado;
            NomeOperador.Text = NomeUsuarioLogado;
            String ObterNomeFarmaciaQuery = "select farmacia_nome from [TB_FARMACIA] where farmacia_id = '" + FarmaciaID + "' ";
            SqlCommand cmdGetFarmaciaName = new SqlCommand(ObterNomeFarmaciaQuery, connection);
            NomeEmpresa.Text = (string)cmdGetFarmaciaName.ExecuteScalar();
            LblVendID.Text = Convert.ToString(FarmaceuticoID);
            connection.Close();
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
            NovoItemVenda();
            TabelaProduto.DataSource = GetMedicamentosVendaList();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (InserirCliente.Text != "")
                {
                    String FinalizarVendaQuery = "UPDATE TB_VENDA SET venda_cliente = @venda_cliente, venda_finalizada = @venda_finalizada where venda_id = @venda_id";
                    SqlCommand cmdFinalizarVenda = new SqlCommand(FinalizarVendaQuery, connection);
                    int cliente = Int32.Parse(InserirCliente.Text);
                    int venda = int.Parse(LblVendID.Text);
                    cmdFinalizarVenda.Parameters.Add(new SqlParameter("@venda_cliente", cliente));
                    cmdFinalizarVenda.Parameters.Add(new SqlParameter("@venda_id", venda));
                    cmdFinalizarVenda.Parameters.Add(new SqlParameter("@venda_finalizada", venda));
                    cmdFinalizarVenda.ExecuteNonQuery();
                    this.Alert("Venda Concluída!", Form_Alert.enmType.Success);
                    connection.Close();
                    this.Close();
                } else
                {
                   
                    string vendafinalizada = "1";
                    String VendaFinalizadaQuery = "UPDATE TB_VENDA SET venda_finalizada = '" + vendafinalizada  + "' where venda_id = @venda_id";
                    SqlCommand cmdVendaFinalizada = new SqlCommand(VendaFinalizadaQuery, connection);
                    cmdVendaFinalizada.Parameters.Add(new SqlParameter("@venda_finalizada", vendafinalizada));
                    cmdVendaFinalizada.ExecuteNonQuery();
                    this.Alert("Venda Concluída!", Form_Alert.enmType.Success);
                    connection.Close();
                    this.Close();
                }
            }
            catch (Exception)
            {
                this.Alert("Erro ao Finalizar Venda!", Form_Alert.enmType.Error);
                this.Alert("Exceção gerada!", Form_Alert.enmType.Error);
            } 
            }
        }
    }
