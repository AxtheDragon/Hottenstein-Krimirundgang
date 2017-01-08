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
    public class TourActivity : Activity
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

            // Register the item click handler (below) with the adapter:
            mAdapter.ItemClick += OnItemClick;

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

        void OnItemClick(object sender, int position)
        {
            var tourAdapter = (TourAdapter)sender;
            var stop = tourAdapter.mTour[position];

            Intent intent = new Intent(this, typeof(StopActivity));
            intent.PutExtra("StopId", stop.StopID);
            StartActivity(intent);
        }
    }
}