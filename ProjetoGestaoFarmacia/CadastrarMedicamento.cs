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
    public partial class CadastrarMedicamento : Form
    {
        public int FarmaciaID;
        public CadastrarMedicamento(int FarmaciaId)
        {
            InitializeComponent();
            FarmaciaID = FarmaciaId;

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarMedicamento_Load(object sender, EventArgs e)
        {
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            int receita = 0;
            if (PrecisaDeReceita.Checked)
            {
                receita = 1;
            }
            else if (!PrecisaDeReceita.Checked)
            {
                receita = 0;
            }
            if (InserirNome.Text == "" || InserirValor.Text == null || InserirDescricao.Text == "")
            {
                this.Alert("Existe campos vazios!", Form_Alert.enmType.Error);
            }
            else if (!Regex.Match(InserirValor.Text, "[+-]?([0-9]*[.])?[0-9]+").Success)
            {
                this.Alert("Insira um valor válido!", Form_Alert.enmType.Error);

            } else
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                Medicamento medicamento = new Medicamento(InserirNome.Text, receita, Convert.ToSingle(InserirValor.Text), InserirDescricao.Text);
                try { 
                connection.Open();
                String InserirRemedioQuery = "INSERT INTO TB_MEDICAMENTO(medicamento_nome, medicamento_receitamedica, medicamento_valor, medicamento_descricao) VALUES ('" + medicamento.nome + "', '" + medicamento.receitamedica + "', '" + medicamento.valor + "', '" + medicamento.descricao + "' )";
                SqlCommand commandInserirRemedio = new SqlCommand(InserirRemedioQuery, connection);
                commandInserirRemedio.ExecuteNonQuery();
                connection.Close();
                this.Alert("Medicamento adicionado!", Form_Alert.enmType.Success);
                }  catch (Exception ex)
                {
                    this.Alert("Exceção gerada", Form_Alert.enmType.Error);
                    this.Alert("ERRO na conexão!", Form_Alert.enmType.Error);
                } 

            }

                

        }
    }
}
