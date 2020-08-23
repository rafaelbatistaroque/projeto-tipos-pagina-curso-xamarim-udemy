using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPagina.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void MudarPagina2(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Pagina2());
        }

        private void ChamarModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Modal());
        }
        private void ChamarMaster(object sender, EventArgs e)
        {
            App.Current.MainPage = new MasterDetail.Master();
        }


    }
}