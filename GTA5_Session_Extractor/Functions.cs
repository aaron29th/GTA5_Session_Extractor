using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GTA5_Session_Extractor
{
	class Functions
	{
		public static void checkUpdates()
		{
			// Check if server is online
			if (new Ping().Send(Variables.versionCheckHost).Status != IPStatus.Success)
			{
				Output.write("Failed to check for updates");
				return;
			}

			try
			{
				HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://" + Variables.versionCheckHost + Variables.versionCheckPath);
				Request.UserAgent = $"GTA5_Session_Extractor_{Variables.version}";

				var res = Request.GetResponse().GetResponseStream();
				using (StreamReader sr = new StreamReader(res))
				{
					Dictionary<string, object> jsonData = JsonConvert.DeserializeObject<Dictionary<string, object>>(sr.ReadToEnd());

					if (jsonData.ContainsKey("version"))
					{
						Variables.lastestVersion = Convert.ToInt32(jsonData["version"]);
					}

					if (jsonData.ContainsKey("lastestDownload"))
					{
						Variables.lastestDownloadLink = Convert.ToString(jsonData["lastestDownload"]);
					}

					if (jsonData.ContainsKey("startUpMessage") && jsonData["startUpMessage"] != null)
					{
						Output.write(jsonData["startUpMessage"].ToString());
					}

					if (jsonData.ContainsKey("steamSessionOffset") && jsonData["steamSessionOffset"] != null)
					{
						Variables.steamSessionOffset = Convert.ToInt32(jsonData["steamSessionOffset"]);
					}

					if (jsonData.ContainsKey("rockstarSessionOffset") && jsonData["rockstarSessionOffset"] != null)
					{
						Variables.rockstarSessionOffset = Convert.ToInt32(jsonData["rockstarSessionOffset"]);
					}
				}
			}
			catch
			{
				Output.write("Failed to check for updates");
			}

			if (Variables.version < Variables.lastestVersion)
			{
				Output.write("There is a new version available" + Environment.NewLine + "Go to: " + Variables.lastestDownloadLink + " to download the lastest version");
			}
		}
	}
}
