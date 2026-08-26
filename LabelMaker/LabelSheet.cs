using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows;
using System.Data;
using System.Windows.Markup;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace ShelfTalker
{
    class LabelSheet
    {
        public struct PixelUnitFactor
        {
            public const double Px = 1.0;
            public const double Inch = 96.0;
            public const double Cm = 37.7952755905512;
            public const double Mm = 3.77952755905512;
            public const double Pt = 1.33333333333333;
        }

        public struct SheetType
        {
            public const int ThreexTwo = 1;
            public const int FourxThree = 2;
            public const int OneLandscape = 3;
            public const int OnePortrait = 4;
        }

        public struct PageOrientation
        {
            public const int Portait = 1;
            public const int Landscape = 2;
        }

        public double PaperWidth { get; set; }
        public double PaperHeight { get; set; }
        public double LabelWidth { get; set; }
        public double LabelHeight { get; set; }
        public double LeftMargin { get; set; }
        public double TopMargin { get; set; }
        public double HorizontalGap { get; set; }
        public double VerticalGap { get; set; }
        public int LabelsWide { get; set; }
        public int LabelsHigh { get; set; }
        public int TypeOfSheet { get; set; }
        public int Orientation { get; set; }

        private int LabelsPerSheet = 1;

        public LabelSheet()
        {
        }

        private FixedPage CreatePage()
        {
            //Create new page
            FixedPage page = new FixedPage();
            //Set background
            page.Background = Brushes.White;
            //Set page size

            if (Orientation == PageOrientation.Portait)
            {
                page.Width = PaperWidth * PixelUnitFactor.Mm;
                page.Height = PaperHeight * PixelUnitFactor.Mm;
            }
            else
            {
                //Create Transform
                TransformGroup pageTransform = new TransformGroup();
                pageTransform.Children.Add(new RotateTransform(90));

                pageTransform.Children.Add(new TranslateTransform(PaperWidth * PixelUnitFactor.Mm, 0));

                page.RenderTransform = pageTransform;


            }

            return page;
        }

        public FixedDocument CreateDocument(List<string[]> Data)
        {
            double CalculatedPaperWidth = PaperWidth * PixelUnitFactor.Mm;
            double CalculatedPaperHeight = PaperHeight * PixelUnitFactor.Mm;
            double CalculatedLabelWidth = LabelWidth * PixelUnitFactor.Mm;
            double CalculatedLabelHeight = LabelHeight * PixelUnitFactor.Mm;
            double CalculatedLeftMargin = LeftMargin * PixelUnitFactor.Mm;
            double CalculatedTopMargin = TopMargin * PixelUnitFactor.Mm;
            double CalculatedHorizontalGap = HorizontalGap * PixelUnitFactor.Mm;
            double CalculatedVerticalGap = VerticalGap * PixelUnitFactor.Mm;
            UserControl label = new UserControl(); // Create a 'generic' (i.e. non-specific) label variable
            double RowCount = Data.Count;

            //Create new document
            FixedDocument doc = new FixedDocument();
            //Set page size
            doc.DocumentPaginator.PageSize = new Size(CalculatedPaperWidth, CalculatedPaperHeight);

            //Number of records
            //double RowCount = (double)Data.GetUpperBound(0);

            // HARDCODE FOR TESTING
            //RowCount = 1;

            LabelsPerSheet = LabelsWide * LabelsHigh;

            if (RowCount > 0)
            {
                string ProductName = "";
                string ProductPrice = "";
                string OppositionPrice = "";
                string CatalogueEndDate = "";
                string[] DataItem = new string[4];

                //Determine number of pages to generate
                double pageCount = Math.Ceiling(RowCount / LabelsPerSheet);

                int dataIndex = 0;
                int currentColumn = 0;
                int currentRow = 1;

                for (int i = 0; i < pageCount; i++)
                {
                    //Create page
                    PageContent page = new PageContent();
                    FixedPage fixedPage = this.CreatePage();
                    //Create labels
                    for (int j = 0; j < LabelsPerSheet; j++)
                    {
                        if (dataIndex < RowCount)
                        {
                            currentColumn += 1;

                            if (currentColumn > LabelsWide)
                            {
                                currentColumn = 1;
                                currentRow += 1;
                            }

                            if (currentRow > LabelsHigh)
                            {
                                currentRow = 1;
                            }

                            //Get info from Data
                            DataItem = Data[dataIndex];
                            ProductName = DataItem[0]; 
                            ProductPrice = "$" + DataItem[1]; 
                            OppositionPrice = "Why pay $" + DataItem[2];

                            if (DataItem[3].Length > 0)
                            {
                                // We expect this to be a DateTime
                                CatalogueEndDate = Convert.ToDateTime(DataItem[3]).ToShortDateString();

                                // If the date is Date.Min, then set the resultant string to ""
                                if (CatalogueEndDate.EndsWith("0001")) CatalogueEndDate = "";
                                if (CatalogueEndDate.EndsWith("1900")) CatalogueEndDate = "";

                                if (Convert.ToDateTime(DataItem[3]) < DateTime.Today) CatalogueEndDate = "";
                            }

                            if (Convert.ToDouble(DataItem[4]) > 0)
                            {
                                ProductPrice = "$" + Convert.ToDouble(DataItem[4]).ToString(); 
                            }
                            
                            if (OppositionPrice == "Why pay $0.00") OppositionPrice = "";

                            //Create individual label
                            switch (TypeOfSheet)
                            {
                                case SheetType.ThreexTwo:  //1
                                    label = new ThreeXTwoLabel(ProductName, ProductPrice, OppositionPrice, CatalogueEndDate);
                                    break;
                                case SheetType.FourxThree:  //2
                                    label = new FourXThreeLabel(ProductName, ProductPrice, OppositionPrice, CatalogueEndDate);
                                    break;
                                case SheetType.OneLandscape:  //3
                                    label = new OneLLabel(ProductName, ProductPrice, OppositionPrice, CatalogueEndDate);
                                    break;
                                case SheetType.OnePortrait:  //4
                                    label = new OnePLabel(ProductName, ProductPrice, OppositionPrice, CatalogueEndDate);
                                    break;
                            }

                            label.Width = CalculatedLabelWidth;
                            label.Height = CalculatedLabelHeight;

                            double LeftPosition = 0;
                            double TopPosition = 0;

                            LeftPosition = CalculatedLeftMargin + (CalculatedLabelWidth * (currentColumn - 1)) + (CalculatedHorizontalGap * (currentColumn - 1));
                            TopPosition = CalculatedTopMargin + (CalculatedLabelHeight * (currentRow - 1)) + (CalculatedVerticalGap * (currentRow - 1));

                            FixedPage.SetLeft(label, LeftPosition);
                            FixedPage.SetTop(label, TopPosition);

                            //Add label object to page
                            fixedPage.Children.Add(label);

                            dataIndex++;
                        }
                    }

                    fixedPage.Measure(new Size(CalculatedPaperWidth, CalculatedPaperHeight));
                    fixedPage.Arrange(new Rect(new Point(), new Size(CalculatedPaperWidth, CalculatedPaperHeight)));
                    fixedPage.UpdateLayout();

                    ((IAddChild)page).AddChild(fixedPage);

                    doc.Pages.Add(page);
                }
            }

            return doc;
        }

        public double CmToPx(double cm)
        {
            return cm * PixelUnitFactor.Cm;
        }

        public double PxToCm(double px)
        {
            return px / PixelUnitFactor.Cm;
        }

        public double MmToPx(double cm)
        {
            return 10 * cm * PixelUnitFactor.Cm;
        }

        public double PxToMm(double px)
        {
            return px / PixelUnitFactor.Cm / 10;
        }
    }
}
