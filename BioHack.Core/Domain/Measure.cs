using System;
using BioHack.Core.Contracts;

namespace BioHack.Core.Domain
{
	public abstract class Measure : IBusinessEntity
	{
		protected Measure(DataTypes datatype, string name, MeasureTypes type) {
			DataType = datatype;
			MeasureName = name;
			MeasureType = type;
		}

		public int Id { get; set; }
		public DataTypes DataType { get; set; }
		public string MeasureName { get; set; }
		public MeasureTypes MeasureType { get; private set; }
	}

	public class Predictor : Measure {
		public Predictor(DataTypes datatype, string name) : base (datatype, name, MeasureTypes.Predictor) {}
	}

	public class Outcome : Measure {
		public Outcome(DataTypes datatype, string name) : base(datatype, name, MeasureTypes.Outcome) {}
	}
}

