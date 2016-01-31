using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LifeStyle
{
	//public class RepositorioActivity
	//{
	public class RepositorioResult: RepositorioBase<Result>, IRepositorioResult
		{
		public ICollection<Result> GetResults ()
		{
			try {
				return base.RetornarTodos (typeof(Result));
			} catch (Exception ex) {
				throw ex;
			}
		}

		public Result GetResultPorId (int resultId)
		{
			try {
				return base.RetornarPorId (resultId);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool InserirResult (Result result)
		{
			try {
				return base.Inserir (result);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool InserirResults (List<Result> results)
		{
			try {
				return base.InserirTodos (results);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool RemoverResult (int resultId)
		{
			try {
				return base.Deletar (resultId);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool AtualizarResult (Result result)
		{
			try {
				return base.Atualizar (result);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool ExistemResults ()
		{
			try {
				return base.ExisteRegistro ();
			} catch (Exception ex) {
				throw ex;
			}
		}

		public Result GetResultsPorFiltro (Expression<Func<Result, bool>> predicado)
		{
			try {
				return base.ProcurarPorFiltro (predicado);
			} catch (Exception ex) {
				throw ex;
			}
		}
		}
	//}
}

