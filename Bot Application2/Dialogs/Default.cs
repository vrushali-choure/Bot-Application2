using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Bot_Application2.Dialogs
{
    [LuisModel("864b89d2-ec9a-4722-8bf2-fc832977ddab", "74c7cfca6c3144538ac0f2a21af3b1d3")]
    [Serializable]
    public class Default: LuisDialog<object>
    {

        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Sorry, I don't know what you wanted.");
            context.Wait(MessageReceived);
        }
        [LuisIntent("Greetings")]
        public async Task Greetings(IDialogContext context, LuisResult result)
        {


            //var msg =  await result.ToString() ;
            //if( msg.Equals("hi"))
            //{
            //    await context.PostAsync("hello");
            //    context.Wait(MessageReceived);
            //}
            //else { 
            await context.PostAsync("hi,Good morning ");
            await context.PostAsync("How can i help you?");
            context.Wait(MessageReceived);
        //}
        }
        [LuisIntent("joining")]
        public async Task joining(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Your joining date is 1st January 2017.");
            context.Wait(MessageReceived);
        }
        [LuisIntent("Salary_increment")]
        public async Task Salary_increment(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("You will get increment after 12 month and will be based on your performance.");
            context.Wait(MessageReceived);
        }
        [LuisIntent("Pf_number")]
        public async Task Pf_number(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Its pf1200");
            context.Wait(MessageReceived);
        }
        [LuisIntent("Change_number")]
        public async Task Change_number(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Enter new contact number");
            context.Wait(MessageReceived);
        }
        [LuisIntent("Change_address")]
        public async Task Change_address(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Enter new address");
            context.Wait(MessageReceived);
        }
        //public async Task MessageReceivedChange(IDialogContext context, LuisResult result)
        //{

        //    await context.PostAsync("ok it will be changed");
        //    context.Wait(MessageReceived);
        //}

    }
}