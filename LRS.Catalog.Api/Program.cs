using LRS.Catalog.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration(builder.Configuration);
builder.Services.AddSwaggerConfiguration();
builder.Services.AddDependencyInjectionConfiguration();


var app = builder.Build();

app.UseSwaggerSetup();
app.UseApiConfiguration(app.Environment);

app.Run();
