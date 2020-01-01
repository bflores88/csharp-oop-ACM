using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        private string _productName;

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName
        {
            get { return _productName.InsertSpaces(); }
            set { _productName = value; }
        }

        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(ProductName) && CurrentPrice != null;
        }

        public override string ToString() => ProductName;


    }
}
