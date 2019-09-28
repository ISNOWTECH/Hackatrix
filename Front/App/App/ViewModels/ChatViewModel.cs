using App.Models;
using App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class ChatViewModel:BaseViewModel
    {
        private readonly IService service;

        public ObservableCollection<Message> Messages { get; set; }
        public ICommand RefreshMessages { get; set; }
        public ChatViewModel(IService service)
        {
            this.service = service;
            RefreshMessages = new Command(async () => await SyncMessages());
            Device.StartTimer(TimeSpan.FromMilliseconds(200), () => 
            {
                RefreshMessages.Execute(null);
                return true;
            }

            );
        }
        private async Task SyncMessages()
        {
            var msgs = await service.GetMessages();
            foreach(var item in msgs)
            {
                if (!Messages.Contains(item))
                {
                    if (item.Sender.Equals("Driver"))
                    {
                        item.Align = LayoutOptions.Start;
                        item.BgColor = Color.LightBlue;
                    }
                    else if (item.Sender.Equals("User"))
                    {
                        item.Align = LayoutOptions.End;
                        item.BgColor = Color.LightGreen;
                    }
                    Messages.Add(item);
                }
            }
        }
    }
}
