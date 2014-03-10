// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the App type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Cirrious.CrossCore;
using SqlSample.Core.Services;

namespace SqlSample.Core
{
	using Cirrious.CrossCore.IoC;
	using Cirrious.MvvmCross.ViewModels;
	using SqlSample.Core.ViewModels;

	/// <summary>
	/// Define the App type.
	/// </summary>
	public class App : MvxApplication
	{
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		public override void Initialize() {
			//this.CreatableTypes()
				//.EndingWith("Service")
				//.AsInterfaces()
				//.RegisterAsLazySingleton();

			//// Start the app with the First View Model.
			//this.RegisterAppStart<BaseViewModel>();

			Mvx.RegisterType<IDataService, DataService>();
			Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<BaseViewModel>());
		}
	}
}