using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{   
    public class EntradaSaida
        {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; } = "";

        public int quantidade;

        public EntradaSaida(int idProduto, string nomeProduto, int quantidade)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            this.quantidade = quantidade;
        }
    }
}
