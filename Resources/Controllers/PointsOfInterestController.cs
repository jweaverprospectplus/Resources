using Microsoft.AspNetCore.Mvc;
using Resources.Models;

namespace Resources.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointsOfInterestDto>> GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities
                    .FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{pointofinterestId}")]
        public ActionResult<PointsOfInterestDto> GetPointsOfInterest(
            int cityId, int pointofinterestId)
        {
            var city = CitiesDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == cityId);

            var points = CitiesDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == pointofinterestId);

            if (points == null || city == null)
            {
                return NotFound();
            }

            return Ok(points);
        } 
        
    }
}
