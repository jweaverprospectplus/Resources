using Microsoft.AspNetCore.Mvc;
using Resources.Models;

namespace Resources.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : Controller
    {       
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id) 
        {
            var city = CitiesDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == id);

            if (city == null)
            {
                return NotFound();                
            }

            return Ok(city);

            

        }

    }
}
