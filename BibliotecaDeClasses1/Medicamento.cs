using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
public class Medicamento
    {
        public int id { get; set; }
        public string nome { get; set; } = "";
        public bool ReceitaMedica { get; set; }
        public float valor { get; set; }
        public string DtValidade { get; set; }
        public int quantidade { get; set; }

        public Medicamento(int id, string nome, bool receitaMedica, float valor, string dataValidade, int quantidade)
        {
            this.id = id;
            this.nome = nome;
            ReceitaMedica = receitaMedica;
            this.valor = valor;
            DtValidade = dataValidade;
            this.quantidade = quantidade;
        }
    }
}
