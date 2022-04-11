using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
    public class Estoque
    {
        String Medicamento { get; set; } = "";
        int quantidade { get; set; }

        public Estoque(string medicamento, int quantidade)
        {
            Medicamento = medicamento;
            this.quantidade = quantidade;
        }
    }
}
