using System.ComponentModel.DataAnnotations;
using WebClinica.Domain.Utils;

namespace WebClinica.Domain.Entities
{
    public class Usuario
    {
        public Usuario(string nome, string login, string senha, string tipo)
        {
            SetNome(nome);
            SetLogin(login);
            SetSenha(senha);
        }

        public int UsuarioID { get; private set; } = 0;

        [Required, StringLength(100)]
        public string Nome { get; private set; } = string.Empty;

        [Required, StringLength(50)]
        public string Login { get; private set; } = string.Empty;

        [Required]
        public string SenhaHash { get; private set; } = string.Empty;

        [StringLength(20)]
        public string Tipo { get; private set; } = DefaultValues.TIPO_USUARIO_DEFAULT;  // Ex.: Administrador, Recepcionista, Médico

        public bool Ativo { get; private set; } = true;

        public DateTime DataCadastro { get; private set; } = DateTime.Now;

        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length > 100)
                throw new ArgumentException("O nome deve ser preenchido e ter no máximo 100 caracteres.");
            Nome = nome;
        }

        private void SetLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login) || login.Length > 50)
                throw new ArgumentException("O login deve ser preenchido e ter no máximo 50 caracteres.");
            Nome = login;
        }

        private void SetSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("A senha deve ser preenchida.");
            Nome = senha;
        }

        public void SetTipo(string tipo)
        {
            string[] validStatuses = ["Administrador", "Recepcionista", "Médico"];
            if (Array.IndexOf(validStatuses, tipo) == -1)
                throw new ArgumentException("Tipo inválido. Use: Administrador, Recepcionista ou Médico.");
            Tipo = tipo;
        }
    }
}