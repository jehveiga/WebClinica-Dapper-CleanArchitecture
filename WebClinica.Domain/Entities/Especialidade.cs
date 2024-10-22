namespace WebClinica.Domain.Entities
{
    public class Especialidade
    {
        public int IdEsp { get; }
        public string Nome { get; private set; }

        public Especialidade(string nome)
        {
            Nome = nome;
        }

        public Especialidade(int id_Esp, string nome)
        {
            IdEsp = id_Esp;
            Nome = nome;
        }
    }
}
