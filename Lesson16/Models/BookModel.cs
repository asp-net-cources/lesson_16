using Lesson16.Data.Models;

namespace Lesson16.Models;

public class BookModel : ProductModel
{
    public new ProductType ProductType { get; } = ProductType.Book;
}
