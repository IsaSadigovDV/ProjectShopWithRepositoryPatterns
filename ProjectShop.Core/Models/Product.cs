
using ProjectShop.Core.Models;

public class Product:BaseModel
    {
    private static int _id;

    public Category Category { get; set; }
    public Product()
    {
        _id++;
        Id = _id;
    }
}

