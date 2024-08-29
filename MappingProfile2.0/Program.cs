using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Markiian
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var mapper = host.Services.GetRequiredService<IMapper>();

            Empoyee emp = new Empoyee()
            {
                Name = "Markiian",
                LastName = "Pytel",
                Age = 21,
                Position = "Treni",
                Selery = 300
            };

            EmployeeDTO empDTO = new EmployeeDTO()
            {
                IdPerosne = Guid.NewGuid(),
                Company = "Epam",
                BirthDay = new DateTime(2003, 1, 16),
                Spetialization = "Embeded",
                AverageSelery = 0,
            };

            Console.WriteLine($"IdPerosne: {empDTO.IdPerosne}\nCompany: {empDTO.Company}\nBirthDay: {empDTO.BirthDay.ToShortDateString()}\nBestPosition: {empDTO.Spetialization}\nAverageSelery: {empDTO.AverageSelery}");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddAutoMapper(typeof(Program));
                    services.AddTransient<MappingProfile>();
                });
    }
}