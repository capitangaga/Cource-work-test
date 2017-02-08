using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IRemote
{
	public partial class ConnectionPage : ContentPage
	{
		public ConnectionPage()
		{
			InitializeComponent();
			Devices.ItemsSource = App.BlueCon.BoundedDevicesNames;
		}
	}
}
