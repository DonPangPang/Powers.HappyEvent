using Microsoft.EntityFrameworkCore;
using Powers.HappyEvent.WebApi.Data;
using Powers.HappyEvent.WebApi.Extensions;
using Powers.HappyEvent.WebApi.Manager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HappyEventDbContext>(opts =>
{
    opts.UseSqlite("HappyEvent.db");
});

builder.Services.AddSession();

builder.Services.AddSingleton<SessionManagerService>();

builder.Services.AddCors(opts =>
{
    opts.AddPolicy("Any", builder =>
    {
        builder.AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSession();

app.UseCors("Any");
app.UseEntity();

app.UseAuthorization();

app.MapControllers();

app.Run();
