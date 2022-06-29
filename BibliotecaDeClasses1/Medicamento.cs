using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses1
{
public class Medicamento
    {
        public string nome { get; set; } = "";
        public int receitamedica { get; set; }
        public float valor { get; set; }
        public string descricao { get; set; } = "";

        public int quantidade { get; set; }
        public int farmacia { get; set; }
        public Medicamento( string nome, int receitaMedica, float valor, string Descricao)
        {
            this.nome = nome;
            receitamedica = receitaMedica;
            this.valor = valor;
            descricao = Descricao;
        }

        public Medicamento(string nome, int receitaMedica, float valor, string Descricao, int farmacia)
        {
            this.nome = nome;
            receitamedica = receitaMedica;
            this.valor = valor;
            descricao = Descricao;
            this.farmacia = farmacia;
        }


        public Medicamento Limpar()
        {
            string nome = "";
            int receitamedica = 0;
            float valor = 0;
            string descricao = "";
            Medicamento medicamento = new Medicamento(nome, receitamedica, valor, descricao);
            return medicamento;
        }

        public Medicamento ReduzirEstoque(Medicamento medicamento, int quantidade)
        {
            medicamento.quantidade= medicamento.quantidade - quantidade;
            return medicamento;
        }
        public Medicamento AumentarEstoque(Medicamento medicamento, int quantidade)
        {
            medicamento.quantidade = medicamento.quantidade + quantidade;
            return medicamento;
        }
        
    }
}
