

using System.ComponentModel;

namespace BuildingApp.BaseClasses
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property=null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
        }
    }
}
