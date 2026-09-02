using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.task3
{
    public class Electronic : Product
    {
        public DateTime WarrantyPeriod { get; set; }

        public Electronic(string name, decimal price, DateTime warrantyPeriod):base(name, price)
        {
            warrantyPeriod = WarrantyPeriod;
        }
        
        public override string GetProductDetails()
        {
            return base.GetProductDetails() + $"WarrantyPeriod: {WarrantyPeriod}";
        }

    }
}
