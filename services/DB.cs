using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using explore.model;
using Firebase.Database;
using Firebase.Database.Query;
namespace explore.services
{
    public class DB
    {
        FirebaseClient client;

        public DB()
        {
            client = new FirebaseClient("https://my-coach-9875d-default-rtdb.firebaseio.com/");

        }
        public ObservableCollection<Coaches> getCoach()
        {
            var CoachData = client.Child("Coach").AsObservable<Coaches>().AsObservableCollection();

            return CoachData;
        }

        public async Task AddCoach(string fname, string lname, string  course ,string location ,string phone)
        {
            Coaches c = new Coaches() { FistName = fname, LastName = lname,  Course = course , Location=location , Phone=phone};
            await client.Child("Coach").PostAsync(c);
        }


    }
}
