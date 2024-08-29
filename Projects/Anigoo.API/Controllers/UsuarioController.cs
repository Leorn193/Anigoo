using Anigoo.Biz.Services;
using Anigoo.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Anigoo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult CadastrarUsuario(CadastroUsuarioRequest dados)
        {
            var retorno = _usuarioService.CadastrarUsuario(dados);
            if(retorno == true)
            {
                return Ok("USUÁRIO CADASTRADO COM SUCESSO");
            }
            return BadRequest("FALHA AO CADASTRAR USUÁRIO");
        }
    }
}
