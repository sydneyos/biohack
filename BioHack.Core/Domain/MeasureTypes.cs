using BioHack.Core.Contracts;

namespace BioHack.Core.Domain
{
	public class MeasureTypes : IBusinessEntity
	{
        static MeasureTypes()
        {
            Predictor = new MeasureTypes { Id = 1, Value = "Predictor", Display = "Predictor (independent variable)" };
            Outcome = new MeasureTypes { Id = 2, Value = "Outcome", Display = "Outcome (dependent variable)" };
        }

        public int Id { get; set; }
        public string Value { get; set; }
        public string Display { get; set; }

        public static MeasureTypes Predictor;
        public static MeasureTypes Outcome;

        public static MeasureTypes GetFromId(int id)
        {
            if (id == 1) return Predictor;
            return Outcome;
        }

        public static MeasureTypes[] Array
        {
            get { return new[] {Predictor, Outcome}; }
        }

        public override string ToString()
        {
            return Display;
        }

        public static MeasureTypes GetFromDisplay(string display)
        {
            if (display.Contains("Predictor")) return Predictor;
            return Outcome;
        }
	}
}

