using APIProje.WebApi.Context;
using APIProje.WebApi.Entities;
using APIProje.WebApi.ValidationRules;
using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<APIContext>();
builder.Services.AddAutoMapper(cfg => { }, typeof(Program));
builder.Services.AddScoped<IValidator<Product>, ProductValidator>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
