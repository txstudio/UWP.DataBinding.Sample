using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.DataBinding.Mobile
{
    public class Brand
    {
        public int No { get; set; }
        public string Name { get; set; }
    }

    public class Device
    {
        public int No { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class BrandViewModel : Brand
    {
        public BrandViewModel()
        {
            this.Devices = new List<Device>();
        }

        public List<Device> Devices { get; set; }
    }

}
