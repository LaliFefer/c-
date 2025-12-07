

using System.Xml.Linq;

namespace DO;

public record Product(int Id, string ProductName, Categories Category, double Price , int QuantityInStock );
{
}
