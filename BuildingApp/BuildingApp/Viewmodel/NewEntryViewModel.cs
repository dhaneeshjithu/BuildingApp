using BuildingApp.BaseClasses;
using BuildingApp.Command;
using BuildingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuildingApp.Viewmodel
{
    public class NewEntryViewModel : BaseViewModel
    {


        public NewEntryViewModel()
        {
            ImageList = new ObservableCollection<ImageSource>();
        }

        public ObservableCollection<ImageSource> ImageList
        {
            get { return _imageList; }
            set
            {
                _imageList = value;
                OnPropertyChanged();
            }
        }
        public ImageSource SelectedImage
        {
            get { return _selectedImage; }
            set
            {
                _selectedImage = value;
                OnPropertyChanged();
            }
        }
        private RelayCommand _browseCommand;
        private ImageSource _selectedImage;
        private ObservableCollection<ImageSource> _imageList;

        public RelayCommand BrowseCommand => _browseCommand ?? new RelayCommand(BrowseImage);


        private async void BrowseImage(object obj)
        {
            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();
            if (stream != null)
            {

                SelectedImage = ImageSource.FromStream(() => stream);

                ImageList.Add(SelectedImage);

                //TapGestureRecognizer recognizer = new TapGestureRecognizer();
                //recognizer.Tapped += (sender2, args) =>
                //{
                //    (MainPage as ContentPage).Content = stack;
                //    pickPictureButton.IsEnabled = true;
                //};
                //image.GestureRecognizers.Add(recognizer);

                //(MainPage as ContentPage).Content = image;
            }
            else
            {
                // pickPictureButton.IsEnabled = true;
            }
        }
    }
}
