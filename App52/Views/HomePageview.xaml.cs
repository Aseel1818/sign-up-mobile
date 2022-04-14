using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App52.ModelView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App52.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageview : ContentPage
    {
        public HomePageview()
        {
            InitializeComponent();
            BindingContext = new HomePageModelView();
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Details();


        }

        private void ButtonHome_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePageview();


        }

    }
}