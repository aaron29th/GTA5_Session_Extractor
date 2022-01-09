using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA5_Session_Extractor
{
	class Variables
	{
		public static string versionStr = "1.01";
		public static int version = 101;
		public static int lastestVersion = 101;

		public static string versionCheckHost = "aaronrosser.xyz";
		public static string versionCheckPath = "/projects/GTA5/PC/session_extractor.json";

		public static string lastestDownloadLink = "";

		public static int steamSessionOffset = 0x2C3BEF0;
		public static int rockstarSessionOffset = 0x2C37260;
	}
}
