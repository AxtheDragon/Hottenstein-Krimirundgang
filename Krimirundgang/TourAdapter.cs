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

       // Create a new Stop CardView (invoked by the layout manager):
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            // Inflate the StopCardView for the title:
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.StopCardView,parent,false);

            // Create a ViewHolder to find and hold these view references, and
            // register OnClick with the view holder:
            return new StopViewHolder(itemView, OnClick);
        }

        // Fill in the contents of the Stop card (invoked by the layout manager):
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            StopViewHolder viewHolder = holder as StopViewHolder;

            // Set the both TexView's in this ViewHolder's StopCardView
            // from this position in the photo album:
            viewHolder.Title.Text = mTour[position].Title;
            viewHolder.Preview.Text = mTour[position].Preview;
        }

        // Return the number of stops available in the tour:
        public override int ItemCount
        {
            get { return mTour.NumStops; }
        }

        // Raise an event when the item-click takes place:
        void OnClick(int position)
        {
            if (ItemClick != null)
                {
                ItemClick(this, position);
                }
        }

    }
}