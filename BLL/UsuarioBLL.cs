using System.Collections.Generic;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public List<Usuario> BuscarTodos()
        {
            return new List<Usuario>
            {
                new Usuario(1, "Erisvaldo", "senha123"),
                new Usuario(2, "João", "joao123"),
                // Adicione outros usuários conforme necessário
            };
        }
    }
}
