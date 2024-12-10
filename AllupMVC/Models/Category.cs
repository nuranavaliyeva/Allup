using System.ComponentModel.DataAnnotations;

namespace AllupMVC.Models
{
    public class Category:BaseEntity
    {
       
        [MaxLength(30, ErrorMessage="Adin uzunlugu en chox 30 ola biler")]
        public string Name { get; set; }
        //relational
        public List<Product>? Products { get; set; }
    }
}
