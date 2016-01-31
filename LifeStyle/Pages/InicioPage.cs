using System;

using Xamarin.Forms;

namespace LifeStyle
{
	public class InicioPage : ContentPage
	{
		public InicioPage ()
		{

			Title = "Bem Vindo ao LifeStile";
			Icon = "icon.png";
			Content = new StackLayout {
				Spacing = 20, Padding = 40,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Button {
						Text = "Programa Semana",
						TextColor = Color.White,
						BackgroundColor = Color.FromHex("77D065") 
						

						},
					new Button {
						Text = "Tarefa do dia",
						TextColor = Color.White,
						BackgroundColor = Color.FromHex("77D065")
					}}
			};
		}
	}
}