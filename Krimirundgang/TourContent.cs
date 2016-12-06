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

        //Preview Text
        public string mPreview;

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

    public class Tour
    {
        static Stop[] mStopList = {
            new Stop {mStopID = 1,
                      mTitle = "Erster Halt",
                      mLat = 52.0001000,
                      mLong = 40.300000,
                      mPreview = "01 Vorschautext für die Liste",
                      mText = "01 Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
            },
            new Stop {mStopID = 2,
                      mTitle = "Zweiter Halt",
                      mLat = 52.1001000,
                      mLong = 40.400000,
                      mPreview = "02 Vorschautext für die Liste",
                      mText = "02 Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
            },
            new Stop {mStopID = 3,
                      mTitle = "Dritter Halt",
                      mLat = 52.0201000,
                      mLong = 40.600000,
                      mPreview = "03 Vorschautext für die Liste",
                      mText = "03 Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
            },
            new Stop {mStopID = 4,
                      mTitle = "Vierter Stop",
                      mLat = 52.3201000,
                      mLong = 41.000000,
                      mPreview = "04 Vorschautext für die Liste - Hier steht mehr!",
                      mText = "04 Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
            },
            new Stop {mStopID = 5,
                      mTitle = "Fünfter Halt",
                      mLat = 52.8201000,
                      mLong = 41.000000,
                      mPreview = "05 Vorschautext für die Liste",
                      mText = "05 Lorem ipsum dolor sit amet, Hier steht mal was daziwschen consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
            },
            new Stop {mStopID = 6,
                      mTitle = "Sechster Stop",
                      mLat = 51.0201000,
                      mLong = 39.800000,
                      mPreview = "06 Vorschautext für die Liste",
                      mText = "06 Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
            }

        };

        //Array of the Stops that make up the Tour
        private Stop[] mStops;

        //Create and instance copy of the StopList
         public Tour()
        {
            mStops = mStopList;
        }

        //Indexer (read only) for accessing the Stops
        public Stop this[int i]
        {
            get { return mStops[i]; }

    }
}