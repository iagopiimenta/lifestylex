using System;
using Autofac;

namespace LifeStyle
{
	public static class AutofacConfiguration
	{
		public static IContainer Init()
		{
			var builder = new ContainerBuilder();

			// Registrando Serviços e dependências.
			//builder.RegisterInstance(new PessoaService()).As<IPessoaService>();

			// Registrando IoC para Repositório de Dados
			builder.RegisterInstance(new RepositorioActivity()).As<IRepositorioActivity>();
			builder.RegisterInstance(new RepositorioResult()).As<IRepositorioResult>();

			// Registrando ViewModels.
			//builder.RegisterType<PessoaViewModel>();

			return builder.Build();
		}
	}
}

