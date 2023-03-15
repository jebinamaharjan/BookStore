using BookStoreApplication.Enums;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStoreApplication.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage ="Please enter the Title of your book")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter the Name of Author")]
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage ="Please enter Total Pages of your book")]
        public int? TotalPage { get; set; }
        [Required(ErrorMessage ="Please enter the Language")]
        [Display(Name ="Language")]
        public int LanguageId{ get; set; }
        public string Language { get; set; }
        [Display(Name ="Choose the Cover Photo of your book")]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }
        [Display(Name ="Choose the gallery images of your book")]
        public IFormFileCollection GalleryFiles { get; set; }
        public List<GalleryModel> Gallery { get; set; }
        [Display(Name ="Upload your book in Pdf format")]
        public IFormFile BookPdf { get; set; }
        public string BookUrl { get; set; }
    }
}
