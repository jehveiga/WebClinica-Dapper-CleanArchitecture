namespace WebClinica.Domain.Entities
{
    public class Medico
    {
        public Medico(int crm, string nome, char sexo, DateTime dataNascimento)
        {
            Crm = crm;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
        }

        public Medico(int crm, string nome, char sexo, DateTime dataNascimento, int especialidadeId, Especialidade especialidade)
        {
            Crm = crm;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            EspecialidadeId = especialidadeId;
            Especialidade = especialidade;
        }

        public int Crm { get; private set; }
        public string Nome { get; set; }
        public char Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int EspecialidadeId { get; private set; }
        public Especialidade? Especialidade { get; set; }
    }
}
