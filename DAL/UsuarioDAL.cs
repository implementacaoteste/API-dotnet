using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            using (var context = new AppDbContext())
            {
                context.Usuario.Add(_usuario);
                context.SaveChanges();
            }
        }
        public List<Usuario> BuscarTodos()
        {
            using (var context = new AppDbContext())
            {
                return context.Usuario.ToList();
            }
        }
        public Usuario? BuscarPorId(int _id)
        {
            using (var context = new AppDbContext())
            {
                return context.Usuario.FirstOrDefault(u => u.Id == _id);
            }
        }
        public void Alterar(Usuario _usuario)
        {
            using (var context = new AppDbContext())
            {
                context.Entry(_usuario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Excluir(int _id)
        {
            using (var context = new AppDbContext())
            {
                var usuario = context.Usuario.Find(_id);
                if (usuario != null)
                {
                    context.Usuario.Remove(usuario);
                    context.SaveChanges();
                }
            }
        }
    }
}