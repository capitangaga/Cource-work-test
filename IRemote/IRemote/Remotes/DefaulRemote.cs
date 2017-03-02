using System;
namespace IRemote
{
	public static class DefaultRemote
	{
		public static string[] DefaultButtonNames
		{
			get
			{
				return new string[60]
				{
					"?", "Source", "Mute","\u23FB",
					"CH+", "CH-", "VOL+", "VOL-",
					"GUIDE", "MENU", "\u2191", "\u232B",
					"SMART", "\u2190", "\u23CE", "\u2192",
					"EXIT", "FRAME", "\u2193", "HOME",
					"", "", "", "", // row with RGYB buttons
					"C1", "C2", "C3", "C4",
					"C5", "C6", "C7", "C8",
					"\u23EE", "\u23EA", "\u23E9", "\u23ED",
					"\u25C9", "\u25BA", "\u9612", "\u9632",
					"BASS+", "BASS-", "TRE+", "TRE-",
					"1", "2", "3", "C9",
					"4", "5", "6", "C10",
					"7", "8", "9", "C11",
					"C12", "0", "C13", "C14"
				};
			}
		}
	}
	public partial class Remote
	{
		public Remote()
		{

		}
		public Remote(bool IsNew)
		{
			if (IsNew)
			{
				Buttons = new System.Collections.Generic.List<RemoteButton>();
				for (int i = 0; i < 60; i++)
				{
					Buttons.Add(new RemoteButton(i, 0, DefaultRemote.DefaultButtonNames[i]));
				}
				ID = 0;
				Name = "New Remote";
			}
		}


	}
}