using DataTransferObject;

namespace DataTransferObject
{
    public class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public UnitType UnitType { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public int CurrentQuantity { get; set; }
        public double UnitCost { get; set; }
        public double PercentageProfit { get; set; }
        public double SalePrice { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
    }
}


