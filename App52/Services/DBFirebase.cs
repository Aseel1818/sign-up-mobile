using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using App52.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows;
namespace App52.Services
{
    public class DBFirebase
    {
        FirebaseClient client;

        public DBFirebase()
        {
            client = new FirebaseClient("https://my-coach-9875d-default-rtdb.firebaseio.com/");

        }
        public ObservableCollection<HomePage> getCoach()
        {
            var CoachData = client.Child("Time1").AsObservable<HomePage>().AsObservableCollection();
            


            return CoachData;



        }

       

        public async Task AddCoach(string date,int Id1, string startTime1,string endTime1, string Title1, int Id2, string startTime2, string endTime2, string Title2, int Id3, string startTime3, string endTime3, string Title3 )
        {
            HomePage c=new HomePage() { EndTime1 = endTime1, EndTime2=endTime2, EndTime3= endTime3, Date=date,id1=Id1,id2=Id2,id3=Id3,StartTime1=startTime1,StartTime2=startTime2,StartTime3=startTime3,title1=Title1,title2=Title2,title3=Title3};
            await client.Child("Time1").PostAsync(c);
        }

    }
}
