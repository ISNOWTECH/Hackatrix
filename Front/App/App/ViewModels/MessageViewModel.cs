using App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class MessageViewModel:BaseViewModel
    {

        public MessageViewModel(string message, LayoutOptions TextAlign)
        {
            Message = new Message { Msg = message, Date = DateTime.Now };
            TextOrientation = TextAlign;
        }

        private Message message;

        public Message Message
        {
            get => message; 
            set { SetProperty(ref (message), value); }
        }


        private LayoutOptions textAlign;

        public LayoutOptions TextOrientation
        {
            get => textAlign;
            set { SetProperty(ref (textAlign), value); }
        }


    }
}
