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

namespace App52.ModelView
{
    public class HomePageModelView : BaseViewModel

    {

        public string Time { get; set; }
        public string Date { get; set; }
        
        public string title { get; set; }

        private DBFirebase services;
        public Command AddCoachesCommand { get; }

        private ObservableCollection<HomePage> _coaches = new ObservableCollection<HomePage>();

        public ObservableCollection<HomePage> Coaches
        {
            get { return _coaches; }
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
            AddCoachesCommand = new Command(async () => await AddCoachAsync(Time,Date, title));
        }
        private async Task AddCoachAsync(string Time, string Date,string title1)
        {
            await services.AddCoach(Time,Date,title1);
        }
    }
}

    

        





