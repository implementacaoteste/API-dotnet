using DAL;
using Models;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            new GrupoUsuarioDAL().Inserir(_grupoUsuario);
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            return new GrupoUsuarioDAL().BuscarTodos();
        }
        public GrupoUsuario? BuscarPorId(int _id)
        {
            return new GrupoUsuarioDAL().BuscarPorId(_id);
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            new GrupoUsuarioDAL().Alterar(_grupoUsuario);
        }
        public void Excluir(int _id)
        {
            new GrupoUsuarioDAL().Excluir(_id);
        }
    }
}