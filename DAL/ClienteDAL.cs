using Models;

namespace DAL
{
    public class ClienteDAL
    {
        private List<Cliente> clienteList;

        public ClienteDAL()
        {
            clienteList = new List<Cliente>
            {
                new Cliente { Id = 1, Nome = "Cliente 1", Fone = "123456789", Email = "cliente1@example.com" },
                new Cliente { Id = 2, Nome = "Cliente 2", Fone = "987654321", Email = "cliente2@example.com" },
                new Cliente { Id = 3, Nome = "Cliente 3", Fone = "456123789", Email = "cliente3@example.com" }
            };
        }

        public List<Cliente> BuscarTodos()
        {
            return clienteList;
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
