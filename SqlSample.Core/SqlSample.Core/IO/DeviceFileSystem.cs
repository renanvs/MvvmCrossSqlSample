using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSample.Core.IO
{
	public abstract class DeviceFileSystem :IDeviceFileSystem
	{
		public abstract string DataBasePath();
	}
}
