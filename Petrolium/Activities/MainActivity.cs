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
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        CompanyRecyclerAdapter mAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

          
            _companies = DataRequest.GetDataFromApi<List<Company>>(url);

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.container);
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            mAdapter = new CompanyRecyclerAdapter(this, _companies);
            mRecyclerView.SetAdapter(mAdapter);
        
        }
    }
}

