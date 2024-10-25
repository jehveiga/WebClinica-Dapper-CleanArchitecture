namespace WebClinica.Application.Dtos.ViewModels
{
    public record MedicoViewModel(int Crm, string Nome, char Sexo, DateTime DataNascimento, int EspecialidadeId);
}
