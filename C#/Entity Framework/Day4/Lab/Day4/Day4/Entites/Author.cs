using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day4.Entites
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }
        public int? Age { set; get; }

        [MaxLength(3000)]
        public string? Bio { set; get; }

        [MaxLength(200)]
        public string? Address { set; get; }

        [MaxLength(150)]
        public string Email { set; get; }

        [MaxLength(30)]
        public string? PhoneNumber { set; get; }

        [MaxLength(50)]
        public string? Username { set; get; }

        [MaxLength(100)]
        public string Password { set; get; }

        public virtual List<Book> Books { set; get; }
    }
}
