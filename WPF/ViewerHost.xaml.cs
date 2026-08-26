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
using System.Data;
using System.IO;

namespace ShelfTalker
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void StartWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LabelSheet LabelToPrint = new LabelSheet();

            // 3x2
            //LabelToPrint.PaperWidth = 210;
            //LabelToPrint.PaperHeight = 297;

            //LabelToPrint.LabelHeight = 68;
            //LabelToPrint.LabelWidth = 66;

            //LabelToPrint.TopMargin = 74;
            //LabelToPrint.LeftMargin = 2;

            //LabelToPrint.HorizontalGap = 5;
            //LabelToPrint.VerticalGap = 47;

            //LabelToPrint.LabelsWide = 3;
            //LabelToPrint.LabelsHigh = 2;

            //LabelToPrint.Orientation = ShelfTalker.LabelSheet.PageOrientation.Portait;

            //LabelToPrint.TypeOfSheet = ShelfTalker.LabelSheet.SheetType.ThreexTwo;


            // 4x3
            //LabelToPrint.PaperWidth = 210;
            //LabelToPrint.PaperHeight = 297;

            //LabelToPrint.LabelHeight = 52;
            //LabelToPrint.LabelWidth = 49;

            //LabelToPrint.TopMargin = 38;
            //LabelToPrint.LeftMargin = 2;

            //LabelToPrint.HorizontalGap = 3;
            //LabelToPrint.VerticalGap = 42;

            //LabelToPrint.LabelsWide = 4;
            //LabelToPrint.LabelsHigh = 3;

            //LabelToPrint.Orientation = ShelfTalker.LabelSheet.PageOrientation.Portait;

            //LabelToPrint.TypeOfSheet = ShelfTalker.LabelSheet.SheetType.FourxThree;

            //A4 Landscape
            //LabelToPrint.PaperWidth = 210;
            //LabelToPrint.PaperHeight = 297;

            //LabelToPrint.LabelHeight = 141;
            //LabelToPrint.LabelWidth = 272;

            //LabelToPrint.TopMargin = 51;
            //LabelToPrint.LeftMargin = 13;

            //LabelToPrint.HorizontalGap = 0;
            //LabelToPrint.VerticalGap = 0;

            //LabelToPrint.LabelsWide = 1;
            //LabelToPrint.LabelsHigh = 1;

            //LabelToPrint.Orientation = ShelfTalker.LabelSheet.PageOrientation.Landscape;

            //LabelToPrint.TypeOfSheet = ShelfTalker.LabelSheet.SheetType.OneLandscape;

            //this.Viewer.Document = LabelToPrint.CreateDocument(this.GetEmployees());

            //A4 Portrait
            LabelToPrint.PaperWidth = 210;
            LabelToPrint.PaperHeight = 297;

            LabelToPrint.LabelHeight = 226;
            LabelToPrint.LabelWidth = 184;

            LabelToPrint.TopMargin = 50;
            LabelToPrint.LeftMargin = 9;

            LabelToPrint.HorizontalGap = 0;
            LabelToPrint.VerticalGap = 0;

            LabelToPrint.LabelsWide = 1;
            LabelToPrint.LabelsHigh = 1;

            LabelToPrint.Orientation = ShelfTalker.LabelSheet.PageOrientation.Portait;

            LabelToPrint.TypeOfSheet = ShelfTalker.LabelSheet.SheetType.OnePortrait;

            this.Viewer.Document = LabelToPrint.CreateDocument(this.GetEmployees()); 

            //// Line 1
            //TextBlock Line1 = new TextBlock();
            //Line1.FontSize = 18;
            //Line1.Height = 103;
            //Line1.Margin = new Thickness(25, 10, 25, 0);
            //Line1.Name = "Description";
            //Line1.Text = "Description goes here";
            //Line1.TextTrimming = TextTrimming.CharacterEllipsis;
            //Line1.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            //Line1.Width = LabelToPrint.MmToPx(47);
            //Line1.TextAlignment = TextAlignment.Center;
            //Line1.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            //Line1.FontWeight = (FontWeight)new FontWeightConverter().ConvertFromString("Bold");
            //Line1.TextWrapping = TextWrapping.WrapWithOverflow;

            //LabelToPrint.Controls.Add(Line1);
            

            
            
        }

        private string GetRootFolder()
        {
            //Get root folder
            string contentDir = Directory.GetCurrentDirectory();
            int dirLength = contentDir.Length;

            if (contentDir.ToLower().EndsWith(@"\bin\debug"))
                contentDir = contentDir.Remove(dirLength - 10, 10);

            else if (contentDir.ToLower().EndsWith(@"\bin\release"))
                contentDir = contentDir.Remove(dirLength - 12, 12);

            return contentDir;
        }

        private DataTable GetEmployees()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetRootFolder() + @"\data\Products--14-06-2013.xml");

            
                
            return ds.Tables[0];
        }

    }
}
