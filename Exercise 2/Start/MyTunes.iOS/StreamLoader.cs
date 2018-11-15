using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using MyTunes.Shared;
using UIKit;

namespace MyTunes
{
	public class StreamLoader : IStreamLoader
	{
		public Stream GetStreamForFileName(string fileName)
		{
			return File.OpenRead(fileName);
		}
	}
}