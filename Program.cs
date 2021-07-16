using System;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using ConsoleApp7.Commands;
using ConsoleApp7.JobService;
using ConsoleApp7.Service;
using ConsoleApp7.Service.Contract;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp7
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            host.Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(services => services.AddAutofac())
                .ConfigureServices((_, services) =>
                {
                    services.AddMemoryCache();
                    services.AddHostedService<Discord>();
                    //services.AddHostedService<CivilianCatchJobService>();
                    services.AddScoped<IIdentityService, IdentityService>();
                    services.AddScoped<IMessageResponseService, MessageResponseService>();
                    services.AddSingleton<DiscordClient>(x => new DiscordClient(new DiscordConfiguration
                    {
                        Token = "TOKEN",
                        TokenType = TokenType.Bot,
                        Intents = DiscordIntents.AllUnprivileged
                    }));
                });
    }
}