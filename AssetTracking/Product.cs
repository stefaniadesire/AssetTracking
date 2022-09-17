using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    public class Product
    {
        //product class properties

        public string productType;
        public string productbrand;
        public string productmodel;
        public DateOnly purchaseDate;
        public float price;
        public string office;


        public Product(string productType, string productbrand, string productmodel, DateOnly purchaseDate, float price, string office)
        {
            //constructor
            this.productType = productType;
            this.productbrand = productbrand;
            this.productmodel = productmodel;
            this.purchaseDate = purchaseDate;
            this.price = price;
            this.office = office;
        }



        public int getSortedProductType()
        {
            //sorting so computer is the first product that will show, then phone, then everything else.
            if (productType == "computer".ToLower().Trim())
            {
                return 1;
            }
            else if (productType == "phone".ToLower().Trim())
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }


    }
}