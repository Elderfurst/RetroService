using RetroService.Models;
using System;
using System.Threading.Tasks;

namespace RetroService.Services.Interfaces
{
    public interface IBoardService
    {
        Task<Board> GetBoard(Guid boardId);
        Task<Board> CreateBoard(Board board);
    }
}
