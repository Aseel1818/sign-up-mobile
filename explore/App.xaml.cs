using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using explore.view;

namespace explore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new explore2();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
