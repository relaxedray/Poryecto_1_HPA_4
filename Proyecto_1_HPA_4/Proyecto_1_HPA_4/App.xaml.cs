using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_1_HPA_4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new LoginUi());
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
