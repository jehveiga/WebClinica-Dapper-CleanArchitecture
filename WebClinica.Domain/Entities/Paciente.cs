namespace WebClinica.Domain.Entities
{
    public class Paciente
    {
        public Paciente(string nome, string cpf, DateTime dataNascimento)
        {
            SetNome(nome);
            SetCPF(cpf);
            SetDataNascimento(dataNascimento);
        }

        public int PacienteID { get; private set; } = 0;
        public string Nome { get; private set; } = string.Empty;

        public string CPF { get; private set; } = string.Empty;
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Endereco { get; private set; } = string.Empty;
        public DateTime DataCadastro { get; private set; } = DateTime.Now;

        private void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length > 100)
                throw new ArgumentException("O nome deve ser preenchido e ter no máximo 100 caracteres.");
            Nome = nome;
        }

        private void SetCPF(string cpf)
        {
            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
                throw new ArgumentException("O CPF deve ter 11 dígitos numéricos.");
            CPF = cpf;
        }

        private void SetDataNascimento(DateTime dataNascimento)
        {
            if (dataNascimento >= DateTime.Now)
                throw new ArgumentException("A data de nascimento deve ser no passado.");
            DataNascimento = dataNascimento;
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

        public void SetEndereco(string endereco)
        {
            if (!string.IsNullOrWhiteSpace(endereco) && endereco.Length > 200)
                throw new ArgumentException("O endereço deve ter no máximo 200 caracteres.");
            Endereco = endereco;
        }
    }
}