using System;
using System.Collections.Generic;
using System.IO;
using BioHack.Core.Domain;
using Mono.Data.Sqlite;

namespace BioHack.Core.Andr.Repositories {
	/// <summary>
	/// The repository is responsible for providing an abstraction to actual data storage mechanism
	/// whether it be SQLite, XML or some other method
	/// </summary>
	public class MeasureRepository {
		private static string dbFile = "biohack.db3";

		private static SqliteConnection GetConnection ()
		{
			var dbPath = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.Personal), dbFile);
			bool exists = File.Exists (dbPath);

			if (!exists)
				SqliteConnection.CreateFile (dbPath);

			var conn = new SqliteConnection ("Data Source=" + dbPath);

			if (!exists)
				CreateDatabase (conn);

			return conn;
		}

		private static void CreateDatabase (SqliteConnection connection)
		{
			var sql = "CREATE TABLE Measures (Id INTEGER PRIMARY KEY AUTOINCREMENT, MeasureName ntext, DataType ntext, MeasureType integer, Created datetime);";

			connection.Open ();

			using (var cmd = connection.CreateCommand ()) {
				cmd.CommandText = sql;
				cmd.ExecuteNonQuery ();
			}

			/*
			// Create a sample note to get the user started
			sql = "INSERT INTO Measures (MeasureName, DataType, MeasureType, Created) VALUES (@MeasureName, @DataType, @MeasureType, @Created);";

			using (var cmd = connection.CreateCommand ()) {
				cmd.CommandText = sql;
				cmd.Parameters.AddWithValue ("@MeasureName", "Sample Measure");
				cmd.Parameters.AddWithValue ("@DataType", DataTypes.Continuous.Value);
				cmd.Parameters.AddWithValue ("@MeasureType", (int)MeasureTypes.Predictor);
				cmd.Parameters.AddWithValue ("@Created", DateTime.Now);

				cmd.ExecuteNonQuery ();
			}
			*/

			connection.Close ();
		}

		public static IEnumerable<Measure> GetMeasures (MeasureTypes type)
		{
			var sql = "SELECT Id, MeasureName, DataType, MeasureType FROM Measures WHERE MeasureType = @MeasureType;";

			using (var conn = GetConnection ()) {
				conn.Open ();

				using (var cmd = conn.CreateCommand ()) {
					cmd.CommandText = sql;
					cmd.Parameters.AddWithValue ("@MeasureType", type.Id);

					using (var reader = cmd.ExecuteReader ()) {
						while (reader.Read ()) {
							yield return MeasureFromReader(reader);
						}
					}
				}
			}
		}

		public static bool HasMeasures() {
			var sql = "SELECT COUNT(*) FROM Measures;";

			using (var conn = GetConnection ()) {
				conn.Open ();

				using (var cmd = conn.CreateCommand ()) {
					cmd.CommandText = sql;

					var result = cmd.ExecuteScalar ();
                    Console.WriteLine(string.Format("Found {0} measures", result));
					return (Convert.ToInt32(result) > 0);
				}
			}
		}

		public static Predictor GetPredictor(int id) {
			return GetMeasure(id) as Predictor;
		}

		public static Outcome GetOutcome(int id)  {
			return GetMeasure(id) as Outcome;
		}

		public static Measure GetMeasure (int id)
		{
			var sql = "SELECT * FROM Measures WHERE Id = id;";

			using (var conn = GetConnection ()) {
				conn.Open ();

				using (var cmd = conn.CreateCommand ()) {
					cmd.CommandText = sql;

					using (var reader = cmd.ExecuteReader ()) {
						if (reader.Read ())
							return MeasureFromReader(reader); 
						else
							return null;
					}
				}
			}
		}

		private static Measure MeasureFromReader(SqliteDataReader reader) {
			MeasureTypes type = MeasureTypes.GetFromId(reader.GetInt32(3));
			if (type == MeasureTypes.Predictor)
			return new Predictor (DataTypes.GetFromName (reader.GetString(2)), reader.GetString (1)) { Id = reader.GetInt32 (0)};
			return new Outcome (DataTypes.GetFromName (reader.GetString(2)), reader.GetString (1)) { Id = reader.GetInt32 (0)};
		}

		public static void DeleteMeasure (int id)
		{
			var sql = string.Format ("DELETE FROM Measures WHERE Id = {0};", id);

			using (var conn = GetConnection ()) {
				conn.Open ();

				using (var cmd = conn.CreateCommand ()) {
					cmd.CommandText = sql;
					cmd.ExecuteNonQuery ();
				}
			}
		}

		public static int SaveMeasure (Measure measure)
		{
			using (var conn = GetConnection ()) {
				conn.Open ();
				using (var cmd = conn.CreateCommand ()) {

					if (measure.Id == 0) {
						// Do an insert
						cmd.CommandText = "INSERT INTO Measures (MeasureName, DataType, MeasureType, Created) VALUES (@MeasureName, @DataType, @MeasureType, @Created); SELECT last_insert_rowid();";						
						cmd.Parameters.AddWithValue ("@MeasureName", measure.MeasureName);
						cmd.Parameters.AddWithValue ("@DataType", measure.DataType);
						cmd.Parameters.AddWithValue ("@MeasureType", measure.MeasureType.Id);
						cmd.Parameters.AddWithValue ("@Created", DateTime.Now);

						measure.Id = (int)cmd.ExecuteScalar ();
					} else {
						// Do an update
						cmd.CommandText = "UPDATE Measures SET MeasureName = @MeasureName, DataType = @DataType, MeasureType = @MeasureType WHERE Id = @Id";
						cmd.Parameters.AddWithValue ("@Id", measure.Id);						
						cmd.Parameters.AddWithValue ("@MeasureName", measure.MeasureName);
						cmd.Parameters.AddWithValue ("@DataType", measure.DataType);
						cmd.Parameters.AddWithValue ("@MeasureType", measure.MeasureType.Id);

						cmd.ExecuteNonQuery ();
					}
				}
			}

            Console.WriteLine(string.Format("Saved measure - ID is {0}", measure.Id));
			return measure.Id;
		}
	}
}