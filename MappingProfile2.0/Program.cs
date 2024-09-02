using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using Newtonsoft;
using System.Text.Json;


namespace Markiian
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var host = CreateHostBuilder(args).Build();
            var mapper = host.Services.GetRequiredService<IMapper>();

            Employee emp = new Employee()
            {
                Name = "Markiian",
                LastName = "Pytel",
                Age = 21,
                Position = "Treni",
                Selery = 300
            };

            EmployeeDTO empDTO = mapper.Map<EmployeeDTO>(emp);
            string jsonString = JsonSerializer.Serialize(empDTO);

            Console.WriteLine(jsonString);
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddAutoMapper(typeof(Program).Assembly));
    }
}
