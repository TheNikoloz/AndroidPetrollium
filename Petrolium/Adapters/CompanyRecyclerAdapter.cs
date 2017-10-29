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
    public class CompanyRecyclerAdapter : RecyclerView.Adapter
    {
        List<Company> _companies = new List<Company>();
        public CompanyRecyclerAdapter(Context context, List<Company> companies) => _companies = companies;

        public override int ItemCount => _companies.Count;

        private class CompanyViewHolder : ViewHolder
        {
            public ImageView companyImageView
            {
                get;
                set;
            }

            public TextView companyNameView
            {
                get;
                set;
            }

            public CompanyViewHolder(View itemView) : base(itemView)
            {
                companyImageView = itemView.FindViewById<ImageView>(Resource.Id.company_image);
                companyNameView = itemView.FindViewById<TextView>(Resource.Id.company_name);
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            CompanyViewHolder vh = holder as CompanyViewHolder;
                         
            vh.companyImageView.SetImageResource(Resource.Drawable.gulf);
            vh.companyNameView.Text = _companies[position].Name; 
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemview = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Company, parent, false);
            CompanyViewHolder vh = new CompanyViewHolder(itemview);

            return vh;
        }
    }
}
