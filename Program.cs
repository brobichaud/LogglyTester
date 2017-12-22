using System;
using System.Diagnostics;
using Digimarc.Shared;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var sw = new Stopwatch();
			for (int x = 1; x < int.MaxValue; x++)
			{
				sw.Restart();
				Logger.Error("This is a test of Loggly");
				sw.Stop();
				Console.WriteLine("Event #{0} took: {1}", x, sw.Elapsed);
			}
		}

		public static string error =
			"{" +
			"\"time\" : \"2012-10-03T19:18:51.839\"," +
			"\"source\" : \"webportal\"," +
			"\"deployment\" : \"live\", " +
			"\"logger\" : \"Digimarc.Apps.WebPortal.resolverData.ProcessRequest\"," +
			"\"level\" : \"ERROR\"," +
			"\"thread\" : \"13\"," +
			"\"event\" : \"System.Exception: This is a test of Loggly\"" +
			"}";
	}
}
