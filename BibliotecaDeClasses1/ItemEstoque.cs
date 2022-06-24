using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
    public class ItemEstoque
    {


        int id { get; set; }
        int medicamento { get; set; }
        int farmacia { get; set; }
        int quantidade { get; set; }
        public ItemEstoque(int id, int medicamento, int farmacia, int quantidade)
        {
            this.id = id;
            this.medicamento = medicamento;
            this.farmacia = farmacia;
            this.quantidade = quantidade;
        }
    }
}
