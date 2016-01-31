using System;
using SQLite;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xamarin.Forms;
using Xamarin;

namespace LifeStyle
{
	
		public abstract class RepositorioBase<T>: IRepositorioBase<T> where T : class, new()
		{
		SQLite.Net.SQLiteConnection connection { get; set; }

			private object _lock = new object();

			public RepositorioBase()
			{
				this.connection = DependencyService.Get<ISQLite>().GetConnection();

				this.CriarBase();
			}

			protected void CriarBase()
			{
				try
				{
					this.connection.BeginTransaction();
					this.connection.CreateTable<Activity>();
					this.connection.CreateTable<Result>();
					this.connection.Commit();
				}
				catch (Exception ex)
				{
					Insights.Report(ex);
					throw ex;
				}
			}

			#region IRepositorioBase implementation

			public bool Inserir(T entidade)
			{
				lock (_lock)
					return this.connection.InsertOrReplace(entidade) > 0;
			}

			public bool InserirTodos(ICollection<T> listaEntidade)
			{
				lock (_lock)
				return this.connection.InsertAll(listaEntidade) > 0;
			}

			public bool Deletar(int entidadeId)
			{
				lock (_lock)
					return this.connection.Delete(entidadeId) > 0;
			}

			public ICollection<T> ProcurarPorColecao(Type tipoObjeto, EnumTipoQuery query, object param)
			{
				var result = new List<T>();

				lock (_lock)
				{
				if (tipoObjeto == typeof(Activity))
					{
						/*switch (query)
						{
						case EnumTipoQuery.SELECT_PESSOA_POR_EMAIL:
							result = this.connection.Query<T>(String.Concat(Constants.QUERY_PESSOA_POR_EMAIL, Convert.ToString(param)));
							break;

						case EnumTipoQuery.SELECT_PESSOA_POR_NOME:
							result = this.connection.Query<T>(String.Concat(Constants.QUERY_PESSOA_POR_NOME, Convert.ToString(param)));
							break;

						case EnumTipoQuery.SELECT_PESSOA_POR_TELEFONE:
							result = this.connection.Query<T>(String.Concat(Constants.QUERY_PESSOA_POR_TELEFONE, Convert.ToString(param)));
							break;
						}*/

						result = this.connection.Query<T>(String.Concat(Constants.QUERY_ACTIVITY_BY_DESCRIPTION, Convert.ToString(param)));
					}
				}

				return result;
			}

			public T ProcurarPorFiltro(Expression<Func<T, bool>> filtro)
			{
				lock (_lock)
					return this.connection.Table<T>().Where(filtro).FirstOrDefault();
			}

			public ICollection<T> RetornarTodos(Type tipoObjeto)
			{
				lock (_lock)
				{
				if (tipoObjeto == typeof(Activity))
						return this.connection.Query<T>(Constants.QUERY_ACTIVITY_ALL);
				}

				return null;
			}

			public T RetornarPorId(int pkId)
			{
				lock (_lock)
					return this.connection.Get<T>(pkId);
			}

			public bool Atualizar(T entidade)
			{
				lock (_lock)
					return this.connection.Update(entidade) > 0;
			}

			public bool ExisteRegistro()
			{
				lock (_lock)
					return this.connection.Table<T>().Count() > 0;
			}

			#endregion
		}

}

