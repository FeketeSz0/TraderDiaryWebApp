using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TraderApp.Web.Modells;
using TraderApp.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient<ISecuService, SecuService>(c =>
{
    c.BaseAddress = new Uri("https://localhost:7238/");
});
builder.Services.AddScoped<IStockService, StockService>();
builder.Services.AddAutoMapper(typeof(EditFormModel));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
