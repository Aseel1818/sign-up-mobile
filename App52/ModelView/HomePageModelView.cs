using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App52.Model;
using App52.Services;
using MvvmHelpers;
using Firebase.Database;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using App52.Views;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using SolrNet.Utils;

namespace App52.ModelView
{
    public class HomePageModelView : BaseViewModel

    {

        public string EndTime1 { get; set; }
        public string EndTime2 { get; set; }
        public string EndTime3 { get; set; }
        public string Date { get; set; }

        public string title1 { get; set; }
        public string title2 { get; set; }
        public string title3 { get; set; }

        public int id1 { get; set; }
        public int id2 { get; set; }
        public int id3 { get; set; }

        public string StartTime1 { get; set; }

        public string StartTime2 { get; set; }
        public string StartTime3 { get; set; }



    
        private DBFirebase services;
        public Command AddCoachesCommand { get; }

        private ObservableCollection<HomePage> _coaches = new ObservableCollection<HomePage>();

      

        public ObservableCollection<HomePage> Coaches
        {
            get {
                

                return _coaches;
                 }
            set
            {
                _coaches = value;
                OnPropertyChanged();
            }
        }



        public HomePageModelView()
        {

         

            services = new DBFirebase();
            Coaches = services.getCoach();
            
            AddCoachesCommand = new Command(async () => await AddCoachAsync(  Date,  id1,   StartTime1,  EndTime1,title1, id2, StartTime2, EndTime2, title2, id3,StartTime3, EndTime3, title3));

        }


        private async Task AddCoachAsync(  string  date,int Id1,string  startTime1,string endTime1,string Title1,int Id2,string startTime2,string endTime2,string Title2, int  Id3,string startTime3,string endTime3,string Title3)
        {
            await services.AddCoach( date,  Id1,  startTime1,  endTime1,  Title1, Id2, startTime2,  endTime2,  Title2,  Id3,  startTime3,  endTime3,  Title3);
        }
    }
}

    

        





