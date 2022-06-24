using BibliotecaDeClasses1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestaoFarmacia.DAL
{
    internal class ClienteDAL
    {
        private SqlConnection _sqlConnection;
        public ClienteDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Cliente cliente)
        { 
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_CLIENTE(cliente_nome, cliente_rg, cliente_telefone, cliente_genero, cliente_email, cliente_endereco, cliente_farmacia) " +
                "values(@cliente_nome, @cliente_rg, @cliente_telefone, @cliente_genero, @cliente_email, @cliente_endereco, @cliente_farmacia)";
            //command.Parameters.AddWithValue("@farmaceutico_id", farmaceutico.id);
            command.Parameters.AddWithValue("@cliente_nome", cliente.nome);
            command.Parameters.AddWithValue("@cliente_rg", cliente.rg);
            command.Parameters.AddWithValue("@cliente_telefone", cliente.telefone);
            command.Parameters.AddWithValue("@cliente_genero", cliente.genero);
            command.Parameters.AddWithValue("@cliente_email", cliente.email);
            command.Parameters.AddWithValue("@cliente_endereco", cliente.endereco);
            command.Parameters.AddWithValue("@cliente_farmacia", cliente.farmacia);
            command.ExecuteNonQuery();
            _sqlConnection.Close();

        }
    }
}
