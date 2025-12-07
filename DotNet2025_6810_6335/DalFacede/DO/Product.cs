

using System.Xml.Linq;

namespace DO;

public record Product(int ID, string ProductName, Categories Category, double Price , int QuantityInStock );
{
}
