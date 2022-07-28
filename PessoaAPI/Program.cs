using Microsoft.EntityFrameworkCore;
using PessoaAPI.Business;
using PessoaAPI.Business.Implementations;
using PessoaAPI.Model;
using PessoaAPI.Repository;
using PessoaAPI.Repository.Generic;

var builder = WebApplication.CreateBuilder(args);

// Adicione serviços ao contêiner.
builder.Services.AddControllers();

//Injenção de dependencia
builder.Services.AddScoped<IPessoaBusiness, PessoaBusinessImplementation>();
builder.Services.AddScoped<ILivroBusiness, LivroBusinessImplementation>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

//Conexão com o Banco MySql
builder.Services.AddDbContext<MySQLContext>(o => o.UseMySql(
             builder.Configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 11))));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Mapeamento da Versão da Api
builder.Services.AddApiVersioning();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

