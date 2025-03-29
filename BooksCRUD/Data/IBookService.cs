using BooksCRUD.Models;

namespace BooksCRUD.Data
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBoks();
        Task<Book?> GetBookDetails(int id);
        Task<bool> InsertBook(Book book);
        Task<bool> UpdateBook(Book book);
        Task<bool> DeleteBook(int id);
        Task<bool> SaveBook(Book book);
    }
}
