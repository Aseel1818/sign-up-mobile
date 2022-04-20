using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App52.ModelView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App52.Services;

namespace App52.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageview : ContentPage
    {



        public HomePageview()
        {
            InitializeComponent();

            listBox1.ItemsSource = new HomePageModelView().Coaches;
            

        }


        private async void Button_Clicked(object sender, EventArgs e)
        {


            App.Current.MainPage = new Calender();




        }


        private void Calender_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Calender();


        }

        private void ButtonHome_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePageview();


        }

    }
}