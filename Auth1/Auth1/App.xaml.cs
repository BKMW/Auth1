﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Auth1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new Auth1.MainPage();
           // MainPage = new Auth1.View.Login();
            MainPage = new NavigationPage(new View.Menu());

        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
