using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabelMaker
{
    class Product
    {
        public int UPI { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal RecommendedPrice { get; set; }
        public decimal CatalogPrice { get; set; }
        public DateTime CatEndDate { get; set; }
        public string ParentCategory { get; set; }
        public string ActiveIngredient { get; set; }
        public bool Shelftalker { get; set; }

        public Product(int uPI, string name, string brand, decimal price, decimal recommendedPrice, decimal catalogPrice, DateTime catEndDate, string parentCategory, string activeIngredient, bool shelftalker)
        {
            UPI = uPI;
            Name = name;
            Brand = brand;
            Price = price;
            RecommendedPrice = recommendedPrice;
            CatalogPrice = catalogPrice;
            CatEndDate = catEndDate;
            ParentCategory = parentCategory;
            ActiveIngredient = activeIngredient;
            Shelftalker = shelftalker;
        }

        public Product(XElement Product)
        {
            UPI = Convert.ToInt32(Product.Element("UPI").Value);
            Name = Product.Element("Name").Value;

            if (Product.Element("Brand") != null)
            {
                if (Product.Element("Brand").Value != null)
                {
                    Brand = Product.Element("Brand").Value;
                }
                else
                {
                    Brand = "";
                }
            }
            else
            {
                Brand = "";
            }

            Price = Convert.ToDecimal(Product.Element("Price").Value);

            if (Product.Element("RecommendedPrice").Value == "")
            {
                RecommendedPrice = 0m;
            }
            else
            {
                RecommendedPrice = Convert.ToDecimal(Product.Element("RecommendedPrice").Value);
            }

            if (Product.Element("CatalogPrice").Value == "")
            {
                CatalogPrice = 0m;
            }
            else
            {
                CatalogPrice = Convert.ToDecimal(Product.Element("CatalogPrice").Value);
            }

            if (Product.Element("CatEndDate").Value == "")
            {
                CatEndDate = DateTime.MinValue;
            }
            else
            {
                CatEndDate = Convert.ToDateTime(Product.Element("CatEndDate").Value);
            }

            ParentCategory = Product.Element("ParentCategory").Value;

            ActiveIngredient = Product.Element("ActiveIngredient").Value;

            Shelftalker = Convert.ToBoolean(Product.Element("ShelfTalker").Value);
        }

        public Product(DataGridViewRow Row)
        {
            UPI = Convert.ToInt32(Row.Cells["upi"].Value);

            Name = Row.Cells["name"].Value.ToString();

            Brand = Row.Cells["brand"].Value.ToString();

            Price = Convert.ToDecimal(Row.Cells["price"].Value);

            RecommendedPrice = Convert.ToDecimal(Row.Cells["recommendedprice"].Value);

            CatEndDate = Convert.ToDateTime(Row.Cells["catenddate"].Value);

            ParentCategory = Row.Cells["parentcategory"].Value.ToString();

            ActiveIngredient = Row.Cells["activeingredient"].Value.ToString();

            Shelftalker = Convert.ToBoolean(Row.Cells["shelftalker"].Value);
        }
    }
}
