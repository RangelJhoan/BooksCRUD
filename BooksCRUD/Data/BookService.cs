using BooksCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksCRUD.Data
{
    public class BookService : IBookService
    {
        private readonly MyBookContext _context;

        public BookService(MyBookContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book != null)
            {
                _context.Books.Remove(book);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Book>> GetAllBoks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> GetBookDetails(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<bool> InsertBook(Book book)
        {
            _context.Add(book);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveBook(Book book)
        {
            if (book.BookId > 0)
                return await UpdateBook(book);
            else
                return await InsertBook(book);
        }

        public async Task<bool> UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
