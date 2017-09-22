using System;

using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuildingApp.Services
{
    public interface IPageService
    {
        void Map(Type pageType, Type viewModelType);

        Task<Page> Build(Type pageType, object parameter);

        object GetBindingContext(Type pageType);

    }
}
