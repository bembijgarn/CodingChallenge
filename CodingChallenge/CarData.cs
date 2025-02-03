using System.Linq;

namespace CodingChallenge
{
	public static class CarData
	{
		private static string[][] GetCarData()
		{

			string[][] CarData =
				[
				 ["Ford", "Fiesta", "Manual", "165000000"],
				 ["Ford", "Fiesta", "Manual", "175000000"],
				 ["Ford", "Fiesta", "Automatic", "18000000"],
				 ["Ford", "Fiesta", "Manual", "155000000"],
				 ["VW", "Polo", "Manual", "170000000"],
				 ["VW", "Beetle", "Manual", "265000000"],
				 ["VW", "Polo", "Automatic", "165000000"]
				];
			return CarData;
		}

		public static string[][] GetCarFilteredData()
		{
			var CarData = GetCarData();
			string[][] Data = new string[CarData.Length][];

			Data[0] = CarData[0]; 

			for (int i = 1; i < CarData.Length; i++)
			{
				string[] Car = new string[CarData[i].Length];

				for (int j = 0; j < CarData[i].Length; j++)
				{

					if (CarData[i][j] == CarData[i - 1][j])
					{
						Car[j] = string.Empty;
					}
					else
					{
						Car[j] = CarData[i][j];
					}
				}
				Data[i] = Car;
			}



			return Data;

		}




	}
}
