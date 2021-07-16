using System;
using System.Collections.Generic;
using System.Text;
using DSharpPlus.EventArgs;

namespace ConsoleApp7.Service.Contract
{
    public interface IMessageResponseService
    {
        bool Check(MessageCreateEventArgs message);
    }
}