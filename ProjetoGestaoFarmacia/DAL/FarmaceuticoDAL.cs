using BibliotecaDeClasses1;
using System.Data.SqlClient;

namespace ProjetoGestaoFarmacia.DAL
{
    public class FarmaceuticoDAL
    {
        private SqlConnection _sqlConnection;

        public FarmaceuticoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir1 (Farmaceutico farmaceutico)
        { // Farmaceutico(int id, string nome, string email, string senha, string endereco, string rg, float salario, String dtNasc, string pis, string genero, string crf)
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_FARMACEUTICO(farmaceutico_nome, farmaceutico_email, farmaceutico_senha, farmaceutico_telefone, farmaceutico_endereco, farmaceutico_rg, farmaceutico_salario, farmaceutico_dtNasc, farmaceutico_pis, farmaceutico_genero, farmaceutico_crf) " +
                "values(@farmaceutico_nome, @farmaceutico_email, @farmaceutico_senha, @farmaceutico_telefone, @farmaceutico_endereco, @farmaceutico_rg, @farmaceutico_salario, @farmaceutico_dtNasc, @farmaceutico_pis, @farmaceutico_genero, @farmaceutico_crf)";
            //command.Parameters.AddWithValue("@farmaceutico_id", farmaceutico.id);
            command.Parameters.AddWithValue("@farmaceutico_nome", farmaceutico.nome);
            command.Parameters.AddWithValue("@farmaceutico_email", farmaceutico.email);
            command.Parameters.AddWithValue("@farmaceutico_senha", farmaceutico.senha);
            command.Parameters.AddWithValue("@farmaceutico_telefone", farmaceutico.telefone);
            command.Parameters.AddWithValue("@farmaceutico_endereco", farmaceutico.endereco);
            command.Parameters.AddWithValue("@farmaceutico_rg", farmaceutico.rg);
            command.Parameters.AddWithValue("@farmaceutico_salario", farmaceutico.salario);
            command.Parameters.AddWithValue("@farmaceutico_DtNasc", farmaceutico.dtNasc);
            command.Parameters.AddWithValue("@farmaceutico_pis", farmaceutico.pis);
            command.Parameters.AddWithValue("@farmaceutico_genero", farmaceutico.genero);
            command.Parameters.AddWithValue("@farmaceutico_crf", farmaceutico.crf);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
             
        }
        public void Inserir2(Farmaceutico farmaceutico)
        { // Farmaceutico(int id, string nome, string email, string senha, string endereco, string rg, float salario, String dtNasc, string pis, string genero, string crf)
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_FARMACEUTICO(farmaceutico_nome, farmaceutico_email, farmaceutico_senha, farmaceutico_telefone, farmaceutico_endereco, farmaceutico_rg, farmaceutico_salario, farmaceutico_dtNasc, farmaceutico_pis, farmaceutico_genero, farmaceutico_crf, farmaceutico_farmacia) " +
                "values(@farmaceutico_nome, @farmaceutico_email, @farmaceutico_senha, @farmaceutico_telefone, @farmaceutico_endereco, @farmaceutico_rg, @farmaceutico_salario, @farmaceutico_dtNasc, @farmaceutico_pis, @farmaceutico_genero, @farmaceutico_crf, @farmaceutico_farmacia)";
            //command.Parameters.AddWithValue("@farmaceutico_id", farmaceutico.id);
            command.Parameters.AddWithValue("@farmaceutico_nome", farmaceutico.nome);
            command.Parameters.AddWithValue("@farmaceutico_email", farmaceutico.email);
            command.Parameters.AddWithValue("@farmaceutico_senha", farmaceutico.senha);
            command.Parameters.AddWithValue("@farmaceutico_telefone", farmaceutico.telefone);
            command.Parameters.AddWithValue("@farmaceutico_endereco", farmaceutico.endereco);
            command.Parameters.AddWithValue("@farmaceutico_rg", farmaceutico.rg);
            command.Parameters.AddWithValue("@farmaceutico_salario", farmaceutico.salario);
            command.Parameters.AddWithValue("@farmaceutico_DtNasc", farmaceutico.dtNasc);
            command.Parameters.AddWithValue("@farmaceutico_pis", farmaceutico.pis);
            command.Parameters.AddWithValue("@farmaceutico_genero", farmaceutico.genero);
            command.Parameters.AddWithValue("@farmaceutico_crf", farmaceutico.crf);
            command.Parameters.AddWithValue("@farmaceutico_farmacia", farmaceutico.farmacia);
            command.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        /*
        public Farmaceutico ObterPorID(int id)
        {
            Farmaceutico farmaceutico = new Farmaceutico();
            var command = new SqlCommand("select * from TB_FARMACEUTICO where farmaceutico_id = @id", _sqlConnection);
            command.Parameters.AddWithValue("@id", id);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    farmaceutico.id = rea;
                    farmaceutico.nome = reader["farmaceutico_nome"].ToString();
                    //farmaceutico = new Farmaceutico(id.ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetFloat(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
             
                }
                _sqlConnection.Close();
                return farmaceutico;
            }
        }
        */
    }
        
}
