using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using BioHack.Core.Android.Services;

namespace BioHack.Ui.Android
{
	[Activity (Label = "BioHack Actions", MainLauncher = true)]
	public class ActionPickerActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			bool hasMeasures = MeasureService.HasMeasures();

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button getStartedButton = FindViewById<Button> (Resource.Id.GetStartedButton);
			Button addPredictorButton = FindViewById<Button> (Resource.Id.AddPredictorButton);
			Button addOutcomeButton = FindViewById<Button> (Resource.Id.AddOutcomeButton);

			if (hasMeasures) {
				getStartedButton.Text = "Edit Measures";
				addPredictorButton.Visibility = ViewStates.Visible;
				addOutcomeButton.Visibility = ViewStates.Visible;
			} else {
				getStartedButton.Text = "Welcome! Get Started";
				addPredictorButton.Visibility = ViewStates.Gone;
				addOutcomeButton.Visibility = ViewStates.Gone;
			}

			getStartedButton.Click += delegate {
			};
		}
	}
}


