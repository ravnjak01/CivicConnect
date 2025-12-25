using CivicConnect.Services;           // Dodato: prostor gde je IssueService
using CivicConnect.Services.Interfaces; // Vaš postoje?i using

var builder = WebApplication.CreateBuilder(args);

// 1. Dodavanje servisa u kontejner
builder.Services.AddControllers(); // Dodato: neophodno za rad API kontrolera
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registracija vašeg servisa

var app = builder.Build();

// 2. Konfiguracija HTTP pipeline-a
if (app.Environment.IsDevelopment())
{
    // Ispravljeno: Standardne metode za Swagger u .NET 7/8
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 3. Dodato: Mapiranje kontrolera i pokretanje
app.UseAuthorization();
app.MapControllers();

app.Run();