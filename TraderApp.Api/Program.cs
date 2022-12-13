using TraderApp.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISecuritiesRepositories, SecuritiesRepository>();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();



app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
