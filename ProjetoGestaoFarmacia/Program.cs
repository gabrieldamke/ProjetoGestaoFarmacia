using BibliotecaDeClasses1;
using ProjetoGestaoFarmacia.DAL;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProjetoGestaoFarmacia
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_IdealFarma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            string connectionString = ConfigurationManager.ConnectionStrings["IdealFarma"].ConnectionString;
            Farmaceutico farmaceutico = new ("jasmine", "admin2", "admin2", "40028922", "Rua Bahia", "33.22.3", 25000, "2015/ 12/ 31", "1292923", "Masculino", "123");
            FarmaceuticoDAL dal = new FarmaceuticoDAL(new SqlConnection(connectionString));
            dal.Inserir1(farmaceutico);
            */
            Application.Run(new Login());
  





        }
    }
}