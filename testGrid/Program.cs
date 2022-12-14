using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using testGrid.Data;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<WeatherForecastServiceSecond>();
builder.Services.AddSingleton<WeatherForecastServiceUpdate>();
builder.Services.AddSingleton<ProjectService>();
builder.Services.AddSingleton<PassengerService>();


builder.Services.AddMudServices();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
