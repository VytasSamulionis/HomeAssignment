using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    public class BundleItem
    {
        public string BundleID
        {
            get { return _bundleID; }
        }

        private Bundle _bundle = null;
        private string _bundleID = string.Empty;

        public BundleItem(Bundle bundle, string bundleID)
        {
            _bundle = bundle;
            _bundleID = bundleID;
        }

        public override string ToString()
        {
            return _bundle.name;
        }
    }
}
