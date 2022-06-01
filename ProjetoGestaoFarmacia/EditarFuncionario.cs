using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGestaoFarmacia
{
    public partial class EditarFuncionario : Form
    {
        public int FuncionarioID;
        public EditarFuncionario(int FuncionarioId)
        {
            InitializeComponent();
            FuncionarioID = FuncionarioId;
            RetornarDadosFarmaceutico(FuncionarioID);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public void RetornarDadosFarmaceutico(int FarmaceuticoId)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            FarmaceuticoId = FuncionarioID;
            // Definir nome
            String ObterNomeFarmaceuticoQuery = "select farmaceutico_nome from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetNomeFarmaceutico = new SqlCommand(ObterNomeFarmaceuticoQuery, connection);
            InserirUsuario.Text = (string)cmdGetNomeFarmaceutico.ExecuteScalar();
            // Definir Telefone
            String ObterTelefoneFarmaceuticoQuery = "select farmaceutico_telefone from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetTelefoneFarmaceutico = new SqlCommand(ObterTelefoneFarmaceuticoQuery, connection);
            InserirTelefone.Text = (string)cmdGetTelefoneFarmaceutico.ExecuteScalar();
            // Definir Endereço
            String ObterEnderecoFarmaceuticoQuery = "select farmaceutico_endereco from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetEnderecoFarmaceutico = new SqlCommand(ObterEnderecoFarmaceuticoQuery, connection);
            InserirEndereco.Text = (string)cmdGetEnderecoFarmaceutico.ExecuteScalar();
            // Definir RG
            String ObterRGFarmaceuticoQuery = "select farmaceutico_rg from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetRGFarmaceutico = new SqlCommand(ObterRGFarmaceuticoQuery, connection);
            InserirRG.Text = (string)cmdGetRGFarmaceutico.ExecuteScalar();
            // definir Salario
            String ObterSalarioFarmaceuticoQuery = "select farmaceutico_salario from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetSalarioFarmaceutico = new SqlCommand(ObterSalarioFarmaceuticoQuery, connection);
            double salario = (double)cmdGetSalarioFarmaceutico.ExecuteScalar();
            if (salario > 0)
            {
                InserirSalario.Text = salario.ToString();
            }
            // Definir PIS
            String ObterPISFarmaceuticoQuery = "select farmaceutico_pis from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetPisFarmaceutico = new SqlCommand(ObterPISFarmaceuticoQuery, connection);
            String PIS = (string)cmdGetPisFarmaceutico.ExecuteScalar();
            if (PIS != "")
            {
                InserirPIS.Text = PIS;
            }
            // Definir Genero
            String ObterGeneroFarmaceuticoQuery = "select farmaceutico_genero from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetGeneroFarmaceutico = new SqlCommand(ObterPISFarmaceuticoQuery, connection);
           String Genero = (string)cmdGetGeneroFarmaceutico.ExecuteScalar();
            if (Genero == "Masculino")
            {
                Masculino.Checked = true;
            } else if (Genero == "Feminino")
            {
                Feminino.Checked = true;
            }
            // Definir CRF
            String ObterCRFFarmaceuticoQuery = "select farmaceutico_crf from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetCRFFarmaceutico = new SqlCommand(ObterCRFFarmaceuticoQuery, connection);
            String CRF = (string)cmdGetCRFFarmaceutico.ExecuteScalar();
            if (CRF != "")
            {
                InserirCRF.Text = CRF;
            }
            // Definir Email
            String ObterEmailFarmaceuticoQuery = "select farmaceutico_email from [TB_FARMACEUTICO] where farmaceutico_id = '" + FarmaceuticoId + "' ";
            SqlCommand cmdGetEmailFarmaceutico = new SqlCommand(ObterEmailFarmaceuticoQuery, connection);
            InserirEmail.Text = (string)cmdGetEmailFarmaceutico.ExecuteScalar();


            connection.Close();
        }
        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {

            string Genero = "";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            // Definir Email
            String ObterEmailFarmaceuticoQuery = "select farmaceutico_email from [TB_FARMACEUTICO] where farmaceutico_id = '" + FuncionarioID + "' ";
            SqlCommand cmdGetEmailFarmaceutico = new SqlCommand(ObterEmailFarmaceuticoQuery, connection);
            String EmailAtual = (string)cmdGetEmailFarmaceutico.ExecuteScalar();
            String check = "select count(*) from [TB_FARMACEUTICO] where farmaceutico_email = '" + InserirEmail.Text + "' ";
            SqlCommand command = new SqlCommand(check, connection);
            int aux = Convert.ToInt32(command.ExecuteScalar().ToString());


             if (Masculino.Checked && Feminino.Checked)
            {
                this.Alert("Escolha apenas um genêro!", Form_Alert.enmType.Error);
            }
            else if (Masculino.Checked)
            {
                Genero = "Masculino";
            }
            else if (Feminino.Checked)
            {
                Genero = "Feminino";
            }

            if (InserirUsuario.Text == "" || InserirEmail.Text == "" || InserirRG.Text == "" || InserirTelefone.Text == "" || InserirEndereco.Text == "")
            {
                this.Alert("Existe campos vazios!", Form_Alert.enmType.Error);
            }

            else if (!Regex.Match(InserirUsuario.Text, "^[A-Za-z]+(([,.] |[ '-])[A-Za-z]+)*([.,'-]?)$").Success)
            {
                this.Alert("Deve inserir nome e sobrenome!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                this.Alert("Deve inserir um email válido!", Form_Alert.enmType.Error);
            }
            else if (aux == 1 && InserirEmail.Text != EmailAtual)
            {
                this.Alert("Email já existente!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirTelefone.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                this.Alert("Insira um telefone válido!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirRG.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                this.Alert("Insira um RG válido!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirCRF.Text, "^[0-9]*$").Success)
            {
                this.Alert("Insira um CRF válido!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirRG.Text, "[+-]?([0-9]*[.])?[0-9]+").Success)
            {
                this.Alert("Insira um salário válido!", Form_Alert.enmType.Error);
            } else
            {
                String UpdateFuncionarioQuery = "UPDATE TB_FARMACEUTICO SET farmaceutico_nome = '" + InserirUsuario.Text + "', farmaceutico_telefone = '" + InserirTelefone.Text + "', farmaceutico_rg = '" + InserirRG.Text + "', farmaceutico_salario = '" + InserirSalario.Text + "', farmaceutico_dtNasc = '" + DataNasc.Value.ToString() + "', farmaceutico_pis = '" + InserirPIS.Text + "', farmaceutico_genero = '" + Genero + "', farmaceutico_crf = '" + InserirCRF.Text + "', farmaceutico_email = '" + InserirEmail.Text + "', farmaceutico_endereco = '" + InserirEndereco.Text + "' WHERE farmaceutico_id = '" + FuncionarioID + "' ";
                SqlCommand insCmd = new SqlCommand(UpdateFuncionarioQuery, connection);
                insCmd.ExecuteNonQuery();
                connection.Close();
                this.Alert("Dados alterados com sucesso!", Form_Alert.enmType.Success);
                this.Close();
            }

        }

        private void InserirTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
