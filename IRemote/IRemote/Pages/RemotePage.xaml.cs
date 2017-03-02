using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IRemote
{
	public partial class RemotePage : ContentPage
	{
		protected Remote bindedRemote;

		public RemotePage()
		{
			InitializeComponent();

		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			bindedRemote = BindingContext as Remote;
			Title = bindedRemote == null ? "" : bindedRemote.Name;
		}

		protected async void OnDeleteClicked(object sender, EventArgs e)
		{
			var confirm = await DisplayAlert("Delete the remote?", $"Are you shure to delete" +
											 "{(BindingContext as Remote).Name} remote?", "Delete", "Clancel");
			if (confirm)
			{
				await App.Database.RemoveRemoteAsync(BindingContext as Remote);
				await Navigation.PopAsync();
			}
		}
	}
}
