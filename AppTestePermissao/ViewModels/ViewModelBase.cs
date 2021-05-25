using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTestePermissao.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Attributes

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }
        #endregion

        #region Commands

        private ICommand confirmarCommand;

        public ICommand ConfirmarCommand
        {
            get { return confirmarCommand; }
            set
            {
                confirmarCommand = value;
                OnPropertyChanged(nameof(ConfirmarCommand));
            }
        }

        #endregion

        public ViewModelBase()
        {
            ConfirmarCommand = new Command(async () => await Confirmar());
        }

        public virtual Task Confirmar()
        {
            return Task.FromResult(false);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
