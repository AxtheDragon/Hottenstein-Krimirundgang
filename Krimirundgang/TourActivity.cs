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
    [Activity(Label = "TourActivity")]
    public class Activity1 : Activity
    {
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;

        TourAdapter mAdapter;

        Tour mTour;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Prepare Data Source for Recycle View
            mTour = new Tour();

            //Prepare Adapter and pass it its contents
            mAdapter = new TourAdapter(mTour);

            // Set our view from the "Tour" layout resource
            SetContentView(Resource.Layout.Tour);

            //Get reference to recycler view
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            // Plug the adapter into the RecyclerView:
            mRecyclerView.SetAdapter(mAdapter);

            //Initialize Layout Manager
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);
        }
    }

    public class StopViewHolder : Java.Lang.Object
    {
        public TextView Title { get; private set; }
        public TextView Preview { get; private set; }

        public StopViewHolder(View itemView) : base(itemView)
        {
            // Locate and cache view references:
            Title = itemView.FindViewById<TextView>(Resource.Id.textView1);
            Preview = itemView.FindViewById<TextView>(Resource.Id.textView2);
        }
    }

    public class TourAdapter : RecyclerView.Adapter
    {
        // Event handler for item clicks:
        public event EventHandler<int> ItemClick;

        // Underlying data set (a Tour:
        public Tour mTour;

        // Load the adapter with the data set (tour) at construction time:
        public TourAdapter(Tour myTour)
        {
            mTour = myTour;
        }

    }
}