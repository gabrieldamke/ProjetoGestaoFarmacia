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

        public Venda(int id, float receita, float lucro, float valorTotal)
        {
            this.id = id;
            this.receita = receita;
            this.lucro = lucro;
            ValorTotal = valorTotal;
        }
    }
}
