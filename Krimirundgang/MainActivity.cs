using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Runtime;
using Android.Views;


namespace Krimirundgang
{
    [Activity(Label = "Krimirundgang", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            //Get references for Layout elements
            Button firstButton = FindViewById<Button>(Resource.Id.button1);
            TextView text = FindViewById<TextView>(Resource.Id.textView1);

            //Simple Button click event
            firstButton.Click += (object sender, EventArgs e) =>
            {

            };
        }
    }
}

