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

    public Cliente InstanciarObjeto (int ClienteID)
        {
           
                Cliente cliente = new Cliente();
                _sqlConnection.Open();
                SqlCommand commandObterNome = _sqlConnection.CreateCommand();
                commandObterNome.CommandText = "select cliente_nome from tb_cliente where cliente_id = '" + ClienteID + "' ";
                cliente.nome = (string)commandObterNome.ExecuteScalar();
                SqlCommand commandObterRG = _sqlConnection.CreateCommand();
                commandObterRG.CommandText = "select cliente_rg from tb_cliente where cliente_id = '" + ClienteID + "' ";
                cliente.rg = (string)commandObterNome.ExecuteScalar();
                SqlCommand commandObterTelefone = _sqlConnection.CreateCommand();
                commandObterTelefone.CommandText = "select cliente_telefone from tb_cliente where cliente_id = '" + ClienteID + "' ";
                cliente.telefone = (string)commandObterNome.ExecuteScalar();
                SqlCommand commandObterGenero = _sqlConnection.CreateCommand();
                commandObterGenero.CommandText = "select cliente_genero from tb_cliente where cliente_id = '" + ClienteID + "' ";
                cliente.telefone = (string)commandObterGenero.ExecuteScalar();
                SqlCommand commandObterEmail = _sqlConnection.CreateCommand();
                commandObterEmail.CommandText = "select cliente_email from tb_cliente where cliente_id = '" + ClienteID + "' ";
                cliente.telefone = (string)commandObterEmail.ExecuteScalar();
                SqlCommand commandObterEndereco = _sqlConnection.CreateCommand();
                commandObterEndereco.CommandText = "select cliente_endereco from tb_cliente where cliente_id = '" + ClienteID + "' ";
                cliente.endereco = (string)commandObterEndereco.ExecuteScalar();
                SqlCommand commandObterFarmacia = _sqlConnection.CreateCommand();
                commandObterFarmacia.CommandText = "select cliente_farmacia from tb_cliente where cliente_id = '" + ClienteID + "' ";
                cliente.farmacia = (int)commandObterFarmacia.ExecuteScalar();
                _sqlConnection.Close();
                return cliente;
            } 

    public void Atualizar (Cliente cliente)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "UPDATE TB_CLIENTE set cliente_nome, cliente_rg, cliente_telefone, cliente_genero, cliente_email, cliente_endereco, cliente_farmacia " +
                "values(@cliente_nome, @cliente_rg, @cliente_telefone, @cliente_genero, @cliente_email, @cliente_endereco, @cliente_farmacia)";
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

