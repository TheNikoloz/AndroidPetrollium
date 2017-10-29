using System;
using Android.Views;
using Android.Widget;
using Java.Lang;
using System.Collections.Generic;
using Android.Content;
using Android.App;
using Android.Provider;
using Petrolium.DataObjects;

namespace Petrolium.Adapters
{
    public class DetailsAdapter : BaseAdapter<Details>
    {
        Context _context;
        List<Details> _details = new List<Details>();
        LayoutInflater inflater;

        public DetailsAdapter(Context context,List<Details> details)
        {
            _context = context;
            _details = details;
        }
        public override Details this[int position] => _details[position];

        public override int Count => _details.Count;

       

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if(view == null)
            {
                inflater.Inflate(Resource.Layout.CompanyDetails, parent, false);
                view.FindViewById<TextView>(Resource.Id.DetailPrice).Text = _details[position].NameGe;
                view.FindViewById<TextView>(Resource.Id.DetailPrice).Text = _details[position].Price.ToString();
                view.FindViewById<TextView>(Resource.Id.DetailOctane).Text = _details[position].Octan?.ToString();
            }

            return view;
        }
    }
}
