using System;
using TiposPagina.Pages.Carrousel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPagina
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Introducao();
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
