using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Msg { get; set; }
        public LayoutOptions Align { get; set; }
        public DateTime Date { get; set; }
        public Color BgColor { get; set; }
    }
}