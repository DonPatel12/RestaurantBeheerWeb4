    using Microsoft.AspNetCore.Mvc;
using RestaurantBeheerWeb4BL.Services;

namespace RestaurantBeheerWeb4REST.Controllers
{
    [Route("api/[controller]/gebruiker")]
    [ApiController]
    public class GebruikerController : ControllerBase
    {
        private GebruikerService gebruikerService;

        public GebruikerController(GebruikerService gebruikerService)
        {
            this.gebruikerService = gebruikerService;
        }

        [HttpGet]
        public IActionResult GetGebruikers()
        {
            try
            {
                return Ok(gebruikerService.GetGebruikers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
