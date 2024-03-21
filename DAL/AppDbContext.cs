using Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<ContasAPagar> ContasAPagar { get; set; }
        public DbSet<ContasAReceber> ContasAReceber { get; set; }
        public DbSet<DepartamentoProduto> DepartamentoProduto { get; set; }
        public DbSet<FixaKardex> FixaKardex { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<GrupoProduto> GrupoProduto { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuario { get; set; }
        public DbSet<ItemCompra> ItemCompra { get; set; }
        public DbSet<ItemContasAPagar> ItemContasAPagar { get; set; }
        public DbSet<ItemContasAReceber> ItemContasAReceber { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Permissao> Permissao { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<SubGrupoProduto> SubGrupoProduto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venda> Venda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=../DAL/db/app.db");
            }
        }
    }
}