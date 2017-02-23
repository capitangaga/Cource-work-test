using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IRemote
{
	public partial class MasterPage : ContentPage
	{
		public MasterPage()
		{
			InitializeComponent();

			Title = "IRemote";

			LogoLabel.BackgroundColor = (Color)App.Current.Resources["primaryColor"];
			LogoView.BackgroundColor = (Color)App.Current.Resources["primaryColor"];

			ConnectButton.Clicked += (object obj, EventArgs e) =>
			{
				if (ConnectButtonClicked != null) ConnectButtonClicked(this, EventArgs.Empty);
			};



		}

		public event EventHandler ConnectButtonClicked;


	}
}
