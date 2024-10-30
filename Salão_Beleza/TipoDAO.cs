using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Salão_Beleza
{
    internal class TipoDAO
    {
        public Conexao Conexao { get; set; }
        public SqlCommand Cmd { get; set; }
        public TipoDAO()
        {
            Conexao = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Tipo tipo)
        {
            Cmd.Connection = Conexao.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Tipo VALUES (@nome, @status)";

            Cmd.Parameters.AddWithValue("@nome", tipo.Nome);
            Cmd.Parameters.AddWithValue("@status", tipo.Status);

            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }

        public void Atualizar(Tipo usuarioAtualizado)
        {
            Cmd.Connection = Conexao.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuarios SET Nome = @nome, Status = @status,
    WHERE Id = @id";
            Cmd.Parameters.AddWithValue("@id", usuarioAtualizado.Id);
            Cmd.Parameters.AddWithValue("@nome", usuarioAtualizado.Nome);
            Cmd.Parameters.AddWithValue("@status", usuarioAtualizado.Status);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }

        public void Excluir(int idTipo)
        {
            Cmd.Connection = Conexao.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Tipo WHERE Id = @id";
            Cmd.Parameters.AddWithValue("@id", idTipo);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Conexao.CloseConnection();
            }
        }
        public List<Tipo> ListarTodosTipos()
        {

            Cmd.Connection = Conexao.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Usuarios";

            List<Tipo> listaDeTipos = new List<Tipo>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Tipo tipo = new Tipo((int)rd["Id"],
                        (string)rd["Nome"], (string)rd["Status"]);
                    listaDeTipos.Add(tipo);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Conexao.CloseConnection();
            }
          return listaDeTipos;
        }
    }
}
