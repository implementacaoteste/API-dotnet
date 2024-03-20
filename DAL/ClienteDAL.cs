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
                //O ponto de interrupção está na linha abaixo para que eu possa rodar um commando no immediate windows e descobrir qual é a string de conexão.
                string conexao = ((DbContext)context).Database.GetDbConnection().ConnectionString;
                TestarConexao(conexao);
                var clienteList = context.Cliente.ToList();
                return clienteList;
            }
        }
        private void TestarConexao(string connetionString)
        {
            using (var connection = new SqliteConnection(connetionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão bem-sucedida!");

                    // Aqui você pode adicionar código para executar outras operações, como verificar a existência de tabelas.
                    // Por exemplo:
                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='Cliente';";
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Console.WriteLine("A tabela 'Cliente' existe.");
                    }
                    else
                    {
                        Console.WriteLine("A tabela 'Cliente' não existe.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
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
