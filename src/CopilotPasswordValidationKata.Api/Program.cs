var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/health", () =>
{
    return new HealthResponse { Status = "ok" };
})
.WithName("GetHealth");

app.Run();

public record HealthResponse
{
    public string Status { get; init; } = string.Empty;
}

public partial class Program { }
