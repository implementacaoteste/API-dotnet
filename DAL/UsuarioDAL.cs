using Models;

namespace DAL
{
    public class UsuarioDAL : DALModelo<Usuario>
    {
        public UsuarioDAL() : base() { }

        public UsuarioDAL(AppDbContext context) : base(context) { }

        public List<Usuario> BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return BuscarTodos().Where(u => u.NomeUsuario == _nomeUsuario).ToList();
        }
    }
}