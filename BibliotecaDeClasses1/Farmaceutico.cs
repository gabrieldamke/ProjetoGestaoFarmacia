using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
    public class Farmaceutico
    {
        public int id { get; set; }
        public string nome { get; set; } = "";
        public string email { get; set; } = "";
        public string senha { get; set; } = "";
        public string endereco { get; set; } = "";
        public string telefone { get; set; } = "";
        public string rg { get; set; } = "";
        public float salario { get; set; }
        public string dtNasc { get; set; } = "";
        public string pis { get; set; } = "";
        public string genero { get; set; } = "";
        public string crf { get; set; } = "";
        public int farmacia { get; set; }
        // Construtor com id
        public Farmaceutico(int id, string nome, string email, string senha, string telefone, string endereco, string rg, float salario, String dtNasc, string pis, string genero, string crf)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
            this.endereco = endereco;
            this.rg = rg;
            this.salario = salario;
            this.dtNasc = dtNasc;
            this.pis = pis;
            this.genero = genero;
            this.crf = crf;
        }
        // Construtor sem id
        public Farmaceutico(string nome, string email, string senha, string endereco, string telefone, string rg, float salario, string dtNasc, string pis, string genero, string crf)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.endereco = endereco;
            this.telefone = telefone;
            this.rg = rg;
            this.salario = salario;
            this.dtNasc = dtNasc;
            this.pis = pis;
            this.genero = genero;
            this.crf = crf;
        }
        public Farmaceutico(string nome, string email, string senha, string endereco, string telefone, string rg, float salario, string dtNasc, string pis, string genero, string crf, int farmacia)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.endereco = endereco;
            this.telefone = telefone;
            this.rg = rg;
            this.salario = salario;
            this.dtNasc = dtNasc;
            this.pis = pis;
            this.genero = genero;
            this.crf = crf;
            this.farmacia = farmacia;
        }
    }
}

