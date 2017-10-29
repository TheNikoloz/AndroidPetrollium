using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.Collections.Generic;
using Android.Content;
using Newtonsoft.Json;
using Petrolium.DataObjects;
using Petrolium.Adapters;
using Petrolium.Utilities;
using Petrolium.Activities;
using Android.Views;

namespace Petrolium.Adapters
{
    public class Adapter : BaseAdapter<Company>
    {
        public Adapter()
        {
        }

        public Company this[int position] => throw new NotImplementedException();

        public override int Count => throw new NotImplementedException();

        public override long GetItemId(int position)
        {
            throw new NotImplementedException();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }
    }
}
