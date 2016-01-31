using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace LifeStyle
{
	public class Result
	{
		[PrimaryKey, AutoIncrement]
		public int ResultId { get; set; }

		[ForeignKey(typeof (Activity))]
		public int ActivityId { get; set; }

		public DateTime Data  { get; set; }
	}
}

