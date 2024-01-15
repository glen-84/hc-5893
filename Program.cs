using hc_5893.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=postgres;Pooling=true")
        .EnableSensitiveDataLogging();
});

builder.Services
    .AddGraphQLServer()
    .ModifyRequestOptions(options => options.IncludeExceptionDetails = builder.Environment.IsDevelopment())
    .RegisterDbContext<AppDbContext>()
    .AddProjections()
    .AddQueryType<Query>();

// Add services to the container.

var app = builder.Build();

// Ensure database is created.
using var scope = app.Services.CreateScope();
using var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
context.Database.EnsureCreated();

// Configure the HTTP request pipeline.

app.MapGraphQL();

app.Run();

public partial class Program { }