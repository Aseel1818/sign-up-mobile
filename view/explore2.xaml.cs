using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using explore.modelview;
using Xamarin.Forms;
using explore.model;
using Xamarin.Forms.Xaml;

namespace explore.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class explore2 : ContentPage
    {          

        public explore2()
        {
            InitializeComponent();
            BindingContext = new exploremodelview();

        }



        private  void NavigateButton_OnClicked(object sender, EventArgs e)
        {

            App.Current.MainPage = new SearchPage();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            App.Current.MainPage = new Profile();

         
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Cources")
            {
                vBox.Color = Color.Silver;
                pBox.Color = Color.FromHex("#FFA500");
                listView.IsVisible = false;
            }
            else
            {
                listView.IsVisible = true;

                

                vBox.Color = Color.FromHex("#FFA500");
                pBox.Color = Color.Silver;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}