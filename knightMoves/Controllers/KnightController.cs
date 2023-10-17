using knightMoves.Services;
using Microsoft.AspNetCore.Mvc;

namespace knightMoves.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnightController : ControllerBase
    {
        private readonly IKnightService _knightService;

        public KnightController(IKnightService knightService)
        {
            _knightService = knightService;
        }

        /// <summary>
        ///  Get list of all possible moves of a knight given the current position.
        /// </summary>
        /// <param name="customerNumber"></param>
        /// <returns></returns>
        [HttpGet("possible-moves/{currentPosition}")]
        public  IActionResult Get(string currentPosition)
        {
            var possibleMoves = _knightService.GetPossibleMoves(currentPosition);
            return Ok(possibleMoves);
        }
    }
}
