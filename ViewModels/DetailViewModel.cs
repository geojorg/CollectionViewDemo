using CollectionViewDemo.Data;
using CollectionViewDemo.Models;
using System;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewDemo.ViewModels
{
    [QueryProperty("Name", "persondetaildata")]
    public class DetailViewModel : BaseViewModel
    {
        private string _personname;
        private string _company;
        private string _age;

        public string Name
        {
            set
            {
                Item name = ItemData.Items.FirstOrDefault(n => n.Name == Uri.UnescapeDataString(value));
                if (name != null)
                {
                    PersonName = name.Name;
                    Company = name.Company;
                    Age = name.Age;
                }
            }
        }

        public string PersonName
        {
            get { return _personname; }
            set { SetProperty(ref _personname, value); }
        }
        
        public string Company
        {
            get { return _company; }
            set { SetProperty(ref _company, value); }
        }
        public string Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        public ICommand BackCommand
        {
            get
            {
                return new Command(() =>
                { Shell.Current.GoToAsync("//CollectionPage"); });
            }
        }
    }
}
