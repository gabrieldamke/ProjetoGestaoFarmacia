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
    public partial class Registrar1 : Form
    {
        public Registrar1()
        {
            InitializeComponent();
        }

        private void InserirUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registrar1_Load(object sender, EventArgs e)
        {

        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            StatusLabel.Visible = false;
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            String check = "select count(*) from [TB_FARMACEUTICO] where farmaceutico_email = '" + InserirEmail.Text + "' ";
            SqlCommand command = new SqlCommand(check, connection);
            int aux = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (InserirUsuario.Text == "" || InserirSenha.Text == "" || InserirEmail.Text == "")
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Existe campos vazios. Por favor preencha!";
            } 

            else if (!Regex.Match(InserirUsuario.Text, "^[A-Za-z]+(([,.] |[ '-])[A-Za-z]+)*([.,'-]?)$").Success)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Por favor escreva seu nome e sobrenome";
            }
            else if (!Regex.Match(InserirEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Por favor insira um email válido ";
            }
            else if (aux != 1)
            {
                Registrar2 TelaSplash = new Registrar2(InserirUsuario.Text, InserirSenha.Text, InserirEmail.Text);
                this.Hide();
                TelaSplash.ShowDialog();
                connection.Close();
            }
            else
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "Email já existente.";
            }

        }

        private void InserirEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
