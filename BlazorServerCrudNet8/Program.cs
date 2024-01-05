using BlazorServerCrudNet8.Components;
using BlazorServerCrudNet8.Data;
using BlazorServerCrudNet8.Services;
using BlazorServerCrudNet8.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

const string nameString = "nombreConexion";
var nameconfig = builder.Configuration.GetConnectionString(nameString);

//Servicios Agregados
builder.Services.AddDbContext<DataContext>(opc => opc.UseSqlServer(nameconfig));

builder.Services.AddScoped<IVideoGameService, VideoGameService>();


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
