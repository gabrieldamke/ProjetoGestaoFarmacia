using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeClasses1
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; } = "";
        public string telefone { get; set; } = "";
        public string endereco { get; set; } = "";
        public string rg { get; set; } = "";
        public string genero { get; set; } = "";
        public string email { get; set; } = "";
        public int farmacia { get; set; }
        

        public Cliente( string nome, string telefone, string endereco, string rg, string genero, string email, int farmacia)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
            this.rg = rg;
            this.genero = genero;
            this.email = email;
            this.farmacia = farmacia;
        }
    }
}
