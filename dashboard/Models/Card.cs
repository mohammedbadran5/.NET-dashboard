using System.ComponentModel.DataAnnotations;

namespace dashboard.Models
{
    public class Card
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }

        [Url(ErrorMessage = "Invalid URL format.")]
        public string ImageUrl { get; set; } // Optional
    }
}
