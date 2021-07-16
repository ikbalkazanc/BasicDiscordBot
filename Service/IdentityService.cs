using ConsoleApp7.Extensions;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp7;
using ConsoleApp7.Service.Contract;
using DSharpPlus.CommandsNext;
using Emzi0767.Utilities;

namespace ConsoleApp7.Service
{
    public partial class IdentityService : IIdentityService
    {
        private readonly DiscordClient _discord;
        private readonly IMemoryCache _cache;

        public IdentityService(DiscordClient discord, IMemoryCache cache)
        {
            _discord = discord;
            _cache = cache;
        }

        public async Task RequestIdentity(MessageCreateEventArgs message, double rate = 1)
        {
            Random random = new Random();
            if (random.Next(0, 10) < (rate * 10))
            {
                var member = _discord.GetMember(x => x.Id == message.Author.Id);
                if (member == null)
                    return;

                var memRequested = _cache.Get<List<DiscordUser>>(Variables.CacheKey.IdentityRequestKey);
                List<DiscordUser> requested = memRequested == null
                    ? new List<DiscordUser>()
                    : memRequested;
                if (!requested.Any(x => x.Id == member.Id))
                {
                    requested.Add(member);
                }
                _cache.Set<List<DiscordUser>>(Variables.CacheKey.IdentityRequestKey, requested);

                _ = message.Message.RespondAsync(GetIdentityRequestMessage(member));
            }
        }

        public async Task RequestIdentity(DiscordUser member)
        {
            var memRequested = _cache.Get<List<DiscordUser>>(Variables.CacheKey.IdentityRequestKey);
            List<DiscordUser> requested = memRequested == null
                ? new List<DiscordUser>()
                : memRequested;
            if (!requested.Any(x => x.Id == member.Id))
            {
                requested.Add(member);
                _cache.Set<List<DiscordUser>>(Variables.CacheKey.IdentityRequestKey, requested);
                var channel = _discord.Guilds.First().Value.Channels.FirstOrDefault(x => x.Value.Name == Variables.DefaultGuild);
                if (channel.Value != null)
                    _ = _discord.SendMessageAsync(channel.Value, GetIdentityRequestMessage(member));
            }
        }

        public async Task GiveIdentity(CommandContext ctx)
        {
            var memRequested = _cache.Get<List<DiscordUser>>(Variables.CacheKey.IdentityRequestKey);
            List<DiscordUser> requested = memRequested == null
                ? new List<DiscordUser>()
                : memRequested;

            Random random = new Random();
            var requestedUser = requested.FirstOrDefault(x => x.Id == ctx.User.Id && !ctx.User.IsBot);
            if (requestedUser == null)
            {
                _ = ctx.Message.RespondAsync(GetDidIRequestYourIdentityMessage(ctx.User));
                return;
            }

            requested.Remove(requestedUser);
            _ = ctx.Message.RespondAsync(GetOkayYouCanGoAwayMessage(ctx.User));
        }
    }
}