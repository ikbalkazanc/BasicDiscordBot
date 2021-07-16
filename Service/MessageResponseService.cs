using ConsoleApp7.Service.Contract;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7.Service
{
    public partial class MessageResponseService : IMessageResponseService
    {
        private DiscordClient _discord;
        private IIdentityService _identity;

        public MessageResponseService(DiscordClient discord, IIdentityService identity)
        {
            _discord = discord;
            _identity = identity;
        }

        public bool Check(MessageCreateEventArgs message)
        {
            var customMessage = CheckCustomMessages(message);
            if (!string.IsNullOrEmpty(customMessage))
            {
                message.Message.RespondAsync(customMessage);
                return false;
            }

            var badword = CheckBadWord(message);
            if (!string.IsNullOrEmpty(badword))
            {
                message.Message.RespondAsync(GetBadWordMessage(message.Author, badword));
                return false;
            }

            //_ = _identity.RequestIdentity(message, 0.1);

            return true;
        }

        private string CheckCustomMessages(MessageCreateEventArgs message)
        {
            var text = " " + message.Message.Content.ToLower() + " ";
            foreach (var response in Variables.Responses)
            {
                if (response.Key.Any(x => text.Contains(x)))
                {
                    return GetResponses(response.Value);
                }
            }

            return "";
        }

        private string CheckBadWord(MessageCreateEventArgs message)
        {
            var text = " " + message.Message.Content.ToLower() + " ";
            foreach (var word in Variables.BadWords)
            {
                if (text.Contains(" " + word + " "))
                {
                    return word;
                }
            }

            return "";
        }

        private string GetBadWordMessage(DiscordUser member, string badword)
        {
            Random random = new Random();

            return string.Format(
                Variables.BotMessage.BadWordResponse[
                    random.Next(0, Variables.BotMessage.BadWordResponse.Length)], member.Id.ToString(), badword);
        }

        private string GetResponses(List<string> responses)
        {
            Random random = new Random();
            return responses[random.Next(0, responses.Count)];
        }
    }
}