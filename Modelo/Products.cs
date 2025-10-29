using System.ComponentModel.DataAnnotations;

namespace TP_Final.Modelo
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int CategoryID { get; set; }
    }
}
