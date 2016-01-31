using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LifeStyle
{
	//public class RepositorioActivity
	//{
	public class RepositorioActivity: RepositorioBase<Activity>, IRepositorioActivity
		{
		public ICollection<Activity> GetActivities ()
		{
			try {
				return base.RetornarTodos (typeof(Activity));
			} catch (Exception ex) {
				throw ex;
			}
		}

		public Activity GetActivityPorId (int activityId)
		{
			try {
				return base.RetornarPorId (activityId);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool InserirActivity (Activity activity)
		{
			try {
				return base.Inserir (activity);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool InserirActivities (List<Activity> activities)
		{
			try {
				return base.InserirTodos (activities);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool RemoverActivity (int activityId)
		{
			try {
				return base.Deletar (activityId);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool AtualizarActivity (Activity activity)
		{
			try {
				return base.Atualizar (activity);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public bool ExistemActivities ()
		{
			try {
				return base.ExisteRegistro ();
			} catch (Exception ex) {
				throw ex;
			}
		}

		/*public Pessoa GetPessoasPorTelefone (string telefone)
		{
			try {
				Expression<Func<Pessoa,bool>> porTelefone = (p) => p.Telefone == telefone;
				return base.ProcurarPorFiltro (porTelefone);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public Pessoa GetPessoasPorNome (string nome)
		{
			try {
				Expression<Func<Pessoa,bool>> porNome = (p) => p.Nome.StartsWith (nome) || p.Nome.EndsWith (nome);
				return base.ProcurarPorFiltro (porNome);
			} catch (Exception ex) {
				throw ex;
			}
		}

		public Pessoa GetPessoasPorEmail (string email)
		{
			try {
				Expression<Func<Pessoa,bool>> porEmail = (p) => p.Email == email;
				return base.ProcurarPorFiltro (porEmail);
			} catch (Exception ex) {
				throw ex;
			}
		}*/

		public Activity GetActivitiesPorFiltro (Expression<Func<Activity, bool>> predicado)
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

