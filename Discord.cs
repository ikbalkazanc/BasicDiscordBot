using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp7.Commands;
using ConsoleApp7.Service;
using ConsoleApp7.Service.Contract;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp7
{
    public class Discord : IHostedService
    {
        private static DiscordClient _discord;
        private IServiceProvider _services;
        private IMessageResponseService _response;

        public Discord(IServiceProvider services, DiscordClient discord, IMessageResponseService response)
        {
            _services = services;
            _discord = discord;
            _response = response;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var commands = _discord.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { "!" },
                Services = _services
            });

            commands.RegisterCommands<IdentityModule>();

            _discord.MessageCreated += async (s, e) =>
            {
                if (e.Message.Content.ToLower().StartsWith("ping")) // OF
                {
                    var photo = new DiscordEmbedBuilder()
                    {
                        Title = "Some title",
                        Description = "Some description",
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-KCu3THpGs7pHvAuZjALz6FcwdYkcyjk-zQ&usqp=CAU" //or some other random image url
                    };

                    await e.Message.RespondAsync(photo);
                }

                if (!e.Author.IsBot && !e.Message.Content.StartsWith("!"))
                {
                    _response.Check(e);
                }
            };

            await _discord.ConnectAsync();
            await Task.Delay(-1);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}