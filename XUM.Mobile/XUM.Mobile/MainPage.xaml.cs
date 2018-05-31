using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XUM.Mobile
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ButtonSampleView());
        }

        async void OnHelloCssPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelloCssView());
        }

        async void OnSvgFilesPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SvgFilesView());
        }
    }
}
