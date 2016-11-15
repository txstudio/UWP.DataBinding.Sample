using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using UWP.DataBinding.Mobile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP.DataBinding.Pivot
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<BrandViewModel> _viewModel;
        private readonly MobileManager _manager;

        public MainPage()
        {
            this.InitializeComponent();
            
            this._viewModel = new ObservableCollection<BrandViewModel>();
            
            this._manager = new MobileManager();
            this._manager.GetAll().ForEach(x => this._viewModel.Add(x));
        }
        
        private async void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var _selectedItem = (Device)e.ClickedItem;

            this.NameTextBlock.Text = _selectedItem.Name;
            this.PriceTextBlock.Text = String.Format("{0:0.00}", _selectedItem.Price);
        }
    }
}
