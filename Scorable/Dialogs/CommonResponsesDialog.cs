using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;

namespace Scorable.Dialogs
{


    public class CommonResponsesDialog : IDialog<object>
    {
        private readonly string _messageToSend;

        public CommonResponsesDialog(string message)
        {
            _messageToSend = message;
        }

        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync(_messageToSend);
            context.Done<object>(null);
        }
    }
}