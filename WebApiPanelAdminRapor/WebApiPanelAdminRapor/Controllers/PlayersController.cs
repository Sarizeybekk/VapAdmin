using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiPanelAdminRapor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly PanelappContext _context;
        public PlayersController(PanelappContext context)
        {

            _context = context;

        }
 
        [HttpGet("total")]
        public async Task<IActionResult> GetTotalPlayers()
        {
            var totalPlayers = await _context.Players.CountAsync();
            return Ok(new { TotalPlayers = totalPlayers });
        }


        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Player>>> GetAllPlayers(int pageNumber = 1, int pageSize = 100)
        {
            var players = await _context.Players
                                        .Skip((pageNumber - 1) * pageSize)
                                        .Take(pageSize)
                                        .ToListAsync();

            var totalPlayers = await _context.Players.CountAsync();
            var totalPages = (int)Math.Ceiling(totalPlayers / (double)pageSize);

            var response = new
            {
                TotalPlayers = totalPlayers,
                TotalPages = totalPages,
                CurrentPage = pageNumber,
                Players = players
            };

            return Ok(response);
        }
  


    }
}

