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
using Android;

namespace PadillaMelitonAssn3
{
    [Activity(Label = "FourthActivity")]
    public class FourthActivity : Activity
    {
        TextView tvMANUFACTURERData;
        TextView tvMODELData;
        TextView tvPRODUCTData;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.FourthLayout);

            // Connect buttons
            Button btnGetData = (Button)FindViewById(Resource.Id.btnGetData);

            // Create methods
            btnGetData.Click += btnGetData_Click;

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            tvMANUFACTURERData = (TextView)FindViewById(Resource.Id.tvMANUFACTURERData);
            tvMODELData = (TextView)FindViewById(Resource.Id.tvMODELData);
            tvPRODUCTData = (TextView)FindViewById(Resource.Id.tvPRODUCTData);
            // Get data
            String deviceName = Android.OS.Build.Model;
            String deviceMan = Android.OS.Build.Manufacturer;
            string deviceProduct = Android.OS.Build.Product;
            // Output data
            tvMANUFACTURERData.Text = deviceMan;
            tvMODELData.Text = deviceName;
            tvPRODUCTData.Text = deviceProduct;

        }
    }
}