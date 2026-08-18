var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte aos Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    });
}

app.UseHttpsRedirection();

// Mapeia os Controllers
app.MapControllers();

app.Run();