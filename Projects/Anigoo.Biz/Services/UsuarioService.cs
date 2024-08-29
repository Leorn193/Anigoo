using Anigoo.Biz.Interfaces;
using Anigoo.Data.Models;
using Anigoo.Entities;

namespace Anigoo.Biz.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool CadastrarUsuario(CadastroUsuarioRequest dados)
        {
            if (dados == null) return false;
            Usuario usuario = new(dados.Nome, dados.Usuario, dados.Senha, dados.Telefone, dados.Email, false);
            _usuarioRepository.Adicionar(usuario);
            _usuarioRepository.Commit();
            return true;
        }
    }
}
