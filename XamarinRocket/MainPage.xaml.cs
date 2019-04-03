using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinRocket.Helpers;
using XamarinRocket.ViewModel;

namespace XamarinRocket
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();

            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.Android)
            {
                Xamarin.Forms.DependencyService.Get<IAndroidHideStatusBar>().HideStatusBar(true);
            }
        }
    }
}
