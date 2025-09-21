using Xamarin.Forms;
using UthaiThaniTourismApp.Views;

namespace UthaiThaniTourismApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // หน้าแรกแอป
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new WelcomePage());
        }
    }
}
