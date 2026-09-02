
namespace HomeWork3.task3
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public Clothing(string name, decimal price, string size, string material) : base(name, price) 
        {
            Size = size;
            Material = material;
        }
        public override string GetProductDetails()
        {
            return base.GetProductDetails() + $", Size: {Size}, Material: {Material} ";
        }
    }
}
