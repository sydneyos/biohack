using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using BioHack.Core.Andr.Services;

namespace BioHack.Ui.Andr
{
	[Activity (Label = "BioHack Actions", MainLauncher = true)]
	public class ActionPickerActivity : Activity
	{
        Button _getStartedButton;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
            _getStartedButton = FindViewById<Button>(Resource.Id.GetStartedButton);
            ShowControls();

            _getStartedButton.Click += delegate
            {
                StartActivity(typeof(AddMeasureActivity));
            };
		}

	    private void ShowControls()
        {
            Console.WriteLine("Checking for data");
            bool hasMeasures = MeasureService.HasMeasures();
	        Button addPredictorButton = FindViewById<Button> (Resource.Id.AddPredictorButton);
	        Button addOutcomeButton = FindViewById<Button> (Resource.Id.AddOutcomeButton);
	        TextView addPredictorInfo = FindViewById<TextView> (Resource.Id.AddPredictorInfo);
	        TextView addOutcomeInfo = FindViewById<TextView> (Resource.Id.AddOutcomeInfo);
	        ViewStates showControls;

	        if (hasMeasures) {
                _getStartedButton.Text = "Edit Measures";
	            showControls = ViewStates.Visible;
	        } else {
                _getStartedButton.Text = "Welcome! Get Started";
	            showControls = ViewStates.Gone;
	        }
			
	        addPredictorButton.Visibility = showControls;
	        addOutcomeButton.Visibility = showControls;
	        addPredictorInfo.Visibility = showControls;
	        addOutcomeInfo.Visibility = showControls;
	    }

	    protected override void OnResume()
        {
            base.OnResume();
            ShowControls();
        }
	}
}


