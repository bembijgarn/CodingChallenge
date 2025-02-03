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

		public static string[][] GetCarFilteredData(string carBrand, string carType, string transmission)
		{
			var CarData = GetCarData();

			var filteredCars = CarData.Where(car =>
			   (string.IsNullOrEmpty(carBrand) || car[0].Equals(carBrand, StringComparison.OrdinalIgnoreCase)) &&
			   (string.IsNullOrEmpty(carType) || car[1].Equals(carType, StringComparison.OrdinalIgnoreCase)) &&
			   (string.IsNullOrEmpty(transmission) || car[2].Equals(transmission, StringComparison.OrdinalIgnoreCase))
		   ).ToArray();


			string[][] Data = new string[filteredCars.Length][];


			Data[0] = filteredCars[0];

			for (int i = 1; i < filteredCars.Length; i++)
			{
				string[] Car = new string[filteredCars[i].Length];

				for (int j = 0; j < filteredCars[i].Length; j++)
				{

					if (filteredCars[i][j] == filteredCars[i - 1][j])
					{
						Car[j] = string.Empty;
					}
					else
					{
						Car[j] = filteredCars[i][j];
					}
				}
				Data[i] = Car;
			}



			return Data;

		}





	}
}
