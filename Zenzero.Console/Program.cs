using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Zenzero.Core.Contracts;
using Zenzero.Core.Services;
using Zenzero.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.IO;

var host = CreateHostBuilder();
var context = host.Services.GetRequiredService<ZenzeroContext>();

static IHost CreateHostBuilder() => ConfigureServices(BuildConfiguration()).Build();

static IConfiguration BuildConfiguration() =>
    new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("settings.json", false, true)
    .Build();

static IHostBuilder ConfigureServices(IConfiguration configuration) =>
    Host.CreateDefaultBuilder()
        .ConfigureServices((_, services) => services
            .AddSingleton(configuration)
            .AddLogging()
            .AddScoped<IOrderService, OrderService>()
            .AddScoped<IOrderLineService, OrderLineService>()
            .AddDbContextPool<ZenzeroContext>(x =>
                x.UseSqlite(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Zenzero.Console"))));