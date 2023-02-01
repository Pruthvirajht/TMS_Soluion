using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
//using TMS_CRS.Models;
using Microsoft.EntityFrameworkCore;
//using TMS_CRS.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddDbContext<TmsDatabaseContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));
//builder.Services.AddTransient<ITrafficPoliceRepository, TrafficPoliceRepository>();
//builder.Services.AddTransient<IRTORepository, RTORepository>();
//builder.Services.AddTransient<ITrafficPoliceRepository, TrafficPoliceRepository>();
//builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddRazorPages();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
