using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinRocket.Helpers;

namespace XamarinRocket.Views
{
    public partial class XamarinRocket3Page : ContentPage
    {
        public XamarinRocket3Page()
        {
            InitializeComponent();

            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.Android)
            {
                Xamarin.Forms.DependencyService.Get<IAndroidHideStatusBar>().HideStatusBar(true);
            }
        }
    }
}
