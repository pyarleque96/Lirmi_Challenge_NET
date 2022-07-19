using Lirmi.Challenge.API.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    //Register all context
    builder.Services.RegisterContext(configuration);

    //Register all services, commands and queries in the collection services
    builder.Services.RegisterCommands();
    builder.Services.RegisterQueries();
    builder.Services.RegisterServices();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseCors(builder =>
    {
        builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });

    app.UseAuthorization();

    app.MapControllers();
}

app.Run();
