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
	}
}
