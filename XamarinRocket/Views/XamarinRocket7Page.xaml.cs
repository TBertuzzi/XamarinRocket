using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinRocket.Views.Gestos;

namespace XamarinRocket.Views
{
    public partial class XamarinRocket7Page : ContentPage
    {

        public XamarinRocket7Page()
        {
            InitializeComponent();
        }

        public async void PanGesture_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PanGesturePage());
        }

        public async void PinchGesture_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PinchGesturePage());
        }

        public async void SwipeGesture_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwipeGesturePage());
        }

        public async void TapGesture_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TapGesturePage());
        }


    }
}
