using Android.App;
using Android.Widget;
using Android.OS;
using PolishedToast_Xamarin;

namespace PolishtedToast_App
{
    [Activity(Label = "PolishtedToast_App", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button ButtonError = FindViewById<Button>(Resource.Id.ButtonError);
            Button ButtonDefault = FindViewById<Button>(Resource.Id.ButtonDefault);
            Button ButtonInfo = FindViewById<Button>(Resource.Id.ButtonInfo);
            Button ButtonSuccess = FindViewById<Button>(Resource.Id.ButtonSuccess);
            Button ButtonWarning = FindViewById<Button>(Resource.Id.ButtonWarning);

            ButtonError.Click += ButtonError_Click;
            ButtonDefault.Click += ButtonDefault_Click;
            ButtonInfo.Click += ButtonInfo_Click;
            ButtonSuccess.Click += ButtonSuccess_Click;
            ButtonWarning.Click += ButtonWarning_Click;
        }

        private void ButtonWarning_Click(object sender, System.EventArgs e)
        {
            PolishedToast.Warning(this, "Warning", ToastLength.Long, false).Show();
        }

        private void ButtonSuccess_Click(object sender, System.EventArgs e)
        {
            PolishedToast.Success(this, "Success").Show();
        }

        private void ButtonInfo_Click(object sender, System.EventArgs e)
        {
            PolishedToast.Info(this, "Info").Show();
        }

        private void ButtonDefault_Click(object sender, System.EventArgs e)
        {
            PolishedToast.Create(this, "Default").Show();
        }

        private void ButtonError_Click(object sender, System.EventArgs e)
        {
            PolishedToast.Error(this, "Error").Show();
        }
    }
}

