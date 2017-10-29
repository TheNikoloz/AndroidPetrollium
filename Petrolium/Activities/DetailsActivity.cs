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
using Newtonsoft.Json;

namespace Petrolium.Activities
{

    [Activity(Label = "DetailsActivity")]
    public class DetailsActivity : Activity
    {
        List<Details> _details = new List<Details>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            var intent = Intent.GetStringExtra(GetText(Resource.String.DetailsStringToJSON));

            _details = JsonConvert.DeserializeObject<List<Details>>(
                Intent.GetStringExtra(GetText(Resource.String.DetailsStringToJSON)));



        }
    }
}
