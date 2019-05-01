using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinRocket.Views.Gestos
{
    public partial class SwipeGesturePage : ContentPage
    {
        public SwipeGesturePage()
        {
            InitializeComponent();
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            _label.Text = $"Você moveu para: {e.Direction.ToString()}";
        }
    }
}
