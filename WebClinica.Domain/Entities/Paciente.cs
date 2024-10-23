namespace WebClinica.Domain.Entities
{
    public class Paciente
    {
        public Paciente(string nome, char sexo, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public Paciente(int id, string nome, char sexo, DateTime dataNascimento, string cpf)
        {
            Id = id;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public char Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Cpf { get; private set; }
    }
}
