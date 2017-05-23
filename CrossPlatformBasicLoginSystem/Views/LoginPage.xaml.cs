using CrossPlatformBasicLoginSystem.ServicesHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrossPlatformBasicLoginSystem.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            LoginService services = new LoginService();
            var getLoginDetails = await services.CheckLoginIfExists(EntryUsername.Text, EntryPassword.Text);

            if (getLoginDetails)
            {
                await DisplayAlert("Login success", "You are login", "Okay", "Cancel");
            }
            else
            {
                await DisplayAlert("Login failed", "Username or Password is incorrect or not exists", "Okay", "Cancel");
            }
        }
    }
}
