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
using Android.Net;

namespace PadillaMelitonAssn3
{
    [Activity(Label = "ThirdActivity")]
    public class ThirdActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ThirdLayout);

            // Connect check box and radio buttons
            Button btnTextConnection = (Button)FindViewById(Resource.Id.btnTestConnection);
            

            // Method
            btnTextConnection.Click += btnTextConnection_Click;

        }

        private void btnTextConnection_Click(object sender, EventArgs e)
        {
            CheckBox cbIntrnetConnection = (CheckBox)FindViewById(Resource.Id.cbInternetConnection);
            RadioButton radioWiFi = (RadioButton)FindViewById(Resource.Id.radioWiFi);
            RadioButton radioMobileData = (RadioButton)FindViewById(Resource.Id.radioMobileData);
            RadioButton radioEthernet = (RadioButton)FindViewById(Resource.Id.radioEthernet);
            RadioButton radioWiMax = (RadioButton)FindViewById(Resource.Id.radioWiMax);
            // Test if internt is connected
            ConnectivityManager connectivityManager = (ConnectivityManager)GetSystemService(ConnectivityService);

            NetworkInfo networkInfo = connectivityManager.ActiveNetworkInfo;
            bool isOnline = networkInfo.IsConnected;

            bool isWifi = networkInfo.Type == ConnectivityType.Wifi;
            if (isOnline)
            {
                // Check box for internet and enable radio
                cbIntrnetConnection.Checked = true;
                radioWiFi.Checked = true;
            }
            else
            {
                // Make sure box is uncheked
                cbIntrnetConnection.Checked = false;
            }
        }
    }
}