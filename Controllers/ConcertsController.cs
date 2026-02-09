using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobilApplikation_Grupp_3.UnitOfWork;
using MobilApplikation_Grupp_3.Dtos;
using System.Linq;

namespace MobilApplikation_Grupp_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConcertsController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public ConcertsController(IUnitOfWork uow)
        {
            _uow = uow;
        }
            [HttpGet]
            public async Task<IActionResult> GetConcerts()
            {
                var concerts = await _uow.Concerts.GetAllAsync();
                var concertDtos = concerts.Select(c =>
                {
                    var bookingCount = _uow.Bookings.Query().Count(b => b.Performance != null && b.Performance.ConcertId == c.Id);
                    return c.ToDto(bookingCount);
                });
                return Ok(concertDtos);
            }
    }
}
