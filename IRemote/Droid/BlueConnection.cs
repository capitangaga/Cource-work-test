using System;
using IRemote.Droid;
using Xamarin.Forms;
using System.Collections.Generic;

[assembly: Dependency(typeof(BlueConnection))]
namespace IRemote.Droid
{

	public class BlueConnection : IBlueConnection
	{
		public BlueConnection()
		{
		}

		public List<string> BoundedDevicesNames
		{
			get
			{
				return new List<string> { "Dev1", "Dev2", "Dev3" };
			}
		}
		public bool IsBluetoothOn
		{
			get { return true; }
		}

	}
}
