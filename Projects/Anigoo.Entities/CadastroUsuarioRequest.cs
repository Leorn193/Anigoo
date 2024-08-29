namespace Anigoo.Entities
{
    public class CadastroUsuarioRequest
    {
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
    }
}
