using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        public DataTable Buscar(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_filtro);
        }
    }
}
