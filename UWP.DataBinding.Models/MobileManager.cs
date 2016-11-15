using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.DataBinding.Mobile;

namespace UWP.DataBinding.Mobile
{
    public class MobileManager
    {
        private List<BrandViewModel> _items;


        public List<BrandViewModel> GetAll()
        {
            Device _device = new Device();
            BrandViewModel _brand = new BrandViewModel();

            this._items = new List<BrandViewModel>();

            _brand = new BrandViewModel();
            _brand.No = 1;
            _brand.Name = "APPLE";

            _brand.Devices.Add(new Device() { No = 1, Name = "APPLE IPhone 7 Plus", Price = 28900 });
            _brand.Devices.Add(new Device() { No = 2, Name = "APPLE IPhone 7", Price = 24900 });
            _brand.Devices.Add(new Device() { No = 3, Name = "APPLE IPhone 6S Plus", Price = 21900 });
            _brand.Devices.Add(new Device() { No = 4, Name = "APPLE IPhone 6S", Price = 18900 });

            this._items.Add(_brand);



            _brand = new BrandViewModel();
            _brand.No = 2;
            _brand.Name = "MICROSOFT";

            _brand.Devices.Add(new Device() { No = 1, Name = "MICROSOFT LUMIA 950 XL", Price = 24900 });
            _brand.Devices.Add(new Device() { No = 2, Name = "MICROSOFT LUMIA 950", Price = 21900 });
            _brand.Devices.Add(new Device() { No = 3, Name = "MICROSOFT LUMIA 650 XL", Price = 6900 });
            _brand.Devices.Add(new Device() { No = 4, Name = "MICROSOFT LUMIA 650", Price = 5900 });

            this._items.Add(_brand);



            _brand = new BrandViewModel();
            _brand.No = 3;
            _brand.Name = "SAMSUNG";

            _brand.Devices.Add(new Device() { No = 1, Name = "SAMSUNG GALAXY NOTE 7", Price = 22900 });
            _brand.Devices.Add(new Device() { No = 2, Name = "SAMSUNG GALAXY S7", Price = 18900 });

            this._items.Add(_brand);



            _brand = new BrandViewModel();
            _brand.No = 4;
            _brand.Name = "HTC";

            _brand.Devices.Add(new Device() { No = 1, Name = "HTC Desire 10", Price = 20900 });
            _brand.Devices.Add(new Device() { No = 2, Name = "HTC Desire 9", Price = 17900 });

            this._items.Add(_brand);



            return this._items;
        }
    }
}
