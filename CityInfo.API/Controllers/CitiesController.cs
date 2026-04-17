using CityInfo.API.Models;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityInfoRepository _cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository ??
                throw new ArgumentNullException(nameof(cityInfoRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterestDto>>> GetCities()
        {
            var cities = await _cityInfoRepository.GetCitiesAsync();

            var results = cities.Select(c => new CityWithoutPointsOfInterestDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            }).ToList();

            return Ok(results);
        }

        //[HttpGet("{id}")]
        //public ActionResult<CityDto> GetCity(int id)
        //{
        //    var city = _citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);
        //    if (city == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(city);
        //}
    }
}
