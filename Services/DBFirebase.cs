using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using App52.Model;
using Firebase.Database;
using Firebase.Database.Query;
namespace App52.Services
{
    public class DBFirebase
    {
        FirebaseClient client;

        public DBFirebase()
        {
            client = new FirebaseClient("https://my-coach-9875d-default-rtdb.firebaseio.com/");

        }
        public ObservableCollection<Coach> getCoach()
        {
            var CoachData = client.Child("Coach").AsObservable<Coach>().AsObservableCollection();
            return CoachData;
        }

            public async Task AddCoach(string firstName,string lastName , int age)
        {
            Coach c=new Coach() { FirstName= firstName, LastName = lastName, Age = age };
            await client.Child("Coach").PostAsync(c);
        }

    }
}
