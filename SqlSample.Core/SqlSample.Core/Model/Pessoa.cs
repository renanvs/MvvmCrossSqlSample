using SQLite.Net.Attributes;

namespace SqlSample.Core.Model
{
	public class Pessoa
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Nome { get; set; }
	}
}
