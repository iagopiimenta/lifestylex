using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LifeStyle
{
	public interface IRepositorioResult
	{
		ICollection<Result> GetResults ();

		Result GetResultPorId (int resultId);

		bool InserirResult (Result result);

		bool InserirResults (List<Result> results);

		bool RemoverResult (int resultId);

		bool AtualizarResult (Result result);

		bool ExistemResults ();

		Result GetResultsPorFiltro (Expression<Func<Result, bool>> predicado);
	}
}

