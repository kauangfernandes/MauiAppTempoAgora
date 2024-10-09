using MauiAppTempoAgora.Models;
using MauiAppTempoAgora.Service;
using System.Diagnostics;

namespace MauiAppTempoAgora
{
    public partial class MainPage : ContentPage
    {
        CancellationToken _cancelTokenSourcer;
        bool isCheckingLocation;

        String? cidade;

        public MainPage()
        {
            InitializeComponent();
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                _cancelTokenSourcer = new CancellationToken();
                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromMicroseconds(10));
                Location? location = await Geolocation.Default.GetLocationAsync.
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
    }

}
