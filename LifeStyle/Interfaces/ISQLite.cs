using System;
using SQLite;

namespace LifeStyle
{
	public interface ISQLite
	{
		SQLite.Net.SQLiteConnection GetConnection();
	}
}

