using CRUD_ONION_API.Domain.Data;
using CRUD_ONION_API.Repository.Inteface;
using CRUD_ONION_API.Repository;
using CRUD_ONION_API.Service.Interface;
using Microsoft.EntityFrameworkCore;
using CRUD_ONION_API.Domain.Models;
using CRUD_ONION_API.Service.CustomServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConnectionString));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Service Injected
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICustomService<Empresas>, EmpresaService>();
builder.Services.AddScoped<ICustomService<Colaboradores>, ColaboradorService>();
#endregion

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
