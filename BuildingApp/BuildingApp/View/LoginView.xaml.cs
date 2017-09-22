using BuildingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BuildingApp.View
{
    public partial class LoginView : ContentPage
    {
       // public INavigationService _navigation;
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           // BindingContext = new Viewmodel.LoginViewModel(new Services.Navigation() );
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            // Navigation.InsertPageBefore(new MasterViewPage(),new  LoginView());
            Navigation.PopAsync();
          //  App.Current.MainPage = new MasterViewPage();
             Navigation.PushAsync(new View.LoginView());
        }
    }
}
