using RetroService.Models;
using System.Threading.Tasks;

namespace RetroService.Services.Interfaces
{
    public interface IBoardService
    {
        Task<Board> GetBoard(int boardId);
        Task<Board> CreateBoard(Board board);
    }
}
