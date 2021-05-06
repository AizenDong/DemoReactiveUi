using DemoReactiveUi.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoReactiveUi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ColorsDemoPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
