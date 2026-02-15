using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Day4.Entites
{
    public class Book
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        public string? Title { get; set; }

        [MaxLength(300)]
        public string? Brief{ get; set; }

        [DataType(DataType.Date)]
        public DateTime? PublishDate {  get; set; } 
        public int? Price { set; get; }
        public int? Quantity{ set; get; }

        [ForeignKey("Author")]
        public int? AuthorId { set; get; }

        [ForeignKey("Category")]
        public int CategoryId { set; get; }

        [MaxLength(150)]
        public string? ImagePath { set; get; }
        [MaxLength(150)]
        public string? PDF_Path { set; get; }
        public virtual Author author { get; set; }

        public virtual Category category { get; set; }  
    }
}
