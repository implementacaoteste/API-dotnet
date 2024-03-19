using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
    {
        public List<Usuario> BuscarTodos()
        {
            return new UsuarioDAL().BuscarTodos();
        }
    }
}
