using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShelfTalker
{
    /// <summary>
    /// Interaction logic for OnePLabel.xaml
    /// </summary>
    public partial class OnePLabel : UserControl
    {
        public OnePLabel()
            : this("ProductName", "ProductPrice", "ProductSaving", "CatalogueEndDate")
        {    
        }

        public OnePLabel(string ProductName, string ProductPrice, string ProductSaving, string CatalogueEndDate)
        {
            InitializeComponent();

            //set visual elements

            this.Description.Text = ProductName;
            this.OurPriceAmount.Text = ProductPrice;
            this.WhyPay.Text = ProductSaving;
            this.CatalogueDate.Text = CatalogueEndDate;
        }
    }
}
