using System.Collections.Generic;

namespace DataTransferObject
{
    public class Sale
    {
        public int Id { get; set; }
        public User User { get; set; }

        public double Total { get; set; }
        public double Discount { get; set; }

        public List<Product> Products { get; set; }
    }
}
