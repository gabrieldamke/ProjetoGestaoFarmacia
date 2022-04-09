using BibliotecaDeClasses1;
namespace ProjetoGestaoFarmacia
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Farmacia farmacia = new Farmacia();
            Console.WriteLine(farmacia.endereco);
        }
    }
}