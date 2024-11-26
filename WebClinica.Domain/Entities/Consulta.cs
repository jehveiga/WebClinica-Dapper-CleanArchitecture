using WebClinica.Domain.Utils;

namespace WebClinica.Domain.Entities
{
    public class Consulta
    {
        public Consulta(int pacienteID, int medicoID, DateTime dataHoraConsulta)
        {
            SetPacienteID(pacienteID);
            SetMedicoID(medicoID);
            SetDataHoraConsulta(dataHoraConsulta);
        }

        public int ConsultaID { get; private set; } = 0;
        public int PacienteID { get; private set; }

        public int MedicoID { get; private set; }
        public DateTime DataHoraConsulta { get; private set; }
        public string Status { get; private set; } = DefaultValues.STATUS_CONSULTA_DEFAULT;
        public string Observacoes { get; private set; } = string.Empty;

        private void SetPacienteID(int pacienteID)
        {
            if (pacienteID <= 0)
                throw new ArgumentException("O ID do paciente deve ser maior que zero.");
            PacienteID = pacienteID;
        }

        private void SetMedicoID(int medicoID)
        {
            if (medicoID <= 0)
                throw new ArgumentException("O ID do médico deve ser maior que zero.");
            MedicoID = medicoID;
        }

        private void SetDataHoraConsulta(DateTime dataHoraConsulta)
        {
            if (dataHoraConsulta <= DateTime.Now)
                throw new ArgumentException("A data e hora da consulta devem ser no futuro.");
            DataHoraConsulta = dataHoraConsulta;
        }

        public void SetStatus(string status)
        {
            string[] validStatuses = new[] { "Agendada", "Concluída", "Cancelada" };
            if (Array.IndexOf(validStatuses, status) == -1)
                throw new ArgumentException("Status inválido. Use: Agendada, Concluída ou Cancelada.");
            Status = status;
        }

        public void SetObservacoes(string observacoes)
        {
            if (!string.IsNullOrWhiteSpace(observacoes) && observacoes.Length > 500)
                throw new ArgumentException("As observações devem ter no máximo 500 caracteres.");
            Observacoes = observacoes;
        }
    }
}