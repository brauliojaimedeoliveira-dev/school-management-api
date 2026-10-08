using Microsoft.EntityFrameworkCore;
using SchoolManager.Api.Data;

var builder = WebApplication.CreateBuilder(args); //É a preparação da aplicação. Pensa aproximadamente como a inicialização do ambiente do Laravel

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Registar o contexto do banco de dados no container de serviços
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); //Adiciona o contexto do banco de dados ao container de serviços
// Fim do Registro do DbContext

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
