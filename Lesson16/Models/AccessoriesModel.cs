using Lesson16.Data.Models;

namespace Lesson16.Models;

public class AccessoriesModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Accessories;
}
