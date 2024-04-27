using PrimeiraApi.Context;
using PrimeiraApi.Service;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using PrimeiraApi.Interfaces;
using PrimeiraApi.Repository;
using PrimeiraApi.Repository.Interfaces;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;

// Criação do WebApplicationBuilder para configurar a aplicação
var builder = WebApplication.CreateBuilder(args);




// Adiciona serviços ao contêiner de injeção de dependência

// Registra o serviço de email no contêiner como uma implementação de IEmailService
builder.Services.AddScoped<IEmailService, EmailService>();




// Configurações do banco de dados

// Define a versão do servidor MySQL a ser utilizada
var serverVersion = new MySqlServerVersion(new Version(8, 0, 35));

// Define a string de conexão com o banco de dados
var connectionString = "Server=localhost;Port=3306;Database=Consultorio;Uid=root;Pwd=14589632";

// Configura o contexto do banco de dados para usar MySQL com as opções especificadas
builder.Services.AddDbContext<ConsultorioContext>(options =>
{
    options.UseMySql(connectionString, serverVersion,
    Assembly => Assembly.MigrationsAssembly(typeof (ConsultorioContext).Assembly.FullName)
    );
});





builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IBaseRepository, BaseRepository>();
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();








// Adiciona suporte para controllers à aplicação
builder.Services.AddControllers().AddNewtonsoftJson(options => {
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

// Adiciona suporte para o explorador de API do Swagger
builder.Services.AddEndpointsApiExplorer();

// Configura o gerador de Swagger
builder.Services.AddSwaggerGen();

// Constrói a aplicação com as configurações definidas
var app = builder.Build();



// Configura o pipeline de solicitação HTTP

// Se a aplicação estiver em modo de desenvolvimento, habilita o Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configura a autorização
app.UseAuthorization();

// Mapeia os endpoints dos controllers na aplicação
app.MapControllers();

// Inicia a execução da aplicação
app.Run();
