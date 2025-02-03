using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarController : ControllerBase
	{




		[HttpGet]
		public ActionResult GetCarData([FromQuery] string carBrand = "", [FromQuery] string carType = "", [FromQuery] string transmission = "")
		{

			var filteredData = CarData.GetCarFilteredData(carBrand, carType, transmission);

			return Ok(filteredData);
		}

	}
}
