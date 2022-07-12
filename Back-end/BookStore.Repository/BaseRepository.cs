using BookStore8.Models.DataModels;

namespace BookStore.Repository
{
    public class BaseRepository
    {
        protected readonly BookStore8Context _context = new BookStore8Context();
    }
}
