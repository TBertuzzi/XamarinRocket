using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinRocket.Models;
using XamarinRocket.ViewModel;

namespace XamarinRocket.Views
{
    public partial class XamarinRocket9Page : ContentPage
    {
        public XamarinRocket9Page()
        {
            InitializeComponent();

            this.BindingContext = new XamarinRocket9ViewModel();
        }

        void ListViewTapped(object sender, ItemTappedEventArgs e)
        {
            var list = sender as ListView;
            if (list == null)
                return;
            list.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lvwUsers.ItemTapped += ListViewTapped;

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            lvwUsers.ItemTapped -= ListViewTapped;
        }

        private int _lastItemAppearedIdx = 0;

        private void ListView_OnItemDisappearing(object sender, ItemVisibilityEventArgs e)
        {
            if (e.Item is User item)
            {
                var currentIdx = ((XamarinRocket9ViewModel)this.BindingContext).Users.IndexOf(item);
                if (currentIdx > _lastItemAppearedIdx)
                {
                    lblTexto.IsVisible = true;
                }
                else
                {
                    lblTexto.IsVisible = false;
                }
                _lastItemAppearedIdx = currentIdx;
            }
        }
    }
}
