using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;
using Firebase.Database;
using Firebase.Database.Query;

namespace App.Services
{
    public class Service:IService
    {
        FirebaseClient Firebase = new FirebaseClient("");

        public async Task<List<Message>> GetMessages()
        {
            return (await Firebase
             .Child("Persons")
             .OnceAsync<Message>()).Select(item => new Message
             {
                 Id = item.Object.Id,
                 Msg = item.Object.Msg,
                 Date = item.Object.Date
             }).ToList();
        }
    }
}
