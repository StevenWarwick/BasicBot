using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using CalendarQuickstart;

namespace BasicBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        
        [Command("test")]
        public async Task Ping()
        {
            await ReplyAsync("Connected");
        }
        [Command("CalTest")]
        public async Task CalStart()
        {
            await ReplyAsync(CalendarQuickstart.CalendarEvents.Calender());
        }
    }
}
