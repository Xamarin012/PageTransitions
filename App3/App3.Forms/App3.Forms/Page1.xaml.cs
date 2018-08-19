using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Page2Button_Clicked(object sender, EventArgs e)
        {
            var transitionNavigationPage = Parent as TransitionNavigationPage;

            transitionNavigationPage.TransitionType = TransitionType.SlideFromLeft;
            Navigation.PushAsync(new Page2());
        }
    }
}