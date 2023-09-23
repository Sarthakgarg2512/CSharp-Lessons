using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SecondMVCApp.Models
{
    public class Author
    {
        [Key] //decorated by annotations they are metadata
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { set; get; }

        public String AuthorName { set; get; }


        public float NoOfBooksPublished { set; get; }
        public String RoyalityCompany { set; get; }
    


    }
}
