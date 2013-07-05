using System;
using System.Collections.Generic;
using BioHack.Core.Domain;
using BioHack.Core.Repositories;

namespace BioHack.Core.Services {

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

		public static IList<Measure> GetMeasures ()
		{
			return new List<Measure>(MeasureRepository.GetMeasures());
		}
		
		public static int SaveMeasure (Measure item)
		{
			return MeasureRepository.SaveMeasure(item);
		}
		
		public static int DeleteMeasure(int id)
		{
			return MeasureRepository.DeleteMeasure(id);
		}
	}
}