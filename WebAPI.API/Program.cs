using Microsoft.EntityFrameworkCore;
using WebAPI.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options=>
options.AddPolicy("batteryApp", builder=>
builder.WithOrigins("https://localhost:7269", "https://localhost:4200").AllowAnyMethod().AllowAnyHeader()));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("batteryApp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
