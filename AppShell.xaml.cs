using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}