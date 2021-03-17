using System;
using System.Collections.Generic;

namespace uzduotis2
{
	class Program
	{
		enum Level
		{
			None,
			Low = 1,
			Medium = 2,
			High = 3
		}

		static void Main()
		{
			Zodynas();
		}

		static void Zodynas()
		{
		string[] leveliai = new string[3] { "Low", "Medium", "High" };

			string value = leveliai[0];
			Level svarbumasLow = (Level)Enum.Parse(typeof(Level), value);

			string value1 = leveliai[1];
			Level svarbumasMedium = (Level)Enum.Parse(typeof(Level), value1);

			string value2 = leveliai[2];
			Level svarbumasHigh = (Level)Enum.Parse(typeof(Level), value2);

			Dictionary<string, int> levelis = new Dictionary<string, int>
			{
				{ leveliai[0], 0 }, {leveliai[1], 1}, {leveliai[2], 2}
			};

            Console.WriteLine("Iveskite svarbumo lygmeni nuo 0 iki 2 \n 0 - Low\n 1 - Medium\n 2 - High");
			int ivedamasSkaicius = int.Parse(Console.ReadLine());
			if (ivedamasSkaicius == 0)
			{
				Console.WriteLine($"{leveliai[0]} level");
			}
			else if (ivedamasSkaicius == 1)
			{
				Console.WriteLine($"{leveliai[1]} level");
			}
			else if (ivedamasSkaicius == 2)
			{
				Console.WriteLine($"{leveliai[2]} level");
			}
			else 
			{
				Console.WriteLine("Netinkama ivestis");
			}



		}
	}
}
