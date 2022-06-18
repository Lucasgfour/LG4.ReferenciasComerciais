using LG4.ApplicationWeb.Interface;
using LG4.ApplicationWeb.Repository;
using LG4.ApplicationWeb.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors();

// ---- Dependency Injection --------

builder.Services.AddScoped<IReferenciaService, ReferenciaService>();
builder.Services.AddScoped<IReferenciaRepository, ReferenciaRepository>();

// ----------------------------------

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();



app.MapGet("/", () => "Hello World!");

app.Run();
