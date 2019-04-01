using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetroService.Models;
using RetroService.Services.Interfaces;

namespace RetroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoardService _service;

        public BoardController(IBoardService service)
        {
            _service = service;
        }

        // GET: api/Board/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Board>> Get(int id)
        {
            var board = await _service.GetBoard(id);

            if (board == null)
            {
                return NotFound();
            }

            return board;
        }

        // POST: api/Board
        [HttpPost]
        public async Task<ActionResult<Board>> Post([FromBody] Board board)
        {
            return await _service.CreateBoard(board);
        }
    }
}
