using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Petrolium.DataObjects;
using Petrolium.Activities;
using Petrolium.Adapters;
using Newtonsoft.Json;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace Petrolium.Activities
{

    [Activity(Label = "DetailsActivity", Theme = "@style/AppTheme")]
    public class DetailsActivity : AppCompatActivity
    {
        List<Details> _details = new List<Details>();
        RecyclerView MyRecyclerView;
        RecyclerView.LayoutManager MyLayoutManager;
        DetailRecyclerViewAdapter MyAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainDetails);
            // Create your application here
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>
                                              (Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            var intent = Intent.GetStringExtra(GetText(Resource.String.DetailsStringToJSON));

            _details = JsonConvert.DeserializeObject<List<Details>>(
                Intent.GetStringExtra(GetText(Resource.String.DetailsStringToJSON)));


            MyRecyclerView = FindViewById<RecyclerView>
                (Resource.Id.MainDetails);
            MyLayoutManager = new LinearLayoutManager(this);
            MyRecyclerView.SetLayoutManager(MyLayoutManager);

            MyAdapter = new DetailRecyclerViewAdapter(this, _details);
            MyRecyclerView.SetAdapter(MyAdapter);


        }
    }
}
