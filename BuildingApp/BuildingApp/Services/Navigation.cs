

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuildingApp.Services
{
    public class Navigation : INavigation
    {
        public Navigation(NavigationPage navigation)
        {
            _navigation = navigation;
        }

        public NavigationPage _pagecurrent
        {
            get { return _navigation; }
        }
        public void Initialize(NavigationPage navigation)
        {
            _navigation = navigation;
        }

        public NavigationPage _navigation;
        public IReadOnlyList<Page> ModalStack
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<Page> NavigationStack
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void InsertPageBefore(Page page, Page before)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Page> PopAsync(bool animated)
        {
            return await _navigation.PopAsync();

        }

        public Task<Page> PopModalAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public async Task PushAsync(Page page)
        {
            await _navigation.PushAsync(page);
        }

        public async Task PushAsync(Page page, bool animated)
        {
            await _navigation.PushAsync(page);

        }

        public Task PushModalAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public void RemovePage(Page page)
        {
            throw new NotImplementedException();
        }

        Task INavigation.PushAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }
    }
}
