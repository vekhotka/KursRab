using System;
using Xamarin.Forms;

namespace KursRab
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
        
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Успех", "Профиль успешно сохранен", "Ок");
        }

        private void OnCreateNewProfileClicked(object sender, EventArgs e)
        {
            NameEntry.Text = string.Empty;
            SurnameEntry.Text = string.Empty;
            PhoneEntry.Text = string.Empty;
            BirthDatePicker.Date = DateTime.Now;
        }
    }
}