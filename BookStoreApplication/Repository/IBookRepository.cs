using BookStoreApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreApplication.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBook(int id);
        Task<List<BookModel>> GetTopBooks(int count);
        Task<List<BookModel>>SearchBook(string title);
    }
}