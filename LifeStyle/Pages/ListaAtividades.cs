using System;

using Xamarin.Forms;

namespace LifeStyle
{
	public class ListaAtividades : ContentPage
	{
		public ListaAtividades ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


