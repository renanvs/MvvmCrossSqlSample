// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the BaseView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Android.App;
using Android.OS;
using Android.Widget;
using SqlSample.Core.ViewModels;
namespace SqlSample.Droid.Views
{
	using Cirrious.MvvmCross.Droid.Views;

	[Activity(Label = "FirstView", MainLauncher = true)]
	public class BaseView : MvxActivity
	{
		private Button btInsert;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.MainScreen);

			btInsert = FindViewById<Button>(Resource.Id.buttonInsert);
			btInsert.Click += (o, e) => { AddNome(); };

			Toast.MakeText(this, Application.Context.PackageName, ToastLength.Long).Show();
		}

		private void AddNome()
		{
			Model.DoInsertPublic();
		}

		private BaseViewModel Model
		{
			get { return (BaseViewModel)ViewModel; }
		}
	}
}