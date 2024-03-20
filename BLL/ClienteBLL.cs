using DAL;
using Models;

namespace BLL
{
    public class ClienteBLL
    {
        private readonly ClienteDAL clienteDAL;

        public ClienteBLL()
        {
            clienteDAL = new ClienteDAL();
        }

        public List<Cliente> BuscarTodos()
        {
            return clienteDAL.BuscarTodos();
        }

        public Cliente? BuscarPorId(int id)
        {
            return clienteDAL.BuscarPorId(id);
        }

        public void Inserir(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente));
            }

            clienteDAL.Inserir(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente));
            }

            clienteDAL.Alterar(cliente);
        }

        public void Excluir(int id)
        {
            clienteDAL.Excluir(id);
        }
    }
}
