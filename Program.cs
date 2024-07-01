using CargoCarApi.Data;
using CargoCarApi.Services;
using Microsoft.EntityFrameworkCore;

namespace CargoCarApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            // Swagger/OpenAPI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<RegistrationService>();

            builder.Services.AddDbContext<PostgreSqlDbContext>(
                options =>
                {
                    options.UseNpgsql(
                        builder.Configuration.GetConnectionString("PostgreCon"));
                });

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
