using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class ClienteDAL
    {
        private List<Cliente> clienteList;
        private readonly AppDbContext _context;

        public ClienteDAL(AppDbContext context)
        {
            _context = context;
            clienteList = new List<Cliente>();
        }

        public List<Cliente> BuscarTodos()
        {
            return _context.Clientes.ToList();
        }

        public Cliente BuscarPorId(int id)
        {
            var cliente = clienteList.FirstOrDefault(c => c.Id == id);
            if(cliente == null)
                throw new Exception("Cliente não encontrado");
            
            return cliente;
        }

        public void Inserir(Cliente cliente)
        {
            cliente.Id = clienteList.Count + 1;
            clienteList.Add(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            var clienteExistente = clienteList.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Fone = cliente.Fone;
                clienteExistente.Email = cliente.Email;
            }
        }

        public void Excluir(int id)
        {
            var cliente = clienteList.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                clienteList.Remove(cliente);
            }
        }
    }
}
