using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
public class Farmacia
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string RazaoSocial { get; set; } = "";
       
        public string cnpj { get; set; } = "";
        public string endereco { get; set; } = "";

        public Farmacia(int id, string nome, string telefone, string razaoSocial, string cnpj, string endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            RazaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.endereco = endereco;
        }
    }
}
