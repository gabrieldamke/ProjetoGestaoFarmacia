using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; } = "";
        public string telefone { get; set; } = "";
        public string endereco { get; set; } = "";
        public string rg { get; set; } = "";

        public Cliente(int id, string nome, string telefone, string endereco, string rg)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
            this.rg = rg;
        }
    }
}
