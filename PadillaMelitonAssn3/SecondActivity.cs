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
using Android.Util;

namespace PadillaMelitonAssn3
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        TextView tvScreenWidthData;
        TextView tvScreenHeightData;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SecondLayout);

            // Set buttons and text views

            Button btnGetData = (Button)FindViewById(Resource.Id.btnGetData);

            // Create methods
            btnGetData.Click += btnGetData_Click;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            tvScreenWidthData = (TextView)FindViewById(Resource.Id.tvScreenWidthData);
            tvScreenHeightData = (TextView)FindViewById(Resource.Id.tvScreenHeightData);
            Display displayCurrent = WindowManager.DefaultDisplay;
            DisplayMetrics met = new DisplayMetrics();
            displayCurrent.GetRealMetrics(met);
            tvScreenWidthData.Text = met.WidthPixels.ToString();
            tvScreenHeightData.Text = met.HeightPixels.ToString();
        }
    }
}