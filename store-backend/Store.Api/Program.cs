var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();            // Use controller-based APIs
builder.Services.AddEndpointsApiExplorer();   // Needed for Swagger
builder.Services.AddSwaggerGen();             // Swagger generator

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();                         // Serve Swagger JSON
    app.UseSwaggerUI();                       // Serve Swagger UI at /swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();                         // Map controller routes

app.Run();
