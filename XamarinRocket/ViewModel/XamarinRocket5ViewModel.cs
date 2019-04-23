using System;
namespace XamarinRocket.ViewModel
{
    public class XamarinRocket5ViewModel : BaseViewModel
    {
        private bool _isNotConnected;
        public bool IsNotConnected
        {
            get => _isNotConnected;
            set => SetProperty(ref _isNotConnected, value);
        }


        public XamarinRocket5ViewModel()
        {

            //Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            //IsNotConnected = Connectivity.NetworkAccess != NetworkAccess.Internet;

        }

        //~MainViewModel()
        //{
        //    Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
        //}

        //void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        //{
        //    IsNotConnected = e.NetworkAccess != NetworkAccess.Internet;
        //}
    }
}
