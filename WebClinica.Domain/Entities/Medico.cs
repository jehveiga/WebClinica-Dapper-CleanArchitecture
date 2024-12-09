namespace WebClinica.Domain.Entities
{
    public class Medico
    {
        public Medico(string nome, string crm, string especialidade, string telefone, string email)
        {
            SetNome(nome);
            SetCRM(crm);
            SetEspecialidade(especialidade);
            SetTelefone(telefone);
        }

        public int MedicoID { get; private set; } = 0;
        public string Nome { get; private set; } = string.Empty;
        public string Crm { get; private set; } = string.Empty;
        public string Especialidade { get; private set; } = string.Empty;
        public string Telefone { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public DateTime DataCadastro { get; private set; } = DateTime.Now;

        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length > 100)
                throw new ArgumentException("O nome deve ser preenchido e ter no máximo 100 caracteres.");
            Nome = nome;
        }

        private void SetCRM(string crm)
        {
            if (string.IsNullOrWhiteSpace(crm) || crm.Length > 20)
                throw new ArgumentException("O CRM deve ser preenchido e ter no máximo 20 caracteres.");
            Crm = crm;
        }

        private void SetEspecialidade(string especialidade)
        {
            if (string.IsNullOrWhiteSpace(especialidade) || especialidade.Length > 100)
                throw new ArgumentException("A especialidade deve ser preenchida e ter no máximo 100 caracteres.");
            Especialidade = especialidade;
        }

        public void SetTelefone(string telefone)
        {
            if (!string.IsNullOrWhiteSpace(telefone) && telefone.Length > 20)
                throw new ArgumentException("O telefone deve ter no máximo 20 caracteres.");
            Telefone = telefone;
        }

        public void SetEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email) && email.Length > 100)
                throw new ArgumentException("O email deve ter no máximo 100 caracteres.");
            Email = email;
        }
    }
}