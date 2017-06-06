using AppXamlExperiment.Pages;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXamlExperiment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Register registerpage = new Register();
                await Navigation.PushModalAsync(registerpage);
            }
            catch (Exception)
            {
                Crashes.GenerateTestCrash();                
                throw;
            }
            
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            await Navigation.PushModalAsync(loginpage);
        }
    }
}
