using Microsoft.EntityFrameworkCore;
using Powers.HappyEvent.WebApi.Data;
using Powers.HappyEvent.WebApi.Extensions;
using Powers.HappyEvent.WebApi.Manager;
using Powers.HappyEvent.WebApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HappyEventDbContext>(opts =>
{
    opts.UseSqlite("Data Source=HappyEvent.db");
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddSingleton<SessionManagerService>();
builder.Services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));

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

app.UseAuthorization();

app.MapControllers();

//app.UseEntity();

app.Run();
