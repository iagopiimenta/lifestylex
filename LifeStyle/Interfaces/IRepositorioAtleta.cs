using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LifeStyle
{
	public interface IRepositorioAtleta
	{
		ICollection<Atleta> GetAtletas ();

		Atleta GetAtletaPorId (int atletaId);

		bool InserirAtleta (Atleta atleta);

		bool InserirAtletas (List<Atleta> atleta);

		bool RemoverAtleta (int atletaId);

		bool AtualizarAtleta (Atleta atleta);

		bool ExistemAtletas ();

		Atleta GetAtletaPorFiltro (Expression<Func<Atleta, bool>> predicado);
	}
}

