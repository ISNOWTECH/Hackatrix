using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;

namespace App.Services
{
    public class Service:IService
    {
        FirebaseClient Firebase;
        public Service()
        {
            var options = new FirebaseOptions();
            
            //Firebase = new FirebaseClient("https://pec-app-a05b3.firebaseio.com", options);
        }

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

        private FirebaseAuth LoadFirebaseAuth()
        {
            string json = Settings.FirebaseAuthJson;
            if (string.IsNullOrEmpty(json))
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<FirebaseAuth>(json);
            }
        }

    }
}
