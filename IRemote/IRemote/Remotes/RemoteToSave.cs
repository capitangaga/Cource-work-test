using System;
using SQLite;

namespace IRemote
{
	/// <summary>
	/// Remote to save in SQLite db
	/// </summary>
	public class RemoteToSave
	{
		[PrimaryKey, AutoIncrement]
		/// <summary>
		/// Gets or sets the identifier of Remote
		/// </summary>
		/// <value>The identifier.</value>
		public int ID { get; set; }
		/// <summary>
		/// Gets or sets the name of Remote
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets the string with keys commands.
		/// </summary>
		/// <value>The keys.</value>
		public string KeysCommands { get; set; }
		/// <summary>
		/// Gets or sets the string with keys textss.
		/// </summary>
		/// <value>The keys texts.</value>
		public string KeysTexts { get; set; }

	}
}
