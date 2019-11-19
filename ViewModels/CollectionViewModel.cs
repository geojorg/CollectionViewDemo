using CollectionViewDemo.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewDemo.ViewModels
{
    public class CollectionViewModel : BaseViewModel
    {
        private Item _selection;

        public ObservableCollection<Item> Items { get; private set; }

        public Item Selection
        {
            get { return _selection; }
            set { SetProperty(ref _selection, value); }
        }

        public ICommand SelectionCommand => new Command(ItemSelected);
        private async void ItemSelected()
        {
            if (Selection != null)
            {
                var persondetaildata = Selection.Name;
                await Shell.Current.GoToAsync($"//DetailPage?persondetaildata={persondetaildata}");
                Selection = null;
            }
        }
    }
}
