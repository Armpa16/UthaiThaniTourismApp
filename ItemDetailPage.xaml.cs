using System.ComponentModel;
using UthaiThaniTourismApp.ViewModels;
using Xamarin.Forms;

namespace UthaiThaniTourismApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}