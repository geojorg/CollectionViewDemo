using CollectionViewDemo.Data;
using CollectionViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewDemo.ViewModels
{
    public class CollectionViewModel : BaseViewModel
    {
        private Item _selection;
        private string _filter;
        private IList<Item> _itemlist;

        public IList<Item> ItemList 
        { 
            get { return _itemlist; }
            set { SetProperty(ref _itemlist, value); }
        }

        public CollectionViewModel()
        {
            ItemList = ItemData.Items;
        }

        public string Filter
        {
            get { return _filter; }
            set
            {
                SetProperty(ref _filter, value);
                Search();
            }
        }
        
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

        public ICommand SearchCommand => new Command(Search);
        public void Search()
        {
            if (string.IsNullOrWhiteSpace(_filter))
            {
                ItemList = ItemData.Items;
            }
            else
            {
                ItemList = ItemData.Items.Where(x => x.Name.StartsWith(_filter, StringComparison.InvariantCultureIgnoreCase))
                        .ToList<Item>();
            }
        }
    }
}
