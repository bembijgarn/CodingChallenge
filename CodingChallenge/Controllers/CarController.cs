using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarController : ControllerBase
	{




		[HttpGet]
		public  ActionResult GetCarData()
		{

			var filteredData = CarData.GetCarFilteredData();



			return Ok(filteredData);
		}

	}
}
