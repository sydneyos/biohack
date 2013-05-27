using System;
using System.Collections.Generic;
using BioHack.Core.Domain;
using BioHack.Core.Repositories;

namespace BioHack.Core.Android.Services {

	/// <summary>
	/// Service classes are an abstraction on the data access layers
	/// </summary>
	public static class MeasureService {

		static MeasureService ()
		{
		}

		public static Predictor GetPredictor(int id)
		{
			return MeasureRepository.GetPredictor(id);
		}

		public static Outcome GetOutcome(int id)
		{
			return MeasureRepository.GetOutcome(id);
		}

		public static IList<Measure> GetMeasures (MeasureTypes type)
		{
			return new List<Measure>(MeasureRepository.GetMeasures(type));
		}
		
		public static int SaveMeasure (Measure item)
		{
			return MeasureRepository.SaveMeasure(item);
		}
		
		public static void DeleteMeasure(int id)
		{
			MeasureRepository.DeleteMeasure(id);
		}

		public static bool HasMeasures() {
			return MeasureRepository.HasMeasures();
		}
	}
}