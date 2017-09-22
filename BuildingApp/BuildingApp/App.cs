using BuildingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BuildingApp
{
    public class App : Application
    {
        private static Navigation _nav;

      //  public static Navigation Nav { get { return _nav ?? (_nav = new Navigation()); } }

        public App()
        {

             var login = new NavigationPage(new NavigationPage(new View.LoginView()));
            var master = new NavigationPage(new NavigationPage(new View.MasterViewPage()));

           // Nav.Initialize(login);
           // Nav.Initialize(master);

            MainPage = master;
        //    Navigation.InsertPageBefore(new View.LoginView()),)



        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
