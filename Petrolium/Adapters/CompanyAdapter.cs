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
    public class CompanyAdapter : BaseAdapter<Company>
    {
        Context _context;
        List<Company> _companies = new List<Company>();
        LayoutInflater inflater;
        public CompanyAdapter(Context ctx, List<Company> companies)
        {
            _context = ctx;
            _companies = companies;
            inflater = LayoutInflater.From(ctx);
        }

        public override Company this[int position] => _companies[position];

        public override int Count => _companies.Count;

       
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if(view is null)
            {
                view = inflater.Inflate(Resource.Layout.Company, parent, false);
                view.FindViewById<TextView>(Resource.Id.CompanyNameID).Text = 
                    _companies[position].Name;
            }

            return view;
        }
    }
}
