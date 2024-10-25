namespace WebClinica.Application.Dtos.InputModels
{
    public record CreateMedicoInputModel(int Crm, string Nome, char Sexo, DateTime DataNascimento, int EspecialidadeId);
}
