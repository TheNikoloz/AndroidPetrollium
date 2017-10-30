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
using Petrolium.Adapters;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace Petrolium
{
    [Activity(Label = "Petrolium", MainLauncher = true, Theme = "@style/AppTheme", Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {

        List<Company> _companies = new List<Company>();
        string url = "http://georgianpetroleum.azurewebsites.net/PetrolCompanies";
        RecyclerView MyRecyclerView;
        RecyclerView.LayoutManager MyLayoutmanager;
        CompanyRecyclerAdapter MyAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

          
            _companies = DataRequest.GetDataFromApi<List<Company>>(url);

            MyRecyclerView = FindViewById<RecyclerView>(Resource.Id.container);
            MyLayoutmanager = new LinearLayoutManager(this);
            MyRecyclerView.SetLayoutManager(MyLayoutmanager);

            MyAdapter = new CompanyRecyclerAdapter(this, _companies);
            MyAdapter.ItemClick += OnItemClick;
            MyRecyclerView.SetAdapter(MyAdapter);
        
        }

        private void OnItemClick(object sender, int position)
        {
            Intent intent = new Intent(this, typeof(DetailsActivity));
            intent.PutExtra(GetText(Resource.String.DetailsStringToJSON),
                            JsonConvert.SerializeObject(_companies[position].Fuels));

            StartActivity(intent);
        }
    }
}

