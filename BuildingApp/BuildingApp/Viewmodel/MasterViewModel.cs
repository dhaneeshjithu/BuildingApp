using BuildingApp.BaseClasses;
using BuildingApp.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuildingApp.Viewmodel
{
    public class MasterViewModel : BaseViewModel
    {
        private RelayCommand _newEntryCommand;
        private bool _isPresented;

        #region Properties
        public bool IsPresented
        {
            get { return _isPresented; }
            set
            {
                _isPresented = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public MasterViewModel()
        {
            IsPresented = false;
        }
        public RelayCommand EntryCommand => _newEntryCommand ?? new RelayCommand(EntryAdd);

        private void EntryAdd(object obj)
        {
            var mainPage = ((Application.Current.MainPage as NavigationPage).CurrentPage as NavigationPage).CurrentPage as MasterDetailPage;
            mainPage.Detail = new View.NewEntryView();
            IsPresented = false;

        }
    }
}
