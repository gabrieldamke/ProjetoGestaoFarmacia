using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
   public class Custo
    {
        public int id { get; set; }
        public string TipoCusto { get; set; } = "";
        public float valor { get; set; }

        public Custo(int id, string tipoCusto, float valor)
        {
            this.id = id;
            TipoCusto = tipoCusto;
            this.valor = valor;
        }
    }
}
