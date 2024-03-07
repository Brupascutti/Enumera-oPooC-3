using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExHerançaPooC_.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFree { get; set; }
        public ImportedProduct() { }

        public ImportedProduct(string name, double price,double customFree) : base(name,price) 
        { 
            CustomFree = customFree;
        }

        public double TotalPrice()
        {
            return CustomFree + Price;
        }
        public override string PrinceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomFree.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
