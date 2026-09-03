

namespace HomeWork3.task3
{
    public class Electronic : Product
    {
        public int WarrantyPeriod { get; set; }

        public Electronic() { }

        public Electronic(string name, decimal price, int warrantyPeriod):base(name, price)
        {
            WarrantyPeriod = warrantyPeriod;
        }
        
        public override string GetProductDetails()
        {
            return base.GetProductDetails() + $", WarrantyPeriod: {WarrantyPeriod}";
        }

    }
}
