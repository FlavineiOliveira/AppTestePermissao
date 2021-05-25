using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.Threading.Tasks;

namespace AppTestePermissao.ViewModels
{
    public class PermissaoViewModel : ViewModelBase
    {
        public override async Task Confirmar()
        {
            if (IsBusy)
                return;

            try
            {
                PermissionStatus status = await CrossPermissions.Current.CheckPermissionStatusAsync<LocationPermission>();

                if(status != PermissionStatus.Granted)
                {
                    status = await CrossPermissions.Current.RequestPermissionAsync<LocationPermission>();
                }

                status = await CrossPermissions.Current.CheckPermissionStatusAsync<LocationPermission>();
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
