using Microsoft.EntityFrameworkCore;
using RetroService.Data;
using RetroService.Models;
using RetroService.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace RetroService.Services
{
    public class BoardService : IBoardService
    {
        private readonly RetroContext _context;

        public BoardService(RetroContext context)
        {
            _context = context;
        }
        public async Task<Board> GetBoard(Guid boardId)
        {
            return await _context.Boards.FirstOrDefaultAsync(x => x.Id == boardId);
        }

        public async Task<Board> CreateBoard(Board board)
        {
            await _context.Boards.AddAsync(board);

            await _context.SaveChangesAsync();

            return board;
        }
    }
}
