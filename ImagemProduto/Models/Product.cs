using System.ComponentModel.DataAnnotations;

namespace ImagemProduto.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string ImageFileName { get; set; }
    }
}
