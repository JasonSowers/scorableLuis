using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Scorable.Dialogs
{
    [Serializable]
    [LuisModel("Luis app id", "Luis key")]
    public class LuisDialog : LuisDialog<object>
    {


        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string message = $"Sorry, I did not understand '{result.Query}'. Type 'help' if you need assistance.";

            await context.PostAsync(message);

            context.Wait(this.MessageReceived);
        }

        [LuisIntent("greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            string message = $"Hello there";

            await context.PostAsync(message);

            context.Wait(this.MessageReceived);
        }

        private ResumeAfter<object> after()
        {
            return null;
        }

        [LuisIntent("left")]
        public async Task Left(IDialogContext context, LuisResult result)
        {
            string message = $"Left";

            await context.PostAsync(message);

            context.Wait(this.MessageReceived);
        }
        [LuisIntent("right")]
        public async Task Right(IDialogContext context, LuisResult result)
        {
            string message = $"right";

            await context.PostAsync(message);

            context.Wait(this.MessageReceived);
        }
        [LuisIntent("middle")]
        public async Task Middle(IDialogContext context, LuisResult result)
        {
            string message = $"middle";

            await context.PostAsync(message);

            context.Wait(this.MessageReceived);
        }
    }
}