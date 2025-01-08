using KursRab;
using System;
using Xamarin.Forms;

namespace KursRab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void OnCatalogClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CatalogPage());
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnCartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartPage());
        }
    }
}