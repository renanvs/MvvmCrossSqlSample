// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the BaseViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Windows.Input;
using SqlSample.Core.Model;
using SqlSample.Core.Services;

namespace SqlSample.Core.ViewModels
{
	using System;
	using System.Linq.Expressions;

	using Cirrious.CrossCore;
	using Cirrious.MvvmCross.ViewModels;

	public class BaseViewModel : MvxViewModel
	{
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			set
			{
				_nome = value;
				RaisePropertyChanged(() => Nome);
			}
		}

		private MvxCommand _insertCommand;

		public ICommand InsertCommand
		{
			get
			{
				_insertCommand = _insertCommand ?? new MvxCommand(DoInsert);
				return _insertCommand;
			}
			
		}

		public void DoInsertPublic()
		{
			var model = new Pessoa();
			model.Nome = Nome;
			_dataService.Insert(model);
		}

		public string ButtonName {
			get { return "Add+"; }
		}

		private void DoInsert()
		{
			//_dataService.Insert(model);
		}

		private readonly IDataService _dataService;

		public BaseViewModel(IDataService dataService)
		{
			_dataService = dataService;
		}
	}
}
