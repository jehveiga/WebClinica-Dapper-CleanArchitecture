namespace WebClinica.Domain.Entities
{
    public class Consulta
    {
        public Consulta(int pacienteId, int crm, DateTime dataHoraConsulta, char tipoConsulta, string descricaoAtendimento)
        {
            PacienteId = pacienteId;
            Crm = crm;
            DataHoraConsulta = dataHoraConsulta;
            TipoConsulta = tipoConsulta;
            DescricaoAtendimento = descricaoAtendimento;
        }

        public int PacienteId { get; private set; }
        public int Crm { get; private set; }
        public DateTime DataHoraConsulta { get; private set; }
        public char TipoConsulta { get; private set; }
        public string DescricaoAtendimento { get; private set; }

    }
}
