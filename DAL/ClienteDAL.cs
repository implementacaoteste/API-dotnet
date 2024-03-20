using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class ClienteDAL
    {
        public List<Cliente> BuscarTodos()
        {
            using (var context = new AppDbContext())
            {
                return context.Cliente.ToList();
            }
        }
        public Cliente? BuscarPorId(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Cliente.FirstOrDefault(c => c.Id == id);
            }
        }
        public void Inserir(Cliente cliente)
        {
            using (var context = new AppDbContext())
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
            }
        }
        public void Alterar(Cliente cliente)
        {
            using (var context = new AppDbContext())
            {
                context.Entry(cliente).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Excluir(int id)
        {
            using (var context = new AppDbContext())
            {
                var cliente = context.Cliente.Find(id);
                if (cliente != null)
                {
                    context.Cliente.Remove(cliente);
                    context.SaveChanges();
                }
            }
        }
    }
}
