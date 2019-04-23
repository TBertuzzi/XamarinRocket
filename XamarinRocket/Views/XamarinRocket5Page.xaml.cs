using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinRocket.ViewModel;

namespace XamarinRocket.Views
{
    public partial class XamarinRocket5Page : ContentPage
    {
        public XamarinRocket5Page()
        {
            InitializeComponent();

            this.BindingContext = new XamarinRocket5ViewModel();
        }
    }
}
