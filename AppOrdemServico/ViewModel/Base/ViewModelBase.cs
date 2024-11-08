using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OnetCleaning.ViewModel.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //private PopUpModalLoad PopUpModalLoad { get; set; } = new PopUpModalLoad();

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ViewModelBase()
        {
            PropertyChanged += ViewModelBase_PropertyChanged;
        }

        private async void ViewModelBase_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IsBusy))
            {
                await ShowLoadingView();
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set 
            {
                _isBusy = value;
                OnPropertyChanged();
            } 
        }

        protected async Task ShowLoadingView()
        {
            try
            {
                // Page? page = NavigationHelpers.GetCurrentPage();
                //
                // if (IsBusy)
                // {
                //     PopUpModalLoad = new PopUpModalLoad();
                //     page?.ShowPopupAsync(PopUpModalLoad);
                // }
                // else
                // {
                //     PopUpModalLoad?.CloseAsync();
                //     PopUpModalLoad = null;
                // }
            }
            catch (Exception ex)
            {
                string teste = "";
            }
        }
    }
}
