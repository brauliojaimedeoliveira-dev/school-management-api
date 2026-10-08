using Microsoft.EntityFrameworkCore;
using SchoolManager.Api.Models;

namespace SchoolManager.Api.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; }
}