using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Essentials;
using System.Drawing;
using Android.App;
using Android.Support.V7.App;

namespace ChatApp_DaculanZaragoza.Droid
{
    [Activity(Label = "ChatApp", Icon = "@mipmap/icon", Theme = "@style/splashscreen", MainLauncher = true, NoHistory = true)]

    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
        }
    }
    //public class SplashActivity : ContentPage
    //{
    //    public SplashActivity()
    //    {
    //        Content = new StackLayout
    //        {
    //            Children = {
    //                new Label { Text = "Welcome to Xamarin.Forms!" }
    //            }
    //        };
    //    }
    //}
}