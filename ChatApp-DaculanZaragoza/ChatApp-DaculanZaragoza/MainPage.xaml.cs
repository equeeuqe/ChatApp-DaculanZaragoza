using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChatApp_DaculanZaragoza
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void showhidePassword(object sender, EventArgs args)
        {
            LoginPassword.IsPassword = LoginPassword.IsPassword ? false : true;
        }

        private void toSignUp(object sender, EventArgs args)
        {
            Navigation.PushAsync(new SignUp());
        }
    }
}
