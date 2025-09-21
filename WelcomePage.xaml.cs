using System;
using Xamarin.Forms;

namespace UthaiThaniTourismApp.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            // ซ่อนเเถบบาร์หน้าเเรก
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnExploreClicked(object sender, EventArgs e)
        {
            // กดไปหน้าหลัก
            await Navigation.PushAsync(new MainPage());
        }
    }
}