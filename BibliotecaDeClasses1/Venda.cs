using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
    public class Venda
    {
        public int id;
        public float receita;
        public float lucro;
        public float ValorTotal;
        public int finalizada;
        public Venda(int id, float receita, float lucro, float valorTotal, int finalizada)
        {
            this.id = id;
            this.receita = receita;
            this.lucro = lucro;
            ValorTotal = valorTotal;
            this.finalizada = finalizada;
        }
    }
}
