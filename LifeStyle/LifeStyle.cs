using System;

using Xamarin.Forms;
using Autofac;

namespace LifeStyle
{
	public class App : Application
	{
		public static IContainer container;

		/*Page GetMainActivity ()
		{
			throw new NotImplementedException ();
		}*/

		public App ()
		{
			//throw new NotImplementedException ();
			MainPage = new InicioPage();

			container = AutofacConfiguration.Init();
		}

		/*public App(string dataBaseName, ISQLite sqlitePltf)
		{
			MainPage = GetMainActivity();
		}*/

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

