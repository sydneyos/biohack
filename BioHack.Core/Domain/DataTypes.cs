using System;
using BioHack.Core.Contracts;

namespace BioHack.Core.Domain
{
	public class DataTypes : IBusinessEntity
	{
		static DataTypes ()
		{
			Continuous = new DataTypes { Id = 1, DataType = "Continuous" };
			Nominal = new DataTypes { Id = 2, DataType = "Nominal" };
			Nominal = new DataTypes { Id = 3, DataType = "Dichotomous" };
			Nominal = new DataTypes { Id = 4, DataType = "Ordinal" };
		}

		public int Id { get; set; }
		public string DataType { get; set; }

		public static DataTypes Continuous;
		public static DataTypes Nominal;
		public static DataTypes Dichotomous;
		public static DataTypes Ordinal;

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

