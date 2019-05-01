using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinRocket.Views.Gestos
{
    public partial class TapGesturePage : ContentPage
    {

        int tapCount;
        public TapGesturePage()
        {
            InitializeComponent();
        }

        public void Image_Tapped(object sender, EventArgs e)
        {
            tapCount++;
            lblTapedCount.Text = String.Format("{0} tap{1}",
                tapCount,
                tapCount == 1 ? "" : "s");
        }
    }
}
