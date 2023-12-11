using RestaurantBeheerWeb4BL.Interfaces;
using RestaurantBeheerWeb4BL.Services;
using RestaurantBeheerWeb4DL.Repositories;

namespace RestaurantBeheerWeb4REST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = @"Data Source=DONPATEL\SQLEXPRESS;Initial Catalog=RestaurantBeheerWeb4;Integrated Security=True;Trust Server Certificate=True";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddSingleton<IGebruikerRepository>(r => new GebruikerRepository(connectionString));
            builder.Services.AddSingleton<IReservatieRepository>(r => new ReservatieRepository(connectionString));
            builder.Services.AddSingleton<IRestaurantRepository>(r => new RestaurantRepository(connectionString));
            builder.Services.AddSingleton<GebruikerService>();
            builder.Services.AddSingleton<ReservatieService>();
            builder.Services.AddSingleton<RestaurantService>();
            builder.Services.AddControllers();

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
        }
    }
}
