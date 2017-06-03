using Microsoft.Azure.Mobile;
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
