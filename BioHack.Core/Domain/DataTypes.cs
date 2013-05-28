using BioHack.Core.Contracts;

namespace BioHack.Core.Domain
{
	public class DataTypes : IBusinessEntity
	{
		static DataTypes ()
		{
			Continuous = new DataTypes { Id = 1, Value = "Continuous", Display = "Continuous (numeric)" };
            Nominal = new DataTypes { Id = 2, Value = "Nominal", Display = "Nominal (named)" };
            Dichotomous = new DataTypes { Id = 3, Value = "Dichotomous", Display = "Dichotomous (present/absent)" };
            Ordinal = new DataTypes { Id = 4, Value = "Ordinal", Display = "Ordinal (rating)" };
		}

		public int Id { get; set; }
		public string Value { get; set; }
        public string Display { get; set; }

		public static DataTypes Continuous;
		public static DataTypes Nominal;
		public static DataTypes Dichotomous;
		public static DataTypes Ordinal;

        public static DataTypes GetFromDisplay(string display)
        {
            return GetFromName(display.Split(' ')[0]);
        }

        public static DataTypes[] Array
        {
            get { return new[] { Continuous, Nominal, Dichotomous, Ordinal }; }
        }

        public override string ToString()
        {
            return Display;
        }

	    public static DataTypes GetFromName(string name) {
			switch (name) {
				case "Continuous":
					return Continuous;
				case "Nominal":
					return Nominal;
				case "Dichotomous":
					return Dichotomous;
				case "Ordinal":
					return Ordinal;
				default:
					return Continuous;
			};
		}
	}
}

