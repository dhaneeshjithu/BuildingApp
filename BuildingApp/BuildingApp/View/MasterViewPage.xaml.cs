
using Xamarin.Forms;

namespace BuildingApp.View
{
    public partial class MasterViewPage : MasterDetailPage
    {
        public MasterViewPage()
        {
            InitializeComponent();
            BindingContext = new Viewmodel.MasterViewModel();
        }

    }
}
