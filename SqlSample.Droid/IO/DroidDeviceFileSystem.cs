using SqlSample.Core.IO;
using Environment = System.Environment;
using Path = System.IO.Path;

namespace SqlSample.Droid.IO
{
	public class DroidDeviceFileSystem : DeviceFileSystem
	{
		public override string DataBasePath()
		{
			var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "test.sqlite");
			return dbPath;
		}

	}
}