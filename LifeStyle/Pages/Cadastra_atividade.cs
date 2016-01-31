using System;

using Xamarin.Forms;

namespace LifeStyle
{
	public class Cadastra_atividade : ContentPage
	{
		public Cadastra_atividade(){
			var btnSalvar = new Button();
			btnSalvar.Text = "Salvar";
			btnSalvar.TextColor = Color.White;
			btnSalvar.BackgroundColor = Color.FromHex ("77D065");

			var Descrição = new Entry ();
			Descrição.Placeholder = "Descrição";

		Title = "Cadastrar Treino";
		Icon = "icon.png";
			Content = new StackLayout {
				Spacing = 20, Padding = 40,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					Descrição,
					btnSalvar,
				}
			};
		}
	}
}


