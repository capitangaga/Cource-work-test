using System;
using System.Collections.Generic;
namespace IRemote
{
	public interface IBlueConnection
	{
		List<string> BoundedDevicesNames { get; }
		bool IsBluetoothOn { get; }
	}
}