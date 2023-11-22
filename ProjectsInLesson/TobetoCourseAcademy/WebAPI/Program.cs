using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstracts;
using Business.Concretes;
using Business.DependencyResolvers.Autofac;
using Business.Mapping;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutofacBusinessModule());
                });

builder.Services.AddDbContext<TobetoCourseAcademyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));



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
