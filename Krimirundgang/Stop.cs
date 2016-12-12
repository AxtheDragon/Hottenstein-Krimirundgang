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
    public class Stop
    {
        public Stop()
        {

        }
        //Stop ID 
        private readonly int mStopID;
        public int StopID { get { return mStopID; } }

        //Title of the stop
        private readonly string mTitle;
        public string Title { get { return mTitle; } }

        //Latitude of the Stop location
        private readonly double mLat;
        public double Lat { get { return mLat; } }

        //Longitude of the Stop location
        private readonly double mLong;
        public double Long { get { return mLong; } }

        //Information Text of the Stop
        private readonly string mText;
        public string Text { get { return mText; } }
        
        //Preview Text
        private readonly string mPreview;
        public string Preview { get { return mPreview; } }
    }
}