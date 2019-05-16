using System;
using System.Collections.ObjectModel;
using XamarinRocket.Models;

namespace XamarinRocket.ViewModel
{
    public class XamarinRocket9ViewModel : BaseViewModel
    {
        public ObservableCollection<User> Users { get; }

        public XamarinRocket9ViewModel()
        {

            Users = new ObservableCollection<User>();
            User user;

            for (int i = 0; i < 300; i++)
            {
                user = new User
                {
                    Name = $"Nome {i}"
                };
                Users.Add(user);
            }

        }

    }
}
