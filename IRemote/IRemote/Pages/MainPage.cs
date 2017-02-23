using System;

using Xamarin.Forms;

namespace IRemote
{
	public class MainPage : MasterDetailPage
	{
		MasterPage master;

		public MainPage()
		{
			Detail = new NavigationPage(new HomePage { BindingContext = null });
			master = new MasterPage();
			Master = master;
			master.ConnectButtonClicked += OnConnectButtonClicked;
		}

		public void OnConnectButtonClicked(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new ConnectionPage());
			IsPresented = false;
		}
	}
}

