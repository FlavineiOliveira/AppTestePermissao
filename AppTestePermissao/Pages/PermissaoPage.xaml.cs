using AppTestePermissao.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTestePermissao.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PermissaoPage : ContentPage
    {
        public PermissaoPage()
        {
            InitializeComponent();

            BindingContext = new PermissaoViewModel();
        }
    }
}