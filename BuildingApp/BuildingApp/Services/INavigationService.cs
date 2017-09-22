

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuildingApp.Services
{
public    interface INavigationService
    {
        //
        // Summary:
        //     Gets the modal navigation stack.
        //
        // Remarks:
        //     To be added.
        IReadOnlyList<Page> ModalStack { get; }
        //
        // Summary:
        //     Gets the stack of pages in the navigation.
        //
        // Remarks:
        //     To be added.
        IReadOnlyList<Page> NavigationStack { get; }

        //
        // Summary:
        //     Inserts a page in the navigation stack before an existing page in the stack.
        //
        // Parameters:
        //   page:
        //     The page to add.
        //
        //   before:
        //     The existing page, before which page will be inserted.
        //
        // Remarks:
        //     To be added.
        void InsertPageBefore(Page page, Page before);
        //
        // Summary:
        //     Asynchronously removes the most recent Xamarin.Forms.Page from the navigation
        //     stack.
        //
        // Returns:
        //     The Xamarin.Forms.Page that had been at the top of the navigation stack.
        //
        // Remarks:
        //     To be added.
        Task<Page> PopAsync();
        //
        // Summary:
        //     Asynchronously removes the most recent Xamarin.Forms.Page from the navigation
        //     stack, with optional animation.
        //
        // Parameters:
        //   animated:
        //     To be added.
        //
        // Returns:
        //     To be added.
        //
        // Remarks:
        //     To be added.
        Task<Page> PopAsync(bool animated);
        //
        // Summary:
        //     Asynchronously dismisses the most recent modally presented Xamarin.Forms.Page.
        //
        // Returns:
        //     An awaitable Task<Page>, indicating the PopModalAsync completion. The Task.Result
        //     is the Page that has been popped.
        //
        // Remarks:
        //     The following example shows PushModal and PopModal usage:
        //     Application developers must await the result of Xamarin.Forms.INavigation.PushModal
        //     and Xamarin.Forms.INavigation.PopModal. Calling System.Threading.Tasks.Task.Wait
        //     may cause a deadlock if a previous call to Xamarin.Forms.INavigation.PushModal
        //     or Xamarin.Forms.INavigation.PopModal has not completed.
        Task<Page> PopModalAsync();
        //
        // Summary:
        //     Asynchronously dismisses the most recent modally presented Xamarin.Forms.Page,
        //     with optional animation.
        //
        // Parameters:
        //   animated:
        //     To be added.
        //
        // Returns:
        //     To be added.
        //
        // Remarks:
        //     To be added.
        Task<Page> PopModalAsync(bool animated);
        //
        // Summary:
        //     Pops all but the root Xamarin.Forms.Page off the navigation stack.
        //
        // Returns:
        //     A task representing the asynchronous dismiss operation.
        //
        // Remarks:
        //     To be added.
        Task PopToRootAsync();
        //
        // Summary:
        //     Pops all but the root Xamarin.Forms.Page off the navigation stack, with optional
        //     animation.
        //
        // Parameters:
        //   animated:
        //     To be added.
        //
        // Returns:
        //     To be added.
        //
        // Remarks:
        //     To be added.
        Task PopToRootAsync(bool animated);
        //
        // Summary:
        //     Asynchronously adds a Xamarin.Forms.Page to the top of the navigation stack.
        //
        // Parameters:
        //   page:
        //     The Xamarin.Forms.Page to be pushed on top of the navigation stack.
        //
        // Returns:
        //     A task representing the asynchronous dismiss operation.
        //
        // Remarks:
        //     The following example shows Xamarin.Forms.INavigation.Push and Xamarin.Forms.INavigation.Pop
        //     usage:
        Task PushAsync(Page page);
        //
        // Summary:
        //     Asynchronously adds a Xamarin.Forms.Page to the top of the navigation stack,
        //     with optional animation.
        //
        // Parameters:
        //   page:
        //     To be added.
        //
        //   animated:
        //     To be added.
        //
        // Returns:
        //     To be added.
        //
        // Remarks:
        //     To be added.
        Task PushAsync(Page page, bool animated);
        //
        // Summary:
        //     Presents a Xamarin.Forms.Page modally.
        //
        // Parameters:
        //   page:
        //     The Xamarin.Forms.Page to present modally.
        //
        // Returns:
        //     An awaitable Task, indicating the PushModal completion.
        //
        // Remarks:
        //     The following example shows PushModalAsync and PopModalAsync usage:
        Task PushModalAsync(Page page);
        //
        // Summary:
        //     Presents a Xamarin.Forms.Page modally, with optional animation.
        //
        // Parameters:
        //   page:
        //     To be added.
        //
        //   animated:
        //     To be added.
        //
        // Returns:
        //     To be added.
        //
        // Remarks:
        //     To be added.
        Task PushModalAsync(Page page, bool animated);
        //
        // Summary:
        //     Removes the specified page from the navigation stack.
        //
        // Parameters:
        //   page:
        //     To be added.
        //
        // Remarks:
        //     To be added.
        void RemovePage(Page page);
    }
}
