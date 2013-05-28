using System.Collections.Generic;
using BioHack.Core.Andr.Repositories;
using BioHack.Core.Domain;

namespace BioHack.Core.Andr.Services {

	/// <summary>
	/// Service classes are an abstraction on the data access layers
	/// </summary>
	public static class MeasureService {

		public static Predictor GetPredictor(long id)
		{
			return MeasureRepository.GetPredictor(id);
		}

		public static Outcome GetOutcome(long id)
		{
			return MeasureRepository.GetOutcome(id);
		}

		public static IList<Measure> GetMeasures (MeasureTypes type)
		{
			return new List<Measure>(MeasureRepository.GetMeasures(type));
		}
		
		public static long SaveMeasure (Measure item)
		{
			return MeasureRepository.SaveMeasure(item);
		}
		
		public static void DeleteMeasure(long id)
		{
			MeasureRepository.DeleteMeasure(id);
		}

		public static bool HasMeasures() {
			return MeasureRepository.HasMeasures();
		}
	}
}