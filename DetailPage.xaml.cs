using Xamarin.Forms;
using UthaiThaniTourismApp.Views;
using System;
using Xamarin.Essentials;

namespace UthaiThaniTourismApp.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(TourismPlace place)
        {
            InitializeComponent();
            BindingContext = place;
        }

        private async void OnBackButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        //ปุ่มเปิดแผนที่
        private async void OnOpenMapClicked(object sender, EventArgs e)
        {
            var placeName = Uri.EscapeDataString(((TourismPlace)BindingContext).Name);
            var url = $"https://www.google.com/maps/search/?api=1&query={placeName}";
            await Launcher.OpenAsync(url);
        }

        // ปุ่มแชร์
        private async void OnShareClicked(object sender, EventArgs e)
        {
            var place = (TourismPlace)BindingContext;
            await Share.RequestAsync(new ShareTextRequest
            {
                Title = "แชร์สถานที่ท่องเที่ยว",
                Text = $"{place.Name}\n\n{place.Description}",
                Uri = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(place.Name)
            });
        }

        // ปุ่มรายการโปรด
        //private void OnFavoriteClicked(object sender, EventArgs e)
        //{
        //    var place = (TourismPlace)BindingContext;
        //    Application.Current.Properties["FavoritePlace"] = place.Name;
        //    Application.Current.SavePropertiesAsync();
        //    DisplayAlert("เพิ่มในรายการโปรด", $"{place.Name} ถูกเพิ่มลงในรายการโปรดแล้ว", "ตกลง");
        //}
    }
}