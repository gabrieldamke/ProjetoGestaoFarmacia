using BibliotecaDeClasses1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestaoFarmacia.DAL
{
    public class FarmaciaDAL
    {
        private SqlConnection _sqlConnection;

        public FarmaciaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir1(Farmacia farmacia)
        { //  public Farmacia(string nome, string telefone, string razaoSocial, string cnpj, string endereco)
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_FARMACIA(farmacia_nome, farmacia_telefone, farmacia_razaosocial, farmacia_cnpj, farmacia_endereco)" +
                "values(@farmacia_nome, @farmacia_telefone, @farmacia_razaosocial, @farmacia_cnpj, @farmacia_endereco)";
            //command.Parameters.AddWithValue("@farmaceutico_id", farmaceutico.id);
            command.Parameters.AddWithValue("@farmacia_nome", farmacia.Nome);
            command.Parameters.AddWithValue("@farmacia_telefone", farmacia.Telefone);
            command.Parameters.AddWithValue("@farmacia_razaosocial", farmacia.RazaoSocial);
            command.Parameters.AddWithValue("@farmacia_cnpj", farmacia.cnpj);
            command.Parameters.AddWithValue("@farmacia_endereco", farmacia.endereco);
            command.ExecuteNonQuery();
            _sqlConnection.Close();

        }

    }
}