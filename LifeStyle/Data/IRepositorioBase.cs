using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LifeStyle
{
	public interface IRepositorioBase<T>
	{
		bool Inserir(T entidade);

		bool InserirTodos(ICollection<T> listaEntidade);

		bool Deletar(int entidadeId);

		ICollection<T> ProcurarPorColecao(Type tipoObjeto, EnumTipoQuery query, object param);

		T ProcurarPorFiltro(Expression<Func<T,bool>> filtro);

		ICollection<T> RetornarTodos(Type tipoObjeto);

		T RetornarPorId(int pkId);

		bool Atualizar(T entidade);

		bool ExisteRegistro();
	}
}

