using BuildingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BuildingApp.View
{
    public partial class NewEntryView : ContentPage
    {
        public NewEntryView()
        {
            InitializeComponent();
            BindingContext = new Viewmodel.NewEntryViewModel();
        }
         
    }
}
