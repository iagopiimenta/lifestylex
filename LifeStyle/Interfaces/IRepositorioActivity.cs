using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LifeStyle
{
	public interface IRepositorioActivity
	{
		ICollection<Activity> GetActivities ();

		Activity GetActivityPorId (int activityId);

		bool InserirActivity (Activity activity);

		bool InserirActivities (List<Activity> activities);

		bool RemoverActivity (int activityId);

		bool AtualizarActivity (Activity activity);

		bool ExistemActivities ();

		/*Pessoa GetPessoasPorTelefone (string telefone);

		Pessoa GetPessoasPorNome (string nome);

		Pessoa GetPessoasPorEmail (string email);*/

		Activity GetActivitiesPorFiltro (Expression<Func<Activity, bool>> predicado);
	}
}

