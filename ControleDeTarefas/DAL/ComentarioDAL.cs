using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ComentarioDAL
    {
        public Comentario Inserir(Comentario _comentario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirComentario";


                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = IncrementaIDComentario()
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Usuario", SqlDbType.Int)
                {
                    Value = _comentario.Id_Usuario
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Tarefa", SqlDbType.Int)
                {
                    Value = _comentario.Id_Tarefa
                });

                cmd.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.VarChar)
                {
                    Value = _comentario.Descricao
                });

                cn.Open();
                _comentario.Id = Convert.ToInt32(cmd.ExecuteScalar());


                return _comentario;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private int IncrementaIDComentario()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select IsNULL(max(Id),0) +1 from Comentario";
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
            finally
            {
                cn.Close();
            }
        }
            public DataTable Buscar(int _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarComentario";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.Int);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);
                cn.Open();
                da.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirComentario";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não possivel excluir o usuário: " + _id.ToString());
            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
