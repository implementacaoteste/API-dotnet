using Models;
using System.Collections.Generic;

namespace DAL
{
    public class UsuarioDAL
    {
        private List<Usuario> _usuarios; // Supondo que você tenha uma lista de usuários como fonte de dados

        public UsuarioDAL()
        {
            // Inicialize a lista de usuários, pode ser uma simulação de banco de dados
            _usuarios = new List<Usuario>
            {
                new Usuario { Id = 1, Nome = "Usuário 1", Senha = "senha1" },
                new Usuario { Id = 2, Nome = "Usuário 2", Senha = "senha2" },
                new Usuario { Id = 3, Nome = "Usuário 3", Senha = "senha3" }
            };
        }

        public List<Usuario> BuscarTodos()
        {
            return _usuarios; // Retorna todos os usuários da lista
        }
    }
}
