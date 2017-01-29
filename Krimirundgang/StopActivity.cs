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

namespace Krimirundgang
{
    [Activity(Label = "StopActivity")]
    public class StopActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Stop);

            int stopID = savedInstanceState.GetInt("selected_stop", 1);
            Stop stop = new Tour().Stops.First(s => s.StopID == stopID);

            //Get references for Layout elements
            TextView title = FindViewById<TextView>(Resource.Id.textViewTitle);
            TextView longitude = FindViewById<TextView>(Resource.Id.textViewLong);
            TextView latitude = FindViewById<TextView>(Resource.Id.textViewLat);
            TextView text = FindViewById<TextView>(Resource.Id.textViewText);

            title.Text = stop.Title;
            longitude.Text = stop.Long.ToString();
            latitude.Text = stop.Lat.ToString();
            text.Text = stop.Text;

        }
    }
}