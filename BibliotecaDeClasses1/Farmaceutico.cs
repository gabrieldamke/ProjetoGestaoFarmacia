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
        public string endereco { get; set; } = "";
        private string rg { get; set; } = "";
        private float salario { get; set; }
        public DateTime DtNasc { get; set; }
        public string pis { get; set; } = "";
        public string genero { get; set; } = "";
        public string crf { get; set; } = "";

        public Farmaceutico(int id, string nome, string endereco, string rg, float salario, DateTime dtNasc, string pis, string genero, string crf)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.rg = rg;
            this.salario = salario;
            DtNasc = dtNasc;
            this.pis = pis;
            this.genero = genero;
            this.crf = crf;
        }
    }
}
