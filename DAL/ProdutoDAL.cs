using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class ProdutoDAL
    {
        public void Inserir(Produto _produto)
        {
            using (var context = new AppDbContext())
            {
                context.Produto.Add(_produto);
                context.SaveChanges();
            }
        }
        public List<Produto> BuscarTodos()
        {
            using (var context = new AppDbContext())
            {
                return context.Produto.ToList();
            }
        }
        public Produto? BuscarPorId(int _id)
        {
            using (var context = new AppDbContext())
            {
                return context.Produto.FirstOrDefault(u => u.Id == _id);
            }
        }
        public void Alterar(Produto _produto)
        {
            using (var context = new AppDbContext())
            {
                context.Entry(_produto).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Excluir(int _id)
        {
            using (var context = new AppDbContext())
            {
                var produto = context.Produto.Find(_id);
                if (produto != null)
                {
                    context.Produto.Remove(produto);
                    context.SaveChanges();
                }
            }
        }
    }
}