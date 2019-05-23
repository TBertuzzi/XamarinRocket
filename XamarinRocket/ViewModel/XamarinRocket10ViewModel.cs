using System;
using Xamarin.Forms;

namespace XamarinRocket.ViewModel
{

    public class XamarinRocket10ViewModel : BaseViewModel
    {
    
        private DateTime _dateTime;
        public DateTime DateTime
        {
            get => _dateTime;
            set => SetProperty(ref _dateTime, value);
        }

        public XamarinRocket10ViewModel()
        {
            this.DateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.DateTime = DateTime.Now;
                return true;
            });
        }
         
    }
}
