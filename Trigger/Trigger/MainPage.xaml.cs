using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trigger
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Data());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Event());
            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Property());

            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Style());

            };

            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new MultiTrigger());

            };

        }
    }
}
