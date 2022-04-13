using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTA5_Session_Extractor
{
	class Session
	{
		[JsonIgnore]
		public string username { get; set; }
		[JsonIgnore]
		public DateTime expiry { get; set; }

		public string ticket { get; set; }
		public string sessionTicket { get; set; }
		public string sessionKey { get; set; }

		private const int usernameOffset = 0x6BF;
		private const int usernameLength = 64;

		private const int milliSecsToExpiryOffset = 0x590;

		private const int ticketOffset = 0x310;
		private const int ticketLength = 208;

		private const int sessionTicketOffset = 0x510;
		private const int sessionTicketLength = 88;

		private const int sessionKeyOffset = 0x8E8;
		private const int sessionKeyLength = 16;

		public static Session extractFromRunningGame(bool steamVersion)
		{
			Session s = new Session();

			if (!Memory.Attach("GTA5"))
			{
				Output.write("Failed to attach to GTA 5");
				return null;
			}

			IntPtr baseAddress = Memory.GetModuleAddress("GTA5.exe");
			if (baseAddress == IntPtr.Zero)
			{
				Output.write("Failed to get module address");
				return null;
			}

			IntPtr sessionAddress = baseAddress + (steamVersion ? Variables.steamSessionOffset : Variables.rockstarSessionOffset);

			s.username = Memory.ReadString(sessionAddress + usernameOffset, usernameLength);
			s.ticket = Memory.ReadString(sessionAddress + ticketOffset, ticketLength);
			s.sessionTicket = Memory.ReadString(sessionAddress + sessionTicketOffset, sessionTicketLength);
			s.sessionKey = Convert.ToBase64String(Memory.ReadMemory(sessionAddress + sessionKeyOffset, sessionKeyLength));

			int milliSecsUntilExpiry = Memory.ReadMemory<int>(sessionAddress + milliSecsToExpiryOffset);
			s.expiry = DateTime.Now.AddMilliseconds(milliSecsUntilExpiry);

			return s;
		}

		public string serialize()
		{
			string sessionData = JsonConvert.SerializeObject(this);
			string expiryStr = expiry.ToString("s") + "Z";
			return $"{username};{expiryStr};{Convert.ToBase64String(Encoding.UTF8.GetBytes(sessionData))}";
		}
	}
}
