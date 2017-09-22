

using BuildingApp.Command;
using Xamarin.Forms;
using BuildingApp.Services;
namespace BuildingApp.Viewmodel
{
    public class LoginViewModel
    {
        private RelayCommand _loginCommand;
        public Navigation _navigation;

        public RelayCommand LoginCommand => _loginCommand ?? new RelayCommand(DoLogin);
        public LoginViewModel(Navigation navigation)
        {
            _navigation = navigation;
        }
        private async void DoLogin(object obj)
        {
        await  _navigation.PushAsync(new View.MasterViewPage());
        }
      
    }
}
