//var builder = WebApplication.CreateBuilder(args);

//// Ajouter les services n�cessaires
//builder.Services.AddControllers();
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAllOrigins", builder =>
//    {
//        builder.AllowAnyOrigin() // Autorise toutes les origines
//               .AllowAnyMethod() // Autorise toutes les m�thodes (GET, POST, etc.)
//               .AllowAnyHeader(); // Autorise tous les en-t�tes
//    });
//});

//var app = builder.Build();

//app.UseHttpsRedirection();

//// Appliquer le middleware CORS avant les contr�leurs
//app.UseCors("AllowAllOrigins");

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

//var builder = WebApplication.CreateBuilder(args);

////Add services to the container.

//builder.Services.AddControllers();
////Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

////Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

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

// Ajouter les services Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurer Swagger
if (app.Environment.IsDevelopment()) // Active Swagger uniquement en d�veloppement
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Appliquer le middleware CORS avant les contr�leurs
app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();

