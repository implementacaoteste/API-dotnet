using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            using (var context = new AppDbContext())
            {
                context.GrupoUsuario.Add(_grupoUsuario);
                context.SaveChanges();
            }
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            using (var context = new AppDbContext())
            {
                return context.GrupoUsuario.ToList();
            }
        }
        public GrupoUsuario? BuscarPorId(int _id)
        {
            using (var context = new AppDbContext())
            {
                return context.GrupoUsuario.FirstOrDefault(u => u.Id == _id);
            }
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            using (var context = new AppDbContext())
            {
                context.Entry(_grupoUsuario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Excluir(int _id)
        {
            using (var context = new AppDbContext())
            {
                var grupoUsuario = context.GrupoUsuario.Find(_id);
                if (grupoUsuario != null)
                {
                    context.GrupoUsuario.Remove(grupoUsuario);
                    context.SaveChanges();
                }
            }
        }
    }
}