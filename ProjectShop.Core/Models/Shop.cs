
using ProjectShop.Core.Models;

public class Shop:BaseModel
{
    private static int _id;
    public List<Product> Products;

    public Shop()
    {
        _id++;
        Id = _id;
        Products = new List<Product>();
    }
}

