using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace PadillaMelitonAssn3
{
    [Activity(Label = "PadillaMelitonAssn3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Connect buttons to both layouts
            Button btnSecondActivity = (Button)FindViewById(Resource.Id.btnSecondActivity);
            Button btnThirdActivity = (Button)FindViewById(Resource.Id.btnThirdActivity);
            Button btnFourthActivity = (Button)FindViewById(Resource.Id.btnFourthActivity);
            Button btnFifthActivity = (Button)FindViewById(Resource.Id.btnFifthActivity);

            // Create method to go to next page
            btnSecondActivity.Click += btnSecondActivity_Click;
            btnThirdActivity.Click += btnThirdActivity_Click;
            btnFourthActivity.Click += btnFourthActivity_Click;
            btnFifthActivity.Click += btnFifthActivity_Click;
        }

        private void btnFifthActivity_Click(object sender, System.EventArgs e)
        {
            var FifthActivity = new Intent(this, typeof(FifthActivity));
            StartActivity(FifthActivity);
        }

        private void btnFourthActivity_Click(object sender, System.EventArgs e)
        {
            var FourthActivity = new Intent(this, typeof(FourthActivity));
            StartActivity(FourthActivity);
        }

        private void btnThirdActivity_Click(object sender, System.EventArgs e)
        {
            var ThirdActivity = new Intent(this, typeof(ThirdActivity));
            StartActivity(ThirdActivity);
        }

        private void btnSecondActivity_Click(object sender, System.EventArgs e)
        {
            var SecondActivity = new Intent(this, typeof(SecondActivity));
            StartActivity(SecondActivity);
        }
    }
}

