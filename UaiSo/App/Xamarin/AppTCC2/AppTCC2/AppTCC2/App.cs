using AppTCC2.Views;
using System;
using Xamarin.Forms;

namespace AppTCC2
{
    public class App : Application
    {
        public static INavigation Navigation;
        public App()
        {
            // The root page of your application        

            //MainPage = new NavigationPage(new Login());
            try
            {
                MainPage = new NavigationPage(new Principal());
            }
            catch(Exception ex)
            {

            }
            
            Navigation = MainPage.Navigation;

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
