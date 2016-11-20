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
    public class Tour
    {
        public string Name { get; set; }

        public string Content { get; set; }

        public Tour(string name, string content = null)
        {
            Name = name;
            Content = content;
        }
    }
}