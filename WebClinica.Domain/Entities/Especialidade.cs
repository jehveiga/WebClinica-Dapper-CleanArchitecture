namespace WebClinica.Domain.Entities
{
    public class Especialidade
    {
        public Especialidade(string nome)
        {
            SetNome(nome);
        }

        public int EspecialidadeID { get; private set; } = 0;

        public string Nome { get; private set; } = string.Empty;

        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length > 100)
                throw new ArgumentException("O nome deve ser preenchido e ter no máximo 100 caracteres.");
            Nome = nome;
        }
    }
}