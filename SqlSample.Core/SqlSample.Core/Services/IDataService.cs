using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSample.Core.Model;

namespace SqlSample.Core.Services
{
	public interface IDataService
	{
		void Insert(Pessoa pessoa);
	}
}
