using System;

using Xamarin.Forms;
using System.Windows.Input;

namespace LifeStyle
{
	public class InicioPage : ContentPage
	{
		public InicioPage ()
		{
			var btnCadastra = new Button ();
			btnCadastra.Clicked += (object sender, EventArgs e) => { Navigation.PushModalAsync (new Cadastra_atividade());};
			btnCadastra.Text = "Cadastra Atividade";
			btnCadastra.BackgroundColor = Color.FromHex("77D065");

			var btnVisualizar = new Button ();
			btnVisualizar.Clicked += (object sender, EventArgs e) => {
				Navigation.PushModalAsync (new ListaAtividades ());
			};
			btnVisualizar.Text = "Tarefa do Dia";
			btnVisualizar.BackgroundColor = Color.FromHex ("77D065");

			Title = "Bem Vindo ao LifeStile";
			Icon = "icon.png";
			Content = new StackLayout {
				Spacing = 20, Padding = 40,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					btnCadastra,
					btnVisualizar,
					}
			};
				// nada de mais 
		}
	}
}
