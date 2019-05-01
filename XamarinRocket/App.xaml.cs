using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinRocket
{
    public partial class App : Application
    {
        public static double ScreenWidth;
        public static double ScreenHeight;

        public App()
        {
            InitializeComponent();

             Connectivity.ConnectivityChanged += ConnectivityChanged;

            MainPage = new NavigationPage( new MainPage());
        }

        private void ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess != NetworkAccess.Internet)
            {
                Application.Current.MainPage.DisplayAlert("Atenção", "Estamos sem internet :(", "OK");
            }
            
        }
    }
}
