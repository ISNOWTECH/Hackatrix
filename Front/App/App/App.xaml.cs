﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App.Services;
using App.Views;
using Firebase.Database;

namespace App
{
    public partial class App : Application
    {
        public static FirebaseOptions Options { get; set; }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
