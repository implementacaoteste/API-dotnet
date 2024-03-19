using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static readonly List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario(1, "Erisvaldo", "senha123"),
            new Usuario(2, "João", "joao123"),
            // Adicione outros usuários conforme necessário
        };

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return usuarios;
        }
    }
}
