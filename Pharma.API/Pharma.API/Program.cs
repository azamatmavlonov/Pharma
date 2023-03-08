using Microsoft.EntityFrameworkCore;
using Pharma.Application.Common.Interfaces;
using Pharma.Application.Common.Interfaces.Repositories;
using Pharma.Application.Services;
using Pharma.Infrastructure.Persistence.Database;
using Pharma.Infrastructure.Persistence.Repositories;

namespace Pharma.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IMedicamentService, MedicamentService>();
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            builder.Services.AddDbContext<EFContext>(options => 
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("Npgsql"));    

            }, ServiceLifetime.Scoped);

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
        }
    }
}