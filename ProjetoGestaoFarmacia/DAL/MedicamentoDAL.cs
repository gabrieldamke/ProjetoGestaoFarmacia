using BibliotecaDeClasses1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestaoFarmacia.DAL
{
    public class MedicamentoDAL
    {
        private SqlConnection _sqlConnection;

        public MedicamentoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir1(Medicamento medicamento)
        { 
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_MEDICAMENTO(medicamento_nome, medicamento_receitamedica, medicamento_valor, medicamento_descricao) " +
                "values(@medicamento_nome, @medicamento_receitamedica, @medicamento_valor, @medicamento_descricao";
            command.Parameters.AddWithValue("@medicamento_nome", medicamento.nome);
            command.Parameters.AddWithValue("@medicamento_receitamedica", medicamento.receitamedica);
            command.Parameters.AddWithValue("@medicamento_valor", medicamento.valor);
            command.Parameters.AddWithValue("@medicamento_descricao", medicamento.descricao);
            command.ExecuteNonQuery();
            _sqlConnection.Close();

        }

    }
}
