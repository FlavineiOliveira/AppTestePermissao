using AppTestePermissao.Pages;
using Xamarin.Forms;

namespace AppTestePermissao
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PermissaoPage();
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
