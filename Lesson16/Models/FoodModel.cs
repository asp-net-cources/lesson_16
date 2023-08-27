using Lesson16.Data.Models;

namespace Lesson16.Models;

public class FoodModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Food;
}
