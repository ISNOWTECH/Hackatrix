using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App.Droid
{
    [Activity(Label = "SplashActivity", MainLauncher = true, Theme ="@style/splashscreen")]
    public class SplashActivity : Activity
    {
        int[] images =
        {
            
        };
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activiy_Splash);
            int index = 0;
            ImageButton b = FindViewById<ImageButton>(Resource.Id.ImgB);
            b.SetImageResource(images[0]);
            b.Click += (sender, e) =>
            {
                b.SetImageResource(images[index]);
                if (index >= images.Length)
                {
                    StartActivity(new Intent(Application.Context,typeof(MainActivity)));
                }
            };
        }
    }
}