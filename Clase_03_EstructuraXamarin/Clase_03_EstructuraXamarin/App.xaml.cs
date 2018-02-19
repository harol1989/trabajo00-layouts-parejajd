using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Clase_03_EstructuraXamarin
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new Clase_03_EstructuraXamarin.MainPage();
            //MainPage = new Clase_03_EstructuraXamarin.StackLayoutDemo1();
            //MainPage = new Clase_03_EstructuraXamarin.GridLayoutDemo1();
            MainPage = new Clase_03_EstructuraXamarin.ImageDemo1();
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
