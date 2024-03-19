using Models;

namespace DAL
{
    public class UsuarioDAL
    {
        private List<Usuario> usuarioList; // Supondo que você tenha uma lista de usuários como fonte de dados

        public UsuarioDAL()
        {
            // Inicialize a lista de usuários, pode ser uma simulação de banco de dados
            usuarioList = new List<Usuario>
            {
                new Usuario { Id = 1, Nome = "Usuário 1", Senha = "senha1" },
                new Usuario { Id = 2, Nome = "Usuário 2", Senha = "senha2" },
                new Usuario { Id = 3, Nome = "Usuário 3", Senha = "senha3" }
            };
        }

        public List<Usuario> BuscarTodos()
        {
            return usuarioList; // Retorna todos os usuários da lista
        }

        
        public Usuario BuscarPorId(int _id)
        {
            var usuario = usuarioList.FirstOrDefault(u => u.Id == _id);

            if (usuario == null)
                throw new ArgumentException("Usuário não encontrado");

            return usuario;
        }

        public void Inserir(Usuario _usuario)
        {
            // Atribui um novo ID para o usuário (simulação simples)
            _usuario.Id = usuarioList.Count + 1;
            usuarioList.Add(_usuario); // Adiciona o usuário à lista
        }

        public void Alterar(Usuario _usuario)
        {
            // Encontra o usuário na lista pelo ID
            var usuario = usuarioList.FirstOrDefault(u => u.Id == _usuario.Id);
            if (usuario != null)
            {
                // Atualiza os dados do usuário existente com os dados do usuário atualizado
                usuario.Nome = _usuario.Nome;
                usuario.Senha = _usuario.Senha;
            }
            else
            {
                throw new ArgumentException("Usuário não encontrado");
            }
        }

        public void Excluir(int _id)
        {
            // Encontra o usuário na lista pelo ID
            var usuario = usuarioList.FirstOrDefault(u => u.Id == _id);
            if (usuario != null)
            {
                usuarioList.Remove(usuario); // Remove o usuário da lista
            }
            else
            {
                throw new ArgumentException("Usuário não encontrado");
            }
        }
    }
}