using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinRocket.Helpers;
using XamarinRocket.ViewModel;
using XamarinRocket.Views;

namespace XamarinRocket
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();

           
        }

        public async void Rocket1_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket1Page());
        }

        public async void Rocket2_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket2Page());
        }

        public async void Rocket3_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket3Page());
        }

        public async void Rocket4_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket4Page());
        }

        public async void Rocket5_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket5Page());
        }

        public async void Rocket6_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket6Page());
        }

        public async void Rocket7_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket7Page());
        }

        public async void Rocket8_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket8Page());
        }

        public async void Rocket9_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket9Page());
        }

        public async void Rocket10_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new XamarinRocket10Page());
        }


    }
}
