using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Locations;
using Android.Util;

namespace Krimirundgang
{
    [Activity(Label = "Krimirundgang", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //Setup location services
        LocationManager locMgr;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.start);          
        }
}
}