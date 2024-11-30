var builder = WebApplication.CreateBuilder(args);

// Ajouter les services n�cessaires
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin() // Autorise toutes les origines
               .AllowAnyMethod() // Autorise toutes les m�thodes (GET, POST, etc.)
               .AllowAnyHeader(); // Autorise tous les en-t�tes
    });
});

var app = builder.Build();

app.UseHttpsRedirection();

// Appliquer le middleware CORS avant les contr�leurs
app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
