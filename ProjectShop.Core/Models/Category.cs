
using ProjectShop.Core.Models;

public class Category:BaseModel
{
    private static int _id;
   

    public List<Product> Products;
    public Category()
    {
        _id++;
        Id = _id;
        Products = new List<Product>();
    }

}

    