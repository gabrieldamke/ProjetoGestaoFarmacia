using BibliotecaDeClasses1;
namespace ProjetoGestaoFarmacia
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Farmacia farmacia = new Farmacia(1, "a", "a", "a","a","a","a");
            Console.WriteLine(farmacia.endereco);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}