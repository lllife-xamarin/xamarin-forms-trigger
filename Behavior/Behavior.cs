using System;

using Xamarin.Forms;

namespace Behavior
{
	public class App : Application
	{
		public App ()
		{
			//MainPage = new StyleTriggerExample (); 
			MainPage = new ButtonTriggerExample ();
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

