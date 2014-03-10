using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using SqlSample.Core.Model;

namespace SqlSample.Core.Services
{
	public class DataService : IDataService
	{
		public void Insert(Pessoa pessoa)
		{
			Debug.WriteLine(pessoa.Nome);
		}
	}
}
