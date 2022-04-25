using BibliotecaDeClasses1;
using ProjetoGestaoFarmacia.DAL;
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
    public partial class Registrar3 : Form
    {
        public string Nome = "";
        public string Senha = "";
        public string Email = "";
        public Registrar3()
        {
            InitializeComponent();
        }

        public Registrar3(string nome, string senha, string email) : this()
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        // "insert into TB_FARMACEUTICO(farmaceutico_nome, farmaceutico_email, farmaceutico_senha, farmaceutico_telefone, farmaceutico_endereco, farmaceutico_rg, farmaceutico_salario, farmaceutico_dtNasc, farmaceutico_pis, farmaceutico_genero, farmaceutico_crf)
        //Farmaceutico(int id, string nome, string email, string senha, string endereco, string rg, float salario, String dtNasc, string pis, string genero, string crf)
        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            string Genero = "";
                if (Masculino.Checked)
                {
                    Genero = "Masculino";
                }
                else if (Feminino.Checked)
                {
                    Genero = "Feminino";
                }
                else if (!Masculino.Checked && !Feminino.Checked)
                {
                    throw new Exception("Nenhum Genero foi selecionado");
                } else if (Masculino.Checked && Feminino.Checked)
            {
                throw new Exception("Ambos os generos foram selecionados");
            }
            
      
                

            string connectionString = ConfigurationManager.ConnectionStrings["IdealFarma"].ConnectionString;
            Farmaceutico farmaceutico = new Farmaceutico(Nome, Email, Senha, InserirEndereco.Text, InserirTelefone.Text, InserirRG.Text, 0, DataNasc.Value.ToString(), "", Genero, "");
            FarmaceuticoDAL dal = new FarmaceuticoDAL(new SqlConnection(connectionString));
            dal.Inserir1(farmaceutico);
        }

        private void InserirTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
