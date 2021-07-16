using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;

namespace ConsoleApp7.Service.Contract
{
    public interface IIdentityService
    {
        Task RequestIdentity(MessageCreateEventArgs message, double rate = 1);

        Task RequestIdentity(DiscordUser user);

        Task GiveIdentity(CommandContext ctx);
    };
}