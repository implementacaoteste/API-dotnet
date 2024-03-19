using BLL;
using Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return new UsuarioBLL().BuscarTodos();
        }
    }
}
