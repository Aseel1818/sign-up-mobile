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
    public partial class CoachPage : ContentPage
    {
        public CoachPage()
        {
            InitializeComponent();
            BindingContext = new CoachesModelView();
        }
    }
}