using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Horga_Alexandra_Lab2.Models
{
    public class Book
    {   
        public int ID { get; set; }

        [Display(Name ="Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price {  get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public int AuthorID { get; set; }  // Cheie străină către Authors

        public Author Author { get; set; }  // Proprietate de navigare către autorul cărții
    }
}
