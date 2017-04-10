using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace IRemote
{
	public interface IBlueConnection
	{
		List<string> BoundedDevicesNames { get; }
		bool IsBluetoothOn { get; }
		int DeviceToWorkSetByNumber { set; }
		bool AnyBluetooth { get; }
		Task<bool> ConnectToSelectedDevice();
		bool IsConnected { get; }
		void Disconnect();
		string ConnectedDeviceName { get; }
	}
}