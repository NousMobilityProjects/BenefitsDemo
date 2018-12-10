using System;
using Xamarin.Forms;

namespace BenefitsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(); // View Model Binding
        }
    }
}
