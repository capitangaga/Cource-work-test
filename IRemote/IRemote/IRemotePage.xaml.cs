using Xamarin.Forms;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
namespace IRemote
{
	public partial class IRemotePage : ContentPage
	{

		public IRemotePage()
		{
			InitializeComponent();

		}
		protected override void OnAppearing()
		{
			base.OnAppearing();


		}
		protected async void NewRemoteClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AddNewPage { BindingContext = new Remote() });
		}

		protected async void ConnectClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConnectionPage { BindingContext = null });

		}
	}
}
