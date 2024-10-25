namespace WebClinica.Application.Dtos.InputModels
{
    public record UpdateMedicoInputModel(string Nome, char Sexo, DateTime DataNascimento, int EspecialidadeId);
}
