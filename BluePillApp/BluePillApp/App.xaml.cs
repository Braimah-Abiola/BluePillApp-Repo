﻿using BluePillApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BluePillApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ChatbotPage();
        }

        //String for the message user
        public static string User = "User";
        public static string ChatBot = "Fleming";

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
