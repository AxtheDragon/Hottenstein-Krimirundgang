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
        //Stop ID 
        public int mStopID;

        //Title of the stop
        public string mTitle;

        //Latitude of the Stop location
        public int mLat;

        //Longitude of the Stop location
        public int mLong;

        //Information Text of the Stop
        public string mText;

        //return Stop ID
        public int StopID
        {
            get { return mStopID; }
        }

        //return Stop Title
        public string Title
        {
            get { return mTitle; }
        }

        //return Latitude
        public int Lat
        {
            get { return mLat; }
        }

        //return Longitude
        public int Long
        {
            get { return mLong; }
        }

        //return Text of the Stop
        public string Text
        {
            get { return mText; }
        }

    }
}