using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp7;
using DSharpPlus.Entities;

namespace ConsoleApp7.Service
{
    public partial class IdentityService
    {
        private string GetIdentityRequestMessage(DiscordUser member)
        {
            Random random = new Random();
            if (member.Id == Variables.TargetIds[0])
                return string.Format(
                    Variables.BotMessage.IdentityRequestMessagesForSakat[
                        random.Next(0, Variables.BotMessage.IdentityRequestMessagesForSakat.Length)], member.Id.ToString());
            else if (member.Id == Variables.TargetIds[1])
                return string.Format(
                    Variables.BotMessage.IdentityRequestMessagesForKurd[
                        random.Next(0, Variables.BotMessage.IdentityRequestMessagesForKurd.Length)], member.Id.ToString());
            else
                return string.Format(
                    Variables.BotMessage.IdentityRequestMessages[
                        random.Next(0, Variables.BotMessage.IdentityRequestMessages.Length)], member.Id.ToString());
        }

        private string GetDidIRequestYourIdentityMessage(DiscordUser member)
        {
            Random random = new Random();
            if (member.Id == Variables.TargetIds[0])
                return string.Format(
                    Variables.BotMessage.DidIRequestYourIdentityForSakat[
                        random.Next(0, Variables.BotMessage.DidIRequestYourIdentityForSakat.Length)], member.Id.ToString());
            else if (member.Id == Variables.TargetIds[1])
                return string.Format(
                    Variables.BotMessage.DidIRequestYourIdentityForKurd[
                        random.Next(0, Variables.BotMessage.DidIRequestYourIdentityForKurd.Length)], member.Id.ToString());
            else
                return string.Format(
                    Variables.BotMessage.DidIRequestYourIdentity[
                        random.Next(0, Variables.BotMessage.DidIRequestYourIdentity.Length)], member.Id.ToString());
        }

        private string GetOkayYouCanGoAwayMessage(DiscordUser member)
        {
            Random random = new Random();
            if (member.Id == Variables.TargetIds[0])
                return string.Format(
                    Variables.BotMessage.OkayYouCanGoAwayForSakat[
                        random.Next(0, Variables.BotMessage.OkayYouCanGoAwayForSakat.Length)], member.Id.ToString());
            else if (member.Id == Variables.TargetIds[1])
                return string.Format(
                    Variables.BotMessage.OkayYouCanGoAwayForKurd[
                        random.Next(0, Variables.BotMessage.OkayYouCanGoAwayForKurd.Length)], member.Id.ToString());
            else
                return string.Format(
                    Variables.BotMessage.OkayYouCanGoAway[
                        random.Next(0, Variables.BotMessage.OkayYouCanGoAway.Length)], member.Id.ToString());
        }
    }
}