using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IRemote
{
	public partial class SelectionPage : ContentPage
	{
		public SelectionPage()
		{
			InitializeComponent();




		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			if (BindingContext == null)
			{
				Title = "All Remotes";
				RemotesList.ItemsSource = await App.Database.GetRemotesAsync();
			}
			else
			{
				Title = BindingContext as string;
				RemotesList.ItemsSource = await App.Database.GetRemotesWithCategoryAsync(BindingContext as string);
			}
		}
		protected async void AddNewClicked(object sender, EventArgs e)
		{
			Remote newRemote = new Remote
			{
				Name = "New Remote",
				Category = BindingContext == null ? "" : BindingContext as string
			};
			await App.Database.SaveRemoteAsync(newRemote);
			// TODO Navigation to new Remote
		}

	}
}
