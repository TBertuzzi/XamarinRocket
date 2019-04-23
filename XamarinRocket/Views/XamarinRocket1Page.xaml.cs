using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinRocket.ViewModel;

namespace XamarinRocket.Views
{
    public partial class XamarinRocket1Page : ContentPage
    {
        public XamarinRocket1Page()
        {
            InitializeComponent();

            this.BindingContext = new XamarinRocket1ViewModel();
        }
    }
}
