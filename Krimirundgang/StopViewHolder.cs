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
using Android.Support.V7.Widget;

namespace Krimirundgang
{
    public class StopViewHolder : RecyclerView.ViewHolder
    {
        public TextView Title { get; private set; }
        public TextView Preview { get; private set; }

        public StopViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            // Locate and cache view references:
            Title = itemView.FindViewById<TextView>(Resource.Id.textView1);
            Preview = itemView.FindViewById<TextView>(Resource.Id.textView2);

            // Detect user clicks on the item view and report which item
            // was clicked (by position) to the listener:
            itemView.Click += (sender, e) => listener(base.Position);
        }
    }
}