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
    [Activity(Label = "secondActivity")]
    public class secondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Button secondPageButton = FindViewById<Button>(Resource.Id.pagetwobutton);
            TextView text2 = FindViewById<TextView>(Resource.Id.textView2);

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second);

            secondPageButton.Click += (object sender, EventArgs e) =>
            {
                text2.Visibility = ViewStates.Invisible;
            };
        }
    }
}