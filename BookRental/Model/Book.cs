﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookRental.Model
{
    public class Book
    {
        [Table("Book")]
        public class Book
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string Title { get; set; }
            [Required]
            public string Author { get; set; }
            public string? Description { get; set; }
            public string? Genre { get; set; }
            public DateTime? PublishDate { get; set; }
        }
    }
}
