using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day4.Entites
{
    public class Category
    {
        [Key]
        public int Id { set; get; }
        public string? Name { set; get; }
        public string? Description{ set; get; }

        public virtual List<Book>? Books { set; get; }
    }
}
