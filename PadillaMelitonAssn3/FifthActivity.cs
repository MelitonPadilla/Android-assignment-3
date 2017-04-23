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

namespace PadillaMelitonAssn3
{
    [Activity(Label = "FifthActivity")]
    public class FifthActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.Title = "Meliton Padilla-Neri";
            // Create your application here
            SetContentView(Resource.Layout.FifthLayout);
        }
    }
}