using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace LifeStyle
{
	public class ListaAtividades : ContentPage
	{
		
		

			class Person
			{
			public Person(string descricao, string dia )
				{
				this.descricao = descricao;
				this.dia = dia;
				}

				public string descricao { private set; get; }

			public string dia { private set; get; }

			};

		public ListaAtividades ()
		{
				Label titulo = new Label
				{
					Text = "Lista de Atividades",
					FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
					HorizontalOptions = LayoutOptions.Center
				};

				List<Person> people = new List<Person>
				{
				new Person("correr 200 metros", "Segunda-Feira" ),
				new Person("Pratica Jiu Jitsu", "segunda-feira"),
				new Person("Musculaçao", "Terça-Feira"),
				new Person("Natação", "Terça-feira")
				};

				ListView listView = new ListView
				{
					ItemsSource = people,

					ItemTemplate = new DataTemplate(() =>
						{
							Label LBdescricao = new Label();
						LBdescricao.SetBinding(Label.TextProperty, "descricao");
						LBdescricao.TextColor = Color.White;

						Label lbDia = new Label();
						lbDia.SetBinding(Label.TextProperty,"dia");
						lbDia.TextColor = Color.White;

							return new ViewCell
							{
								View = new StackLayout
								{
									Padding = new Thickness(0, 5),
									Orientation = StackOrientation.Horizontal,
									Children = 
									{
										new StackLayout
										{
											VerticalOptions = LayoutOptions.Center,
											Spacing = 0,
											Children = 
											{
											
											LBdescricao,	
											lbDia,
												//dia
											}
											}
									}
									}
							};
						})
				};

				this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

				this.Content = new StackLayout
				{
					Children = 
					{
						titulo,
						listView
					}
					};
			}
		}
	}



