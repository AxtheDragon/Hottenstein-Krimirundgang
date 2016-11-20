using System;
using System.Collections.Generic;

using Android.App;
using System.IO;

namespace Krimirundgang
{
    class TourCollection
    {
        public List<Tour> AvailableTours(Activity activity)
        {
            var files = activity.Assets.List("tours\\");
            var tours = new List<Tour>();
            string content;

            foreach (var tourName in files)
            {
                try
                {   // Open the text file using a stream reader.
                    using (StreamReader sr = new StreamReader(tourName))
                    {
                        // Read the stream to a string
                        content = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                    continue;
                }
                var tour = new Tour(tourName, content);
                tours.Add(tour);
            }

            return tours;
        }
    }
}