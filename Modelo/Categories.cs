using System.ComponentModel.DataAnnotations;

public class Categories
{
    [Key]
    public int CategoryID { get; set; }
    public string CategoryName { get; set; } = string.Empty;
}
