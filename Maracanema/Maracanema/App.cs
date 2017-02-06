using Maracanema.View;

using Xamarin.Forms;

namespace Maracanema
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var principal = new NavigationPage(new ViewPrincipal());
            MainPage = principal;
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
