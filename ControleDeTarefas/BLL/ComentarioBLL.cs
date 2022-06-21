using DAL;
using Model;
using System.Data;

namespace BLL
{
   public class ComentarioBLL
    {
        public Comentario Inserir(Comentario comentario)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Inserir(comentario);
        }
        public DataTable Buscar(int _filtro)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            return comentarioDAL.Buscar(_filtro);
        }
        public void Excluir(int _id)
        {
            ComentarioDAL comentarioDAL = new ComentarioDAL();
            comentarioDAL.Excluir(_id);
        }
    }
}
