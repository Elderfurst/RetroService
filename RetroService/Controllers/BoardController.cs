using System;
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
        [HttpGet("{guid}")]
        public async Task<ActionResult<Board>> Get(Guid guid)
        {
            var board = await _service.GetBoard(guid);

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
            var newBoard = await _service.CreateBoard(board);
            return Created("/api/board/" + newBoard.Id, newBoard);
        }
    }
}
