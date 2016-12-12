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

    public class StopViewHolder : RecyclerView.ViewHolder
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
        // public event EventHandler<int> ItemClick;

        // Underlying data set (a Tour:
        public Tour mTour;

        // Load the adapter with the data set (tour) at construction time:
        public TourAdapter(Tour myTour)
        {
            mTour = myTour;
        }

        // Create a new Stop CardView (invoked by the layout manager): 
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            // Inflate the CardView for the photo:
            View itemView =
                LayoutInflater.From(parent.Context)
                              .Inflate(Resource.Layout.StopCardView,
                                       parent,
                                       false);

            // Create a ViewHolder to find and hold these view references, and 
            // register OnClick with the view holder:
            return new StopViewHolder(itemView);
        }

        // Fill in the contents of the Stop card (invoked by the layout manager):
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            StopViewHolder vh = holder as StopViewHolder;

            // Set the ImageView and TextView in this ViewHolder's CardView 
            // from this position in the photo album:
            vh.Title.Text = mTour[position].Title;
            vh.Preview.Text = mTour[position].Preview;
        }

        // Return the number of stops available in the tour:
        public override int ItemCount
        {
            get { return mTour.NumStops; }
        }

    }
}