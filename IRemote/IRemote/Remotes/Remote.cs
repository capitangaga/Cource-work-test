using System;
namespace IRemote
{
	public class Remote
	{
		public Remote()
		{

		}
		public string Name { get; set; }
		public string Category { get; set; }
		public int ID { get; set; }
		public override string ToString()
		{
			return string.Format("{0}", Name);
		}
	}
}
