using DemoMinimalApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MinimalContextDb>();

var app = builder.Build();

app.MapGet("/fornecedor", (MinimalContextDb context) => context.Fornecedores.ToList());

app.Run();
