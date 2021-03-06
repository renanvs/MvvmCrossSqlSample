// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the Setup type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Cirrious.CrossCore;
using SQLite.Net.Interop;
using SqlSample.Core;
using SqlSample.Core.IO;
using SqlSample.Droid.IO;

namespace SqlSample.Droid
{
	using Android.Content;

	using Cirrious.MvvmCross.Droid.Platform;
	using Cirrious.MvvmCross.ViewModels;

	/// <summary>
	///    Defines the Setup type.
	/// </summary>
	public class Setup : MvxAndroidSetup
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Setup"/> class.
		/// </summary>
		/// <param name="applicationContext">The application context.</param>
		public Setup(Context applicationContext)
			: base(applicationContext) {
			
		}

		/// <summary>
		/// Creates the app.
		/// </summary>
		/// <returns>An instance of IMvxApplication.</returns>
		protected override IMvxApplication CreateApp() {
			return new App();
		}

		protected override IMvxNavigationSerializer CreateNavigationSerializer()
		{
			Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();
			Cirrious.MvvmCross.Plugins.Messenger.PluginLoader.Instance.EnsureLoaded();
			return new MvxJsonNavigationSerializer();
		}

		protected override void InitializeLastChance()
		{
			base.InitializeLastChance();
			Mvx.RegisterType(typeof(IDeviceFileSystem), typeof(DroidDeviceFileSystem));

		}
	}
}