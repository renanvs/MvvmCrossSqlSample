using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using SqlSample.Core.IO;
using SqlSample.Core.Model;

namespace SqlSample.Core.Services
{
	public class DataBaseService : IDataBaseService
	{
	

		/*public DataBaseService(string path) : base(new SQLitePlatformAndroid(), path)
		{
			CreateTable<Pessoa>();
		}*/

		SQLiteConnection _sqliteConnection;

		private IDeviceFileSystem _fs;
		public DataBaseService(IDeviceFileSystem fs)
		{
			_fs = fs;

			var dbPath = _fs.DataBasePath();

			_sqliteConnection = new SQLiteConnection(new SQLitePlatformAndroid(), dbPath);
			_sqliteConnection.CreateTable<Pessoa>();
		}

		public void insertPessoaInDb(Pessoa pessoa)
		{

			var s = _sqliteConnection.Insert(pessoa);
			
		}
	}
}
