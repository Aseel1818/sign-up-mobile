using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using explore.model;
using explore.services;
using MvvmHelpers;
using Firebase.Database;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace explore.modelview
{
    public class exploremodelview : BaseViewModel

    {

        public string FistName{ get;set;}
        
        public string LastName{get;set; }
        
        public int coachAge{get;set; }

        public string Course { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }






        private DB Services;
        public Command AddCoachesCommand { get; }

        private ObservableCollection<Coaches> _coaches = new ObservableCollection<Coaches>();

        public ObservableCollection<Coaches> Coaches
        {
            get { return _coaches; }
            set
            {
                _coaches = value;
                OnPropertyChanged();
            }
        }

        public exploremodelview()
        {
            Services = new DB();
            Coaches = Services.getCoach();
            AddCoachesCommand = new Command(async () => await AddCoachAsync(FistName, LastName,  Course, Location, Phone));
        }
        private async Task AddCoachAsync(string fistName, string lastName, string course , string location, string phone)
        {
            await Services.AddCoach(fistName, lastName,course , location,phone);
        }
    }
}









