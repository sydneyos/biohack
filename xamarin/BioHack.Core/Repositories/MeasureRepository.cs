using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using BioHack.Core.Domain;

namespace BioHack.Core.Repositories {
	/// <summary>
	/// The repository is responsible for providing an abstraction to actual data storage mechanism
	/// whether it be SQLite, XML or some other method
	/// </summary>
	public class MeasureRepository {
		static string storeLocation;	
		static List<Measure> measures;

		static MeasureRepository ()
		{
			// set the db location
			storeLocation = DatabaseFilePath;
			measures = new List<Measure> ();
			
			// deserialize XML from file at dbLocation
			ReadXml ();
		}
		
//		protected MeasureRepository()
//		{
//			// set the db location
//			storeLocation = DatabaseFilePath;
//			measures = new List<Measure> ();
//
//			// deserialize XML from file at dbLocation
//			ReadXml ();
//		}

		static void ReadXml ()
		{
			if (File.Exists (storeLocation)) {
				var serializer = new XmlSerializer (typeof(List<Measure>));
				using (var stream = new FileStream (storeLocation, FileMode.Open)) {
					measures = (List<Measure>)serializer.Deserialize (stream);
				}
			}
		}

		static void WriteXml ()
		{
			var serializer = new XmlSerializer (typeof(List<Measure>));
			using (var writer = new StreamWriter (storeLocation)) {
				serializer.Serialize (writer, measures);
			}
		}
		
		public static string DatabaseFilePath {
			get { 
				var storeFilename = "MeasureDB.xml";
				#if SILVERLIGHT
				// Windows Phone expects a local path, not absolute
				var path = sqliteFilename;
				#else
				
				#if __ANDROId__
				// Just use whatever directory SpecialFolder.Personal returns
				string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); ;
				#else
				// we need to put in /Library/ on iOS5.1 to meet Apple's iCloud terms
				// (they don't want non-user-generated data in Documents)
				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
				string libraryPath = Path.Combine (documentsPath, "../Library/"); // Library folder
				#endif
				var path = Path.Combine (libraryPath, storeFilename);
				#endif		
				return path;	
			}
		}
		
		public static Predictor GetPredictor(int id)
		{
			for (var t = 0; t < measures.Count; t++) {
				if (measures[t].Id == id)
					return measures[t] as Predictor;
			}
			return new Predictor() { Id=id };
		}

		public static Outcome GetOutcome(int id)
		{
			for (var t = 0; t < measures.Count; t++) {
				if (measures[t].Id == id)
					return measures[t] as Outcome;
			}
			return new Outcome() { Id=id };
		}
		
		public static IEnumerable<Measure> GetMeasures ()
		{
			return measures;
		}
		
		public static int SaveMeasure (Measure item)
		{ 
			var max = 0;
			measures.ForEach( t => max = Math.Max (max,t.Id));
			item.Id = ++max;
			measures.Add (item);
			WriteXml ();
			return max;
		}
		
		public static int DeleteMeasure(int id)
		{
			for (var t = 0; t< measures.Count; t++) {
				if (measures[t].Id == id){
					measures.RemoveAt (t);
					WriteXml ();
					return 1;
				}
			}

			return -1;
		}
	}
}