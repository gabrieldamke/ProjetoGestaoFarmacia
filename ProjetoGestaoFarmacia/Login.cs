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
using ProjetoGestaoFarmacia.DAL;
namespace ProjetoGestaoFarmacia
{
    public partial class Login : Form
        
    {



        public Login()
        {
            InitializeComponent();
         
        }
      
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            Registrar1 TelaRegistro = new Registrar1();
            this.Hide();
            TelaRegistro.ShowDialog();
            
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                String check = "select count(*) from [TB_FARMACEUTICO] where farmaceutico_email = '" + InserirUsuario.Text + "' and farmaceutico_senha = '" + InserirSenha.Text + "' ";
                SqlCommand command = new SqlCommand (check, connection);
                int aux = Convert.ToInt32(command.ExecuteScalar().ToString());
                connection.Close();
                if (aux == 1)
                {
                    connection.Open();
                    String PassarIdAux = "select farmaceutico_id from [TB_FARMACEUTICO] where farmaceutico_email = '" + InserirUsuario.Text + "' and farmaceutico_senha = '" + InserirSenha.Text + "' ";
                    SqlCommand command2 = new SqlCommand(PassarIdAux, connection);
                    int PassarId = (int)command2.ExecuteScalar();
                    TelaPrincipal telaPrincipal = new TelaPrincipal(PassarId);
                    connection.Close();
                    this.Hide();
                    telaPrincipal.ShowDialog();
                    label8.Visible = false;
                } else
                {
                    label8.Visible=true;
                    label8.Text = "Dados incorretos.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Alert("Pedro vai pega dp kkk", Form_Alert.enmType.Info);

        }
    }
}
