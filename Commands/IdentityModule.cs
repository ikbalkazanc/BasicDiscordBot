using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7.Service;
using ConsoleApp7.Service.Contract;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using Microsoft.Extensions.Caching.Memory;

namespace ConsoleApp7.Commands
{
    public class IdentityModule : BaseCommandModule
    {
        private IIdentityService _identity;

        public IdentityModule(IIdentityService identity)
        {
            _identity = identity;
        }

        [Command("kimlik")]
        public async Task GiveIdentity(CommandContext ctx)
        {
            _identity.GiveIdentity(ctx);
        }
    }
}