using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSharpPlus;
using DSharpPlus.Entities;

namespace ConsoleApp7.Extensions
{
    public static class DiscordClientExtensions
    {
        public static DiscordUser? GetMember(this DiscordClient client, Func<DiscordMember, bool> predicate)
        {
            return client
                .Guilds
                .Values
                .SelectMany(g => g.Members.Values)
                .FirstOrDefault(predicate);
        }

        public static List<DiscordMember>? GetAllMembers(this DiscordClient client)
        {
            return client
                .Guilds
                .Values
                .SelectMany(g => g.Members.Values).ToList();
        }
    }
}