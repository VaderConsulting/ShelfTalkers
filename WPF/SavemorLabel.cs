using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows;
using System.Data;
using System.Windows.Markup;

namespace ShelfTalker
{
    /// <summary>
    /// Custom label
    /// </summary>
    public class SavemorLabel
    {
        //Constants for our custom label
        // 3.885714286 pixels per mm

        private const double PAPER_SIZE_WIDTH = 816; //8.5" x 96
        private const double PAPER_SIZE_HEIGHT = 1122.5; //11" x 96

        private const double LABEL_WIDTH = 246; //2.625" x 96
        private const double LABEL_HEIGHT = 430.9; //1" x 96

        private const double LEFT_MARGIN = 10; //0.19" x 96

        private const double TOP_MARGIN = 280; //0.5" x 96
        private const double HORIZONTAL_GAP = 19; //0.13" x 96

        private const double LABELS_PER_SHEET = 6; //2 columns of 3 labels
        
        private FixedPage CreatePage()
        {
            //Create new page
            FixedPage page = new FixedPage();
            //Set background
            page.Background = Brushes.White;
            //Set page size (Letter size)
            page.Width = PAPER_SIZE_WIDTH;
            page.Height = PAPER_SIZE_HEIGHT;
            return page;
        }

        public FixedDocument CreateDocument(DataTable data)
        { 
            //Create new document
            FixedDocument doc = new FixedDocument();
            //Set page size
            doc.DocumentPaginator.PageSize = new Size(PAPER_SIZE_WIDTH, PAPER_SIZE_HEIGHT);

            //Number of records
            double RowCount = (double)data.Rows.Count;


            RowCount = 6;  // HARDCODED


            if(RowCount > 0)
            {
                string ProductName = "";
                string ProductPrice = "";
                string ProductSaving = "";

                CustomLabel label;

                //Determine number of pages to generate
                double pageCount = Math.Ceiling(RowCount / LABELS_PER_SHEET);

                int dataIndex = 0;
                int currentColumn = 0;
                int currentRow = 0;

                for (int i = 0; i < pageCount; i++)
                {
                    //Create page
                    PageContent page = new PageContent();
                    FixedPage fixedPage = this.CreatePage();
                    //Create labels
                    for (int j = 0; j < LABELS_PER_SHEET; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                currentColumn = 0;
                                currentRow=0;
                                break;
                            case 1:
                                currentColumn = 1;
                                currentRow=0;
                                break;
                            case 2:
                                currentColumn = 2;
                                currentRow=0;
                                break;
                            case 3:
                                currentColumn = 0;
                                currentRow=1;
                                break;
                            case 4:
                                currentColumn = 1;
                                currentRow=1;
                                break;
                            case 5:
                                currentColumn = 2;
                                currentRow=1;
                                break;
                        }

                        Console.WriteLine("Column: " + currentColumn);
                        Console.WriteLine("Row: " + currentRow);

                        if (dataIndex < RowCount)
                        {
                            //Get data from DataTable
                            ProductName = (string)data.Rows[dataIndex]["Name"];
                            ProductPrice = (string)data.Rows[dataIndex]["Address"];
                            ProductSaving = (string)data.Rows[dataIndex]["City"];
                            //Create individual label
                            label = new CustomLabel(ProductName, ProductPrice, ProductSaving);

                            //Set label location
                            if (currentColumn == 0)
                            {
                                FixedPage.SetLeft(label, LEFT_MARGIN);
                            }
                            else if (currentColumn == 1)
                            {
                                FixedPage.SetLeft(label, LEFT_MARGIN + LABEL_WIDTH + HORIZONTAL_GAP);
                            }
                            else
                            {
                                FixedPage.SetLeft(label, LEFT_MARGIN + LABEL_WIDTH * 2 + HORIZONTAL_GAP * 2);
                            }
                            FixedPage.SetTop(label, TOP_MARGIN + currentRow * LABEL_HEIGHT); 

                            //Add label object to page
                            fixedPage.Children.Add(label);

                            dataIndex++;
                        }
                    }

                    //Invoke Measure(), Arrange() and UpdateLayout() for drawing
                    fixedPage.Measure(new Size(PAPER_SIZE_WIDTH, PAPER_SIZE_HEIGHT));
                    fixedPage.Arrange(new Rect(new Point(), new Size(PAPER_SIZE_WIDTH, PAPER_SIZE_HEIGHT)));
                    fixedPage.UpdateLayout();

                    ((IAddChild)page).AddChild(fixedPage);

                    doc.Pages.Add(page);
                }
            }

            return doc;
        }
    }
}
