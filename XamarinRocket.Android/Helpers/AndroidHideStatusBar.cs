using System;
using Xamarin.Forms;
using Plugin.CurrentActivity;
using XamarinRocket.Droid.Helpers;
using XamarinRocket.Helpers;
using Android.Views;
using Android.App;

[assembly: Dependency(typeof(AndroidHideStatusBar))]
namespace XamarinRocket.Droid.Helpers
{
    public class AndroidHideStatusBar : IAndroidHideStatusBar
    {
        WindowManagerFlags _originalFlags;

        public void HideStatusBar(bool hide)
        {
            var activity = (Activity)MainApplication.ActivityContext; ;
            var attrs = activity.Window.Attributes;

            if (hide)
            {
                _originalFlags = attrs.Flags;
                attrs.Flags |= Android.Views.WindowManagerFlags.Fullscreen;
                activity.Window.Attributes = attrs;
            }
            else
            {
                attrs.Flags = _originalFlags;
                activity.Window.Attributes = attrs;
            }
        }

    }
}


