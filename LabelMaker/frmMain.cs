using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using ModelShredder.Extensions;

namespace LabelMaker
{
    public partial class frmMain : Form
    {
        private bool _DatabaseIsNewStyle = false;  // when we switch over to SQL, change this to true
        private StringCollection _ExistingProducts = new StringCollection();
        private string _InputFilename = "";
        private int _InputType = 0;
        private double _Recordcount = 0;
        private int _SelectedSize = 0;
        private bool _SelectingTab = false;
        private DataSet _SourceDataSet = new DataSet();    // Original data
        private int _TabNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)  // uses DataTable
        {
            string QuoteCharacter = "";

            DataTable dt = (DataTable)_SourceDataSet.Tables[0] as DataTable;

            // Determine datatype of this column
            if (dt.Columns[cmbFilterField.Text].DataType == System.Type.GetType("System.String"))
            {
                QuoteCharacter = "'";
            }
            else if (dt.Columns[cmbFilterField.Text].DataType == System.Type.GetType("System.DateTime"))
            {
                QuoteCharacter = "'";
            }

            if (dt != null)
            {
                Cursor.Current = Cursors.WaitCursor;

                // Now compose and apply the filter to the values
                dt.DefaultView.RowFilter = (cmbFilterField.Text + " LIKE " + QuoteCharacter + "%" + cmbFilterValue.Text.Replace("'", "''") + "%" + QuoteCharacter);

                dgvPreview.DataSource = dt;

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog Browse = new OpenFileDialog();
            string ImportFilename = "";

            Browse.DefaultExt = "xml";
            Browse.Filter = "*.xml|*.xml";
            DialogResult Result = Browse.ShowDialog();

            lstInfo.Items.Clear();

            if (Result == System.Windows.Forms.DialogResult.OK) // 'Open' also produces OK
            {
                ImportFilename = Browse.FileName;

                txtPath.Text = ImportFilename;

                var count = XDocument
                    .Load(ImportFilename)
                    .XPathSelectElements("//Product")
                    .Count();

                DateTime FileCreationDate = new DateTime();
                FileInfo Info = new FileInfo(ImportFilename);
                FileCreationDate = Info.CreationTime;

                lstInfo.Items.Add("Import Filename: " + ImportFilename);
                lstInfo.Items.Add("Products included: " + count);
                lstInfo.Items.Add("File Creation Date: " + FileCreationDate);

                btnNext.Enabled = true;

                _InputFilename = ImportFilename;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopySelectedRows();
        }

        private void CopySelectedRows()
        {
            List<DataGridViewRow> SelectedRows = new List<DataGridViewRow>();

            if (dgvSelection.ColumnCount == 0)
            {
                foreach (DataGridViewColumn c in dgvPreview.Columns)
                {
                    dgvSelection.Columns.Add(c.Clone() as DataGridViewColumn);
                }

            }

            foreach (DataGridViewRow r in dgvPreview.SelectedRows)
            {
                string ProductName = r.Cells["Name"].Value.ToString().Trim().ToLower();

                if (!_ExistingProducts.Contains(ProductName))
                {
                    _ExistingProducts.Add(ProductName);

                    DataGridViewRow NewRow = new DataGridViewRow();

                    foreach (DataGridViewCell o in r.Cells)
                    {
                        DataGridViewCell CellCopy = (DataGridViewCell)o.Clone();
                        CellCopy.Value = o.Value;
                        NewRow.Cells.Add(CellCopy);
                    }

                    SelectedRows.Add(NewRow);
                }
            }

            dgvSelection.Rows.AddRange(SelectedRows.ToArray());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _TabNumber += 1;

            _SelectingTab = true;

            tabMain.SelectedTab = tabMain.TabPages[_TabNumber];

            _SelectingTab = false;

            btnNext.Enabled = false;
            //btnPrevious.Enabled = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)  // Loads the file from the FTP site
        {
            string ImportFilename = "";

            Cursor.Current = Cursors.WaitCursor;

            try
            {

                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtPath.Text);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                request.Credentials = new NetworkCredential(Properties.Settings.Default.FTPUsername, Properties.Settings.Default.FTPPassword);

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                string XMLContents = reader.ReadToEnd();

                // Save locally
                XmlDocument XML = new XmlDocument();

                Cursor.Current = Cursors.Default;

                XML.LoadXml(XMLContents);

                ImportFilename = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "XMLDataset.xml");

                _InputFilename = ImportFilename;

                XML.Save(_InputFilename);

                var count = XDocument
                        .Load(_InputFilename)
                        .XPathSelectElements("//Product")
                        .Count();

                lstInfo.Items.Clear();

                lstInfo.Items.Add("Import Filename: " + ImportFilename);
                lstInfo.Items.Add("Products included: " + count);
                //lstInfo.Items.Add("File Creation Date: " + FileCreationDate);

                btnNext.Enabled = true;

                Properties.Settings.Default.TempDataPath = ImportFilename;
                Properties.Settings.Default.Save();

                _InputFilename = ImportFilename;
            }
            catch { }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //string[,] Data = new string[5000,4];
            List<string[]> Data = new List<string[]>();
            int RowCounter = 0;

            //int ColumnCounter = 0;

            frmPreview PreviewForm = new frmPreview();

            PreviewForm.SelectedSize = _SelectedSize;

            // Transfer the data
            foreach (DataGridViewRow Row in dgvSelection.Rows)
            {
                string[] ColumnData = new string[5];

                //if (_DatabaseIsNewStyle)
                //{
                //    //Data[RowCounter, 0] = Row.Cells["product_title"].Value.ToString();
                //    //Data[RowCounter, 1] = Row.Cells["price"].Value.ToString();
                //    //Data[RowCounter, 2] = Row.Cells["oppositionprice"].Value.ToString();
                //    //Data[RowCounter, 3] = Row.Cells[""].Value.ToString();

                //    ColumnData[0] = Row.Cells["name"].Value.ToString();
                //    ColumnData[1] = Row.Cells["price"].Value.ToString();
                //    ColumnData[2] = Row.Cells["recommendedprice"].Value.ToString();
                //    ColumnData[3] = "";

                //    Data.Add(ColumnData);
                //}
                //else
                //{
                    ColumnData[0] = Row.Cells["name"].Value.ToString();
                    ColumnData[1] = Row.Cells["price"].Value.ToString();
                    ColumnData[1] = string.Format("{0:C}", ColumnData[1]);
                    ColumnData[2] = Row.Cells["recommendedprice"].Value.ToString();
                    ColumnData[2] = string.Format("{0:C}", ColumnData[2]);
                    ColumnData[3] = Row.Cells["catenddate"].Value.ToString();
                    ColumnData[4] = Row.Cells["catalogprice"].Value.ToString();
                    ColumnData[4] = string.Format("{0:C}", ColumnData[4]);

                    Data.Add(ColumnData);
                //}

                RowCounter++;
            }

            _Recordcount = dgvSelection.Rows.Count;

            PreviewForm.Data = Data;

            PreviewForm.Show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _TabNumber -= 1;

            _SelectingTab = true;

            tabMain.SelectedTab = tabMain.TabPages[_TabNumber];

            _SelectingTab = false;

            if (_TabNumber > 0)
                btnPrevious.Enabled = true;

            btnNext.Enabled = lvwMain.SelectedItems.Count > 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedRows = dgvSelection.SelectedRows;

            foreach (DataGridViewRow Row in SelectedRows)
            {
                string ProductName = Row.Cells["Name"].Value.ToString().Trim().ToLower();

                dgvSelection.Rows.Remove(Row);

                _ExistingProducts.Remove(ProductName);
            }

            EnableDisableRemoveAllButton();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            dgvSelection.Rows.Clear();

            _ExistingProducts.Clear();

            btnRemoveAll.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)  // uses DataTable
        {
            string QuoteCharacter = "";

            DataTable dt = (DataTable)_SourceDataSet.Tables[0] as DataTable; //(DataTable)dgvPreview.DataSource as DataTable;

            // Determine datatype of this column
            if (dt.Columns[cmbSearch.Text].DataType == System.Type.GetType("System.String"))
            {
                QuoteCharacter = "'";
            }

            if (dt != null)
            {
                Cursor.Current = Cursors.WaitCursor;

                // Now compose and apply the filter to the values
                dt.DefaultView.RowFilter = (cmbSearch.Text + " LIKE " + QuoteCharacter + "%" + txtSearch.Text.Replace("'", "''") + "%" + QuoteCharacter);

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            dgvPreview.SelectAll();

            CopySelectedRows();

            dgvPreview.ClearSelection();


            // This code works but is very slow
            //DataTable dt = ((DataTable)dgvPreview.DataSource as DataTable).DefaultView.ToTable().Copy();
            //if (dt != null)
            //{
            //    Cursor.Current = Cursors.WaitCursor;

            //    foreach (DataGridViewRow r in dgvPreview.Rows)
            //    {
            //        int index = dgvSelection.Rows.Add(r.Clone() as DataGridViewRow);
            //        foreach (DataGridViewCell o in r.Cells)
            //        {
            //            dgvSelection.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
            //        }
            //    }

            //    Cursor.Current = Cursors.Default;
            //}
        }

        private void CheckDataset()
        {
            btnNext.Enabled = !(dgvPreview.RowCount == 0);
        }

        private void chkOnlyDisplayShelfTalkerItems_CheckedChanged(object sender, EventArgs e)
        {
            LoadDatasetFromFile(_InputFilename);
        }

        private void cmbFilterField_SelectedIndexChanged(object sender, EventArgs e)  // uses DataTable
        {
            // Get the field that was selected
            string SelectedField = cmbFilterField.SelectedText;

            _SourceDataSet.Reset();
            LoadDatasetFromFile(_InputFilename);

            // Get the current dataset, but as a View
            DataTable dt = _SourceDataSet.Tables[0]; // (DataTable)dgvPreview.DataSource;
            if (dt != null)
            {
                Cursor.Current = Cursors.WaitCursor;

                // Now compose and apply the filter to return all values (distinct)
                dt.DefaultView.ToTable(true, cmbFilterField.Text);
                dt.Select();
                // Populate the filtervalues combo to allow the user to select the value
                cmbFilterValue.DataSource = dt.DefaultView.ToTable(true, cmbFilterField.Text);
                cmbFilterValue.DisplayMember = cmbFilterField.Text;
                cmbFilterValue.BindingContext = this.BindingContext;

                Cursor.Current = Cursors.Default;
            }
        }

        private void cmbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnApplyFilter.Enabled = (cmbFilterValue.Items.Count > 0);
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Enabled = (cmbSearch.Items.Count > 0);
        }

        private void dgvPreview_DataSourceChanged(object sender, EventArgs e)
        {
            EnableDisableCopyButton(sender);
        }

        private void dgvPreview_SelectionChanged(object sender, EventArgs e)
        {
            EnableDisableCopyButton(sender);
        }

        private void dgvSelection_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            EnableDisableRemoveAllButton();
        }

        private void dgvSelection_SelectionChanged(object sender, EventArgs e)
        {
            EnableDisableRemoveButton(sender);
        }

        private void EnableDisableCopyButton(object sender)
        {
            DataGridView PreviewGrid = (DataGridView)sender;

            btnCopy.Enabled = (PreviewGrid.SelectedRows.Count > 0);
        }

        private void EnableDisableRemoveAllButton()
        {
            btnRemoveAll.Enabled = (dgvSelection.Rows.Count > 0);

            btnNext.Enabled = (dgvSelection.Rows.Count > 0);
        }

        private void EnableDisableRemoveButton(object sender)
        {
            DataGridView SelectionGrid = (DataGridView)sender;

            btnRemove.Enabled = (SelectionGrid.SelectedRows.Count > 0);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ListViewItem Item;

            Item = new ListViewItem("1x1 Landscape", 0);
            lvwMain.Items.Add(Item);

            Item = new ListViewItem("1x1 Portrait", 1);
            lvwMain.Items.Add(Item);

            Item = new ListViewItem("3x2 Portrait", 2);
            lvwMain.Items.Add(Item);

            Item = new ListViewItem("4x3 Portrait", 3);
            lvwMain.Items.Add(Item);

            Item = new ListViewItem("Automatic", 4);
            lvwInput.Items.Add(Item);

            // At this time, only use Automatic
            //Item = new ListViewItem("Manual", 4);
            //lvwInput.Items.Add(Item);


        }

        private void LoadDatasetFromFile(string Filename)  // uses DataTable
        {
            Cursor.Current = Cursors.WaitCursor;

            XDocument document = XDocument.Load(Filename);

            List<Product> ProductList = new List<Product>();

            if (chkOnlyDisplayShelfTalkerItems.Checked && !chkOnlyDisplayCatalogItems.Checked) // Shelftalker yes, catalog no
            {
                // Get products 
                var Products = from p in document.Elements("NewDataSet").Elements("Product")
                               where p.Element("ShelfTalker").Value == "true"
                               select new Product(p);

                // Convert to a list
                ProductList = Products.ToList<Product>();
            }
            else if (!chkOnlyDisplayShelfTalkerItems.Checked && chkOnlyDisplayCatalogItems.Checked)  // Shelftalker no, catalog yes
            {
                // Get products 
                var Products = from p in document.Elements("NewDataSet").Elements("Product")
                               where p.Element("CatEndDate").Value != "1900-01-01T00:00:00+08:00"
                               select new Product(p);

                // Convert to a list
                ProductList = Products.ToList<Product>();
            }
            else if (chkOnlyDisplayShelfTalkerItems.Checked && chkOnlyDisplayCatalogItems.Checked) // Shelftalker yes, catalog yes
            {
                // Get products 
                var Products = from p in document.Elements("NewDataSet").Elements("Product")
                               where p.Element("ShelfTalker").Value == "true" && p.Element("CatEndDate").Value != "1900-01-01T00:00:00+08:00"
                               select new Product(p);

                // Convert to a list
                ProductList = Products.ToList<Product>();
            }
            else                                                                                  // Shelftalker no, Catalog no
            {
                // Get products
                var Products = from p in document.Elements("NewDataSet").Elements("Product")
                               select new Product(p);

                // Convert to a list
                ProductList = Products.ToList<Product>();
            }

            // Create source dataset object
            _SourceDataSet = new DataSet();

            // Add converted list as a datatable to our dataset
            _SourceDataSet.Tables.Add (ToDataTable<Product>(ProductList));
                
            //dgvPreview.DataSource = Products;
            dgvPreview.DataSource = _SourceDataSet.Tables[0];

            // Ensure the selection dataset is compatible by copying the columns across
            if (dgvSelection.ColumnCount == 0)
            {
                foreach (DataGridViewColumn c in dgvPreview.Columns)
                {
                    dgvSelection.Columns.Add(c.Clone() as DataGridViewColumn);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void lvwInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = lvwInput.SelectedItems.Count > 0;
        }

        private void lvwMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnNext.Enabled = lvwMain.SelectedItems.Count > 0;

            // Loop through each Listview item and check if it is selected.  Multi-Select is false, so only 1 can be selected
            foreach (ListViewItem i in lvwMain.Items)
            {
                if (i.Selected)
                {
                    _SelectedSize = i.Index;
                }
            }

        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radAll.Checked)
            {
                cmbFilterField.Enabled = false;
                cmbFilterValue.Enabled = false;
                cmbSearch.Enabled = false;
                txtSearch.Enabled = false;

                LoadDatasetFromFile(_InputFilename);
            }
            CheckDataset();
        }

        private void radFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (radFilter.Checked)
            {
                cmbFilterField.Enabled = true;
                cmbFilterValue.Enabled = true;
                cmbSearch.Enabled = false;
                txtSearch.Enabled = false;

                cmbFilterField.Items.Clear();

                List<string> columnNames = new List<string>();

                for (int i = 0; i < dgvPreview.Columns.Count; i++)
                {
                    columnNames.Add(dgvPreview.Columns[i].HeaderText);
                }

                foreach (string Name in columnNames)
                    cmbFilterField.Items.Add(Name);

                btnNext.Enabled = false;
            }
        }

        private void radNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radNone.Checked)
            {
                cmbFilterField.Enabled = false;
                cmbFilterValue.Enabled = false;
                cmbSearch.Enabled = false;
                txtSearch.Enabled = false;

                dgvPreview.DataSource = null;
            }
            btnNext.Enabled = false;
        }

        private void radSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radSearch.Checked)
            {
                cmbFilterField.Enabled = false;
                cmbFilterValue.Enabled = false;
                cmbSearch.Enabled = true;
                //txtSearch.Enabled = true;

                cmbSearch.Items.Clear();
                txtSearch.Clear();

                List<string> columnNames = new List<string>();

                for (int i = 0; i < dgvPreview.Columns.Count; i++)
                {
                    columnNames.Add(dgvPreview.Columns[i].HeaderText);
                }

                foreach (string Name in columnNames)
                    cmbSearch.Items.Add(Name);

                btnNext.Enabled = false;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            _TabNumber = tabMain.SelectedIndex;
            string SelectedSize = "";
            string InputType = "";

            switch (tabMain.SelectedIndex)
            {
                case 0: // Size
                    // This is never entered as the Index is 1 the first time the event is fired

                    break;
                case 1: // Data source
                    btnPrevious.Enabled = true;

                    // Loop through each Listview item and check if it is selected.  Multi-Select is false, so only 1 can be selected
                    foreach (ListViewItem i in lvwInput.Items)
                    {
                        if (i.Selected)
                        {
                            _InputType = i.Index;
                        }
                    }
                    break;
                case 2:
                    btnPrevious.Enabled = true;

                    if (Properties.Settings.Default.DataPath.Trim().Length > 0)
                    {
                        txtPath.Text = Properties.Settings.Default.DataPath;
                    }
                    else
                    {
                        txtPath.Text = Properties.Settings.Default.DefaultDataPath;
                    }
                    break;
                case 3:
                    LoadDatasetFromFile(_InputFilename);
                    break;
                case 4:
                    btnPrevious.Enabled = true;
                    lblOverview.Text = "";

                    switch (_SelectedSize)
                    {
                        case 0:
                            SelectedSize = "1x1 Landscape";
                            break;
                        case 1:
                            SelectedSize = "1x1 Portrait";
                            break;
                        case 2:
                            SelectedSize = "3x2 Portrait";
                            break;
                        case 3:
                            SelectedSize = "4x3 Portrait";
                            break;
                    }

                    switch (_InputType)
                    {
                        case 0:
                            InputType = "Automatic";
                            break;
                        case 1:
                            InputType = "Manual";
                            break;
                    }

                    lblOverview.Text = "Size: " + SelectedSize + "\n";
                    lblOverview.Text += "Input: " + InputType + "\n";
                    if (InputType == "Automatic")
                    {
                        lblOverview.Text += "Filename: " + _InputFilename + "\n";
                    }

                    break;
                case 5:
                    break;
            }
        }

        private void tabMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // if we aren't manually moving to another tab, disallow it
            e.Cancel = !_SelectingTab;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = (txtSearch.Text.Trim().Length > 0);
        }

        /////###############################################################
        ///// <summary>
        ///// Convert a List to a DataTable.
        ///// </summary>
        ///// <remarks>
        ///// Based on MIT-licensed code presented at http://www.chinhdo.com/20090402/convert-list-to-datatable/ as "ToDataTable"
        ///// <para/>Code modifications made by Nick Campbell.
        ///// <para/>Source code provided on this web site (chinhdo.com) is under the MIT license.
        ///// <para/>Copyright © 2010 Chinh Do
        ///// <para/>Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        ///// <para/>The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
        ///// <para/>THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
        ///// <para/>(As per http://www.chinhdo.com/20080825/transactional-file-manager/)
        ///// </remarks>
        ///// <typeparam name="T">Type representing the type to convert.</typeparam>
        ///// <param name="l_oItems">List of requested type representing the values to convert.</param>
        ///// <returns></returns>
        /////###############################################################
        ///// <LastUpdated>February 15, 2010</LastUpdated>
        public static DataTable ToDataTable<T>(List<T> l_oItems)
        {
            DataTable oReturn = new DataTable(typeof(T).Name);
            object[] a_oValues;
            int i;

            //#### Collect the a_oProperties for the passed T
            PropertyInfo[] a_oProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //#### Traverse each oProperty, .Add'ing each .Name/.BaseType into our oReturn value
            //####     NOTE: The call to .BaseType is required as DataTables/DataSets do not support nullable types, so it's non-nullable counterpart Type is required in the .Column definition
            foreach (PropertyInfo oProperty in a_oProperties)
            {
                oReturn.Columns.Add(oProperty.Name, BaseType(oProperty.PropertyType));
            }

            //#### Traverse the l_oItems
            foreach (T oItem in l_oItems)
            {
                //#### Collect the a_oValues for this loop
                a_oValues = new object[a_oProperties.Length];

                //#### Traverse the a_oProperties, populating each a_oValues as we go
                for (i = 0; i < a_oProperties.Length; i++)
                {
                    a_oValues[i] = a_oProperties[i].GetValue(oItem, null);
                }

                //#### .Add the .Row that represents the current a_oValues into our oReturn value
                oReturn.Rows.Add(a_oValues);
            }

            //#### Return the above determined oReturn value to the caller
            return oReturn;
        }

        ///###############################################################
        /// <summary>
        /// Returns the underlying/base type of nullable types.
        /// </summary>
        /// <remarks>
        /// Based on MIT-licensed code presented at http://www.chinhdo.com/20090402/convert-list-to-datatable/ as "GetCoreType"
        /// <para/>Code modifications made by Nick Campbell.
        /// <para/>Source code provided on this web site (chinhdo.com) is under the MIT license.
        /// <para/>Copyright © 2010 Chinh Do
        /// <para/>Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        /// <para/>The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
        /// <para/>THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
        /// <para/>(As per http://www.chinhdo.com/20080825/transactional-file-manager/)
        /// </remarks>
        /// <param name="oType">Type representing the type to query.</param>
        /// <returns>Type representing the underlying/base type.</returns>
        ///###############################################################
        /// <LastUpdated>February 15, 2010</LastUpdated>
        public static Type BaseType(Type oType)
        {
            //#### If the passed oType is valid, .IsValueType and is logicially nullable, .Get(its)UnderlyingType
            if (oType != null && oType.IsValueType &&
                oType.IsGenericType && oType.GetGenericTypeDefinition() == typeof(Nullable<>)
            )
            {
                return Nullable.GetUnderlyingType(oType);
            }
            //#### Else the passed oType was null or was not logicially nullable, so simply return the passed oType
            else
            {
                return oType;
            }
        }

        private void chkOnlyDisplayCatalogItems_CheckedChanged(object sender, EventArgs e)
        {
            LoadDatasetFromFile(_InputFilename);
        }

    }
}
