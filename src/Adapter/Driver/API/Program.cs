using Application.Mappers;
using Application.UseCases;
using Domain.Repositories;
using HealthChecks.UI.Client;
using Infra.DbContexts;
using Infra.Repositories;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(UsuarioProfile).Assembly);

var connectionString = builder.Configuration.GetSection("DatabaseSettings:ConnectionString").Value;
if (!string.IsNullOrEmpty(connectionString))
{
    builder.Services.AddHealthChecks()
        .AddNpgSql(connectionString,
                name: "postgresSQL", tags: new string[] { "db", "data" });
    
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(connectionString));
}

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserUseCase, UserUseCase>();

builder.Services.AddHealthChecksUI(opt =>
{
    opt.SetEvaluationTimeInSeconds(15);
    opt.MaximumHistoryEntriesPerEndpoint(60);
    opt.SetApiMaxActiveRequests(1);
    opt.AddHealthCheckEndpoint("API", "http://localhost:8000/health"); // TODO: Remove hard coded url
}).AddInMemoryStorage();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // api-docs is the default route for the swagger endpoint
    app.UseReDoc(c => {
        c.DocumentTitle = "API Documentation";
        c.SpecUrl = "/swagger/v1/swagger.json";
    });
}

app.UseHttpsRedirection();

app.UseHealthChecks("/health", new HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
}).UseHealthChecksUI(h => h.UIPath = "/health-ui");

app.UseAuthorization();

app.MapControllers();

app.Run();
