
namespace HomeWork3.task3
{
    public class Clothing : Product, IDiscountable
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public Clothing() { }

        public Clothing(string name, decimal price, string size, string material) : base(name, price) 
        {
            Size = size;
            Material = material;
        }
        public void ApplyDiscount(decimal percentage) 
        { 
            Price -= Price * (percentage / 100);
        }
        public override string GetProductDetails()
        {
            return base.GetProductDetails() + $" Size: {Size}, Material: {Material} ";
        }
    }
}
