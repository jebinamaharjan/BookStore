using BookStoreApplication.Data;
using BookStoreApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStoreApplication.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
                Description = model.Description,
                LanguageId = model.LanguageId,
                Title = model.Title,
                TotalPage = model.TotalPage.HasValue ? model.TotalPage.Value : 0,
                CoverImgUrl = model.CoverImageUrl,
                BookPdfUrl = model.BookUrl
            };
            newBook.bookGallery = new List<BookGallery>();
            foreach (var file in model.Gallery)
            {
                newBook.bookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {

            return await _context.Books
            .Select(book => new BookModel()
            {
                Author = book.Author,
                Category = book.Category,
                Description = book.Description,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                Title = book.Title,
                TotalPage = book.TotalPage,
                CoverImageUrl = book.CoverImgUrl
            }).ToListAsync();
        }
        public async Task<List<BookModel>> GetTopBooks(int count)
        {

            return await _context.Books
            .Select(book => new BookModel()
            {
                Author = book.Author,
                Category = book.Category,
                Description = book.Description,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                Title = book.Title,
                TotalPage = book.TotalPage,
                CoverImageUrl = book.CoverImgUrl
            }).Take(count).ToListAsync();
        }
        public async Task<BookModel> GetBook(int id)
        {
            return await _context.Books.Where(x => x.Id == id)
                .Select(book => new BookModel()
                {
                    Author = book.Author,
                    Category = book.Category,
                    Description = book.Description,
                    Id = book.Id,
                    LanguageId = book.LanguageId,
                    Language = book.Language.Name,
                    Title = book.Title,
                    TotalPage = book.TotalPage,
                    CoverImageUrl = book.CoverImgUrl,
                    Gallery = book.bookGallery.Select(g => new GalleryModel()
                    {
                        Id = g.Id,
                        Name = g.Name,
                        URL = g.URL
                    }).ToList(),
                    BookUrl = book.BookPdfUrl
                }).FirstOrDefaultAsync();
        }
        public async Task<List<BookModel>> SearchBook(string title)
        {
            return await _context.Books.Where(x => x.Title.Contains(title))
            .Select(book => new BookModel()
            {
                Author = book.Author,
                Category = book.Category,
                Description = book.Description,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                Title = book.Title,
                TotalPage = book.TotalPage,
                CoverImageUrl = book.CoverImgUrl
            }).ToListAsync();
        }
    }
}
