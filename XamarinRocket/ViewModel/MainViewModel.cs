using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace XamarinRocket.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion


        public string TextoGrande
        {
            get => "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
            	" Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
            	" when an unknown printer took a galley of type and scrambled it to make a type" +
            	"specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, " +
            	"remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
            	"and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

        }


        public MainViewModel()
        {
           


        }


    }

}
