using BibliotecaDeClasses1;
using ProjetoGestaoFarmacia.DAL;
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
    public partial class CadastrarCliente : Form
    {
        public int FarmaciaID;
        public CadastrarCliente(int farmaciaId)
        {
            InitializeComponent();
            FarmaciaID = farmaciaId;
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
        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            string Genero = "";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            // Verificar RG existente
            String check = "select count(*) from [TB_CLIENTE] where cliente_rg = '" + InserirRG.Text + "' ";
            SqlCommand command = new SqlCommand(check, connection);
            int aux = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();

            if (Masculino.Checked && Feminino.Checked)
            {
                this.Alert("Escolha apenas um genêro!", Form_Alert.enmType.Error);
            } else if (!Masculino.Checked && !Feminino.Checked)
            {
                this.Alert("Escolha um genêro!", Form_Alert.enmType.Error);
            }
            else if (Masculino.Checked)
            {
                Genero = "Masculino";
            }
            else if (Feminino.Checked)
            {
                Genero = "Feminino";
            }

            if (InserirUsuario.Text == ""  || InserirRG.Text == "" || InserirTelefone.Text == "" || InserirEndereco.Text == "")
            {
                this.Alert("Existe campos vazios!", Form_Alert.enmType.Error);
            }

            else if (!Regex.Match(InserirUsuario.Text, "^[A-Za-z]+(([,.] |[ '-])[A-Za-z]+)*([.,'-]?)$").Success)
            {
                this.Alert("Deve inserir nome e sobrenome!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success && InserirEmail.Text != "")
            {
                this.Alert("Deve inserir um email válido!", Form_Alert.enmType.Error);
            }
            else if (aux == 1)
            {
                this.Alert("RG já cadastrado!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirTelefone.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                this.Alert("Insira um telefone válido!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirRG.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                this.Alert("Insira um RG válido!", Form_Alert.enmType.Error);
            }
            else
            {
                try { 
                Cliente cliente = new Cliente(InserirUsuario.Text, InserirTelefone.Text, InserirEndereco.Text, InserirRG.Text, Genero, InserirEmail.Text, FarmaciaID);
                ClienteDAL clienteDAL = new ClienteDAL(connection);
                clienteDAL.Inserir(cliente);
                this.Alert("Cliente adicionado!", Form_Alert.enmType.Success);
                connection.Close();
                this.Close();
                 } catch (Exception) {  
                 this.Alert("Erro no cadastro!", Form_Alert.enmType.Error);
                  this.Alert("Exceção Gerada!", Form_Alert.enmType.Error);
                     } 
                this.Close();
            } 
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
