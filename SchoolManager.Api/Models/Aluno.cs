namespace SchoolManager.Api.Models;
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string NumeroProcesso { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; } = string.Empty;
    public bool Ativo { get; set; } = true;
}