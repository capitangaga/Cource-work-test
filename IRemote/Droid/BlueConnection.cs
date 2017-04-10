using System;
using System.Threading.Tasks;
using IRemote.Droid;
using Xamarin.Forms;
using System.Collections.Generic;
using Android.Bluetooth;

[assembly: Dependency(typeof(BlueConnection))]
namespace IRemote.Droid
{

	public class BlueConnection : IBlueConnection
	{
		private BluetoothAdapter adapter;
		private MakeToast toster;

		private BluetoothDevice device;
		private List<BluetoothDevice> bondedDevices;

		public bool AnyBluetooth
		{
			get;
		}
		private BluetoothSocket socket;
		public BlueConnection()
		{
			toster = new MakeToast();
			adapter = BluetoothAdapter.DefaultAdapter;
			if (adapter == null)
			{
				toster.ShowMessage("You haven't bluetooth on your device", true);
				AnyBluetooth = false;
			}
			AnyBluetooth = true;

		}

		public List<string> BoundedDevicesNames
		{
			get
			{
				List<string> devNames = new List<string>();
				bondedDevices = new List<BluetoothDevice>(adapter.BondedDevices);

				foreach (BluetoothDevice dev in bondedDevices)
				{
					devNames.Add(dev.Name);
				}
				return devNames;
			}
		}
		public bool IsBluetoothOn
		{
			get { return adapter.IsEnabled; }
		}
		public int DeviceToWorkSetByNumber
		{
			set { device = bondedDevices[value]; }
		}
		async public Task<bool> ConnectToSelectedDevice()
		{
			bool result = await Task.Run(() =>
			{
				try
				{
					if (socket != null)
					{
						socket.Close();
						socket = null;
					}
					adapter.StartDiscovery();
					device.SetPairingConfirmation(false);
					device.SetPairingConfirmation(true);
					device.CreateBond();
					adapter.CancelDiscovery();
					socket = device.CreateRfcommSocketToServiceRecord(Java.Util.UUID.FromString(
						"00001101-0000-1000-8000-00805f9b34fb"));
					socket.Connect();
				}
				catch (Exception) { return false; }
				return true;
			});
			return result;
		}
		public void Disconnect()
		{
			if (socket != null)
			{
				socket.Close();
				socket = null;
			}
		}
		public bool IsConnected
		{
			get
			{
				if (socket != null && socket.IsConnected) { return true; }
				return false;
			}

		}
		public string ConnectedDeviceName
		{
			get
			{
				if (socket != null && socket.IsConnected) return $"Connected to {device.Name}";
				else return "Not connected";
			}
		}
	}
}

