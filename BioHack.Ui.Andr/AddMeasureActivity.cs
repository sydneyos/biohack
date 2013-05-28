using System;
using Android.App;
using Android.OS;
using Android.Widget;
using BioHack.Core.Andr.Services;
using BioHack.Core.Domain;

namespace BioHack.Ui.Andr
{
	[Activity (Label = "Add a Measure", MainLauncher = false)]			
	public class AddMeasureActivity : Activity
	{
        Spinner _measureTypes;
        Spinner _dataTypes;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			
			// Set our view from the "main" layout resource
            SetContentView(Resource.Layout.AddMeasure);// Create your application here

            _dataTypes = FindViewById<Spinner>(Resource.Id.DataType);
            _dataTypes.ItemSelected += SpinnerItemSelected;
            _dataTypes.Adapter = new ArrayAdapter<DataTypes>(this.BaseContext, Android.Resource.Layout.SimpleSpinnerItem, DataTypes.Array);

            _measureTypes = FindViewById<Spinner>(Resource.Id.MeasureType);
            _measureTypes.Adapter = new ArrayAdapter(this.BaseContext, Android.Resource.Layout.SimpleSpinnerItem, MeasureTypes.Array);

            Button save = FindViewById<Button>(Resource.Id.Save);
            save.Click += Save;
		}

        void Save(object sender, EventArgs e)
        {
            string selectedMeasure = _measureTypes.SelectedItem.ToString();
            string selectedDataType = _dataTypes.SelectedItem.ToString();
            MeasureTypes type = MeasureTypes.GetFromDisplay(selectedMeasure);
            DataTypes dataType = DataTypes.GetFromDisplay(selectedDataType);
            TextView measureName = FindViewById<TextView>(Resource.Id.MeasureName);
            Measure measure;
            if (type == MeasureTypes.Outcome)
            {
                measure = new Outcome(dataType, measureName.Text);
            }
            else
            {
                measure = new Predictor(dataType, measureName.Text);
            }
            MeasureService.SaveMeasure(measure);
            Finish();
        }

	    private static void SpinnerItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;

            var value = spinner.GetItemAtPosition(e.Position);
        }
	}
}

