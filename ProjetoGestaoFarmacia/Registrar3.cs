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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGestaoFarmacia
{
    public partial class Registrar3 : Form
    {
        public string Nome = "";
        public string Senha = "";
        public string Email = "";
        public int aux = 0;
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

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            StatusLabel.Visible = false;
            string Genero = "";
            //valida gênero, define valor para enviar para DB
            if (Masculino.Checked && Feminino.Checked)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = ("Você não pode escolher dois gêneros");
            }
            else if (Masculino.Checked)
            {
                Genero = "Masculino";
            }
            else if (Feminino.Checked)
            {
                Genero = "Feminino";
            }
            else if (!Masculino.Checked && !Feminino.Checked)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = ("Por favor escolha o seu gênero");
            }
            if (InserirRG.Text == "" || InserirTelefone.Text == "" || InserirEndereco.Text == "")
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Existe campos vazios. Por favor preencha!";
            }
            else if (!Regex.Match(InserirTelefone.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Insira seu telefone no formato (xx) 9xxxx-xxxx";
            }
            else if (!Regex.Match(InserirRG.Text, "(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])").Success)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "RG Incorreto. Por Favor verifique.";
            }
            else if (!Masculino.Checked && !Feminino.Checked)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = ("Por favor escolha o seu gênero");
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["IdealFarma"].ConnectionString;
                Farmaceutico farmaceutico = new Farmaceutico(Nome, Email, Senha, InserirEndereco.Text, InserirTelefone.Text, InserirRG.Text, 0, DataNasc.Value.ToString(), "", Genero, "", 0);
                FarmaceuticoDAL dal = new FarmaceuticoDAL(new SqlConnection(connectionString));
                connection.Open();
                if (aux <= 0) { 
                dal.Inserir2(farmaceutico);
                    aux = aux + 1;
            }
            String ObterIdFarmaceuticoQuery = "SELECT * FROM TB_FARMACEUTICO WHERE farmaceutico_id = (SELECT MAX(farmaceutico_id) FROM TB_FARMACEUTICO)";
                SqlCommand commandRequestIdFarmaceutico = new SqlCommand(ObterIdFarmaceuticoQuery, connection);
                int IdNovoFarmaceutico = (int)commandRequestIdFarmaceutico.ExecuteScalar();
                connection.Close();
                if (CriarNovaFarmacia.Checked && SouFuncionario.Checked)
                {
                    StatusLabel.Visible = true;
                    StatusLabel.Text = "Você não pode ser funcionário e criar uma nova farmácia";
                }
                else if (!CriarNovaFarmacia.Checked && !SouFuncionario.Checked)
                {
                    StatusLabel.Visible = true;
                    StatusLabel.Text = "Você deve escolher se é funcionário ou deseja criar uma nova farmácia.";
                }
                else if (CriarNovaFarmacia.Checked)
                {
                    CadastrarFarmacia cadastrarFarmacia = new CadastrarFarmacia(Nome, Senha);
                    this.Hide();
                    cadastrarFarmacia.ShowDialog();
                }
                else if (SouFuncionario.Checked)
                {
                    EscolherFarmaciaCadastro escolherFarmaciaCadastro = new EscolherFarmaciaCadastro();
                    escolherFarmaciaCadastro.ShowDialog();

                    connection.Open();

                    /*   String ObterIdFarmaceuticoFarmaciaQuery = "SELECT farmaceutico_farmacia FROM TB_FARMACEUTICO WHERE farmaceutico_id = (SELECT MAX(farmaceutico_id) FROM TB_FARMACEUTICO)";
                    SqlCommand commandRequestIdFarmaceuticoFarmacia = new SqlCommand(ObterIdFarmaceuticoFarmaciaQuery, connection);
                    int IdNovoFarmaceuticoFarmacia = (int)commandRequestIdFarmaceuticoFarmacia.ExecuteScalar();

                        */

                    String VerificarFarmaciaEstaCadastradaQuery = "SELECT * FROM TB_FARMACEUTICO WHERE farmaceutico_id = '" + IdNovoFarmaceutico + "' and farmaceutico_farmacia = '" + 0 + "' ";
                    SqlCommand commandVerificarFarmaciaExiste = new SqlCommand(VerificarFarmaciaEstaCadastradaQuery, connection);

                    SqlDataReader reader = commandVerificarFarmaciaExiste.ExecuteReader();


                    if (reader.HasRows)
                    {
                        StatusLabel.Visible = true;
                        StatusLabel.Text = "Você deve escolher uma farmácia ou cadastrar uma nova.";
                    }
                    else
                    {
                        TelaPrincipal telaPrincipal = new TelaPrincipal(IdNovoFarmaceutico);
                        this.Hide();
                        telaPrincipal.ShowDialog();
                    }
                    connection.Close();
                }
                /*
                    TelaPrincipal telaPrincipal = new TelaPrincipal(IdNovoFarmaceutico);
                    this.Hide();
                    telaPrincipal.ShowDialog();
                */

            }
        }

        private void InserirTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CriarNovaFarmacia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SouFuncionario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
