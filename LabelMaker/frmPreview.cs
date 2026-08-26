using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShelfTalker;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace LabelMaker
{
    public partial class frmPreview : Form
    {
        public int SelectedSize { get; set; }
        public List<string[]> Data { get; set; }
        
        public frmPreview()
        {
            InitializeComponent();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            DocumentViewer Viewer = new DocumentViewer();

            LabelSheet LabelToPrint = new LabelSheet();

            switch (SelectedSize)
            {
                case 0: // 1x1 Landscape
                    LabelToPrint.PaperWidth = 210;
                    LabelToPrint.PaperHeight = 297;

                    LabelToPrint.LabelHeight = 141;
                    LabelToPrint.LabelWidth = 272;

                    LabelToPrint.TopMargin = 51;
                    LabelToPrint.LeftMargin = 13;

                    LabelToPrint.HorizontalGap = 0;
                    LabelToPrint.VerticalGap = 0;

                    LabelToPrint.LabelsWide = 1;
                    LabelToPrint.LabelsHigh = 1;

                    LabelToPrint.Orientation = ShelfTalker.LabelSheet.PageOrientation.Landscape;

                    LabelToPrint.TypeOfSheet = ShelfTalker.LabelSheet.SheetType.OneLandscape;

                    Viewer.Document = LabelToPrint.CreateDocument(Data); 

                    break;
                case 1: // 1x1 Portrait
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

                    Viewer.Document = LabelToPrint.CreateDocument(Data);

                    break;
                case 2: // 3x2 Portrait
                    LabelToPrint.PaperWidth = 210;
                    LabelToPrint.PaperHeight = 297;

                    LabelToPrint.LabelHeight = 68;
                    LabelToPrint.LabelWidth = 66;

                    LabelToPrint.TopMargin = 74;
                    LabelToPrint.LeftMargin = 2;

                    LabelToPrint.HorizontalGap = 5;
                    LabelToPrint.VerticalGap = 47;

                    LabelToPrint.LabelsWide = 3;
                    LabelToPrint.LabelsHigh = 2;

                    LabelToPrint.Orientation = ShelfTalker.LabelSheet.PageOrientation.Portait;

                    LabelToPrint.TypeOfSheet = ShelfTalker.LabelSheet.SheetType.ThreexTwo;

                    Viewer.Document = LabelToPrint.CreateDocument(Data); 

                    break;
                case 3: // 4x3 Portrait
                    LabelToPrint.PaperWidth = 210;
                    LabelToPrint.PaperHeight = 297;

                    LabelToPrint.LabelHeight = 52;
                    LabelToPrint.LabelWidth = 49;

                    LabelToPrint.TopMargin = 51;  // 38
                    LabelToPrint.LeftMargin = 2;

                    LabelToPrint.HorizontalGap = 3;
                    LabelToPrint.VerticalGap = 42;

                    LabelToPrint.LabelsWide = 4;
                    LabelToPrint.LabelsHigh = 3;

                    LabelToPrint.Orientation = ShelfTalker.LabelSheet.PageOrientation.Portait;

                    LabelToPrint.TypeOfSheet = ShelfTalker.LabelSheet.SheetType.FourxThree;

                    Viewer.Document = LabelToPrint.CreateDocument(Data); 

                    break;
            }

            elementHost1.Child = Viewer;
            
        }
    }
}
