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
    public interface IItemClickListener
    {
        void OnClick(View itemView, int position, bool isLongClick);
    }
}
