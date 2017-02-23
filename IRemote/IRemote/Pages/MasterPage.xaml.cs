using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IRemote
{
	public delegate void CategorySelectedEventHandler(object sender, CategorySelectedEventArgs e);

	public partial class MasterPage : ContentPage
	{
		public MasterPage()
		{
			InitializeComponent();

			Title = "IRemote";

			LogoLabel.BackgroundColor = (Color)App.Current.Resources["primaryColor"];
			LogoView.BackgroundColor = (Color)App.Current.Resources["primaryColor"];

			ConnectButton.Clicked += OnNavigation;



		}

		public event CategorySelectedEventHandler CategorySelected;
		public event EventHandler HelpButtonClicked;
		public event EventHandler ConnectButtonClicked;
		public event EventHandler ShowAllButtonClicked;

		public void OnNavigation(object sender, EventArgs e)
		{
			if (sender == ConnectButton && ConnectButtonClicked != null)
				ConnectButtonClicked(this, EventArgs.Empty);

			if (sender == HelpButton && HelpButtonClicked != null)
				HelpButtonClicked(this, EventArgs.Empty);
			if (sender == ShowAllButton && ShowAllButtonClicked != null)
				ShowAllButtonClicked(this, EventArgs.Empty);

			//TODO for category selected
		}
	}

	public class CategorySelectedEventArgs : EventArgs
	{
		public CategorySelectedEventArgs(string category) : base()
		{
			Category = category;
		}
		string Category { get; }
	}
}
