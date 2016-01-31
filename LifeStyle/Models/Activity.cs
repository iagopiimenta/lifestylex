using System;
using SQLite;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;

namespace LifeStyle
{
	public class Activity
	{
		[PrimaryKey, AutoIncrement]
		public int ActivityId { get; set; }

		public string Description { get; set; }

		public bool Sunday { get; set; }
		public bool Monday { get; set; }
		public bool Tuesday { get; set; }
		public bool Wednesday { get; set; }
		public bool Thursday { get; set; }
		public bool Friday { get; set; }
		public bool Saturday { get; set; }

		[OneToMany("ActivityId")]
		IList<Result> Results { get; set; }

	}
}

