﻿using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    [Name("bot")]
    [RequireOwner]
    public class BotManagement : ModuleBase<SocketCommandContext>
    {
        public GuildPrefixManager GuildPrefixManager { get; set; }

        [Command("prefix")]
        [Summary("Change the bot prefix")]
        public async Task PrefixAsync(string prefix) {
            await GuildPrefixManager.SetPrefix(Context.Guild.Id, prefix);

            await Context.Channel.SendMessageAsync($"Bot prefix has been updated to '{prefix}'!");
        }
    }
}
