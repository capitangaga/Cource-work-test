using System;
using System.Diagnostics;

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
			master.ShowAllButtonClicked += OnShowAllButtonClicked;
			Debug.WriteLine("\u23FB");
		}

		public void OnConnectButtonClicked(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new ConnectionPage());
			IsPresented = false;
		}
		public void OnShowAllButtonClicked(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new SelectionPage { BindingContext = null });
			IsPresented = false;
		}
	}
}

