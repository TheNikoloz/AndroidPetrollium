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
using Petrolium.Utilities;
using Petrolium.Activities;
using Android.Support.V7.Widget;
using Android.Views;
using static Android.Support.V7.Widget.RecyclerView;
namespace Petrolium.Adapters
{
    public class DetailRecyclerViewAdapter : RecyclerView.Adapter
    {
        List<Details> _details = new List<Details>();
        Context _context;
        public DetailRecyclerViewAdapter(Context context, List<Details> details)
        {
            _details = details;
            _context = context;
        }

        public override int ItemCount => _details.Count;

        private class DetailsViewHolder : RecyclerView.ViewHolder
        {
            public TextView Detailname
            {
                get;
                set;
            }

            public TextView DetailPrice
            {
                get;
                set;
            }

            public TextView DetailOctane
            {
                get;
                set;
            }

            public DetailsViewHolder(View view) : base(view)
            {
                Detailname = view.FindViewById<TextView>
                                 (Resource.Id.DetailName);
                DetailPrice = view.FindViewById<TextView>
                                  (Resource.Id.DetailPrice);
                DetailOctane = view.FindViewById<TextView>
                                   (Resource.Id.DetailOctane);
            }
        }


        public override void OnBindViewHolder(ViewHolder holder, int position)
        {
            DetailsViewHolder viewHolder = holder as DetailsViewHolder;

            viewHolder.Detailname.Text = _details[position].NameGe;
            viewHolder.DetailPrice.Text = _details[position].Price.ToString();
            viewHolder.DetailOctane.Text = _details[position]?.Octan?.ToString();

        }

        public override ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View detailsView = LayoutInflater.From(parent.Context).
                                             Inflate(Resource.Layout.CompanyDetails, parent, false);
            DetailsViewHolder viewHolder = new DetailsViewHolder(detailsView);

            return viewHolder;
        }
    }
}
