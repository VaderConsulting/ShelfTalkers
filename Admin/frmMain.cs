using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Core.SQL;

namespace Admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtConnection.Text = Properties.Settings.Default.Connection;
            txtFTPLocation.Text = Properties.Settings.Default.FTPLocation;
            
            //txtLocalFolder.Text = Properties.Settings.Default.LocalFolder;
            txtLocalFolder.Text = Application.CommonAppDataPath;

            txtOutputFile.Text = Properties.Settings.Default.Output;
            txtQuery.Text = Properties.Settings.Default.Query;
            txtFTPHost.Text = Properties.Settings.Default.FTPHost;
            txtFTPUsername.Text = Properties.Settings.Default.FTPUsername;
            txtFTPPassword.Text = Properties.Settings.Default.FTPPassword;

            if (Environment.GetCommandLineArgs().Length > 1)
            {
                if (CreateFile())
                {
                    UploadFile();
                    Environment.Exit(0);
                }
            }

            this.Width = 300;
            this.Height = 150;
        }

        private void btnUnlockConnectionText_Click(object sender, EventArgs e)
        {
            txtConnection.ReadOnly = false;
            btnUnlockConnectionText.Enabled = false;
        }

        private void btnUnlockQueryText_Click(object sender, EventArgs e)
        {
            txtQuery.ReadOnly = false;
            btnUnlockQueryText.Enabled = false;
        }

        private void btnUnlockOutputFileText_Click(object sender, EventArgs e)
        {
            //txtLocalFolder.ReadOnly = false;
            txtOutputFile.ReadOnly = false;
            btnUnlockOutputFileText.Enabled = false;
        }

        private void btnUnlockFTPLocation_Click(object sender, EventArgs e)
        {
            txtFTPLocation.ReadOnly = false;
            txtFTPHost.ReadOnly = false;
            btnUnlockFTPLocation.Enabled = false;
        }

        private void btnUnlockFTPCredentials_Click(object sender, EventArgs e)
        {
            txtFTPUsername.ReadOnly = false;
            txtFTPPassword.ReadOnly = false;
            btnUnlockFTPCredentials.Enabled = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadFile();
        }

        private bool CreateFile()
        {
            bool Result = false;

            string connstring = txtConnection.Text;
            System.Data.DataSet Table = new DataSet("Products");

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connstring))
                {
                    conn.Open();

                    using (System.Data.SqlClient.SqlDataAdapter DA = new System.Data.SqlClient.SqlDataAdapter(txtQuery.Text, conn))
                    {
                        DataSet dt = new DataSet();
                        
                        DA.Fill(dt, "Product");

                        dt.WriteXml(System.IO.Path.Combine(txtLocalFolder.Text, txtOutputFile.Text));

                        Result = true;

                        //System.Data.SqlClient.SqlBulkCopy BulkCopy = new System.Data.SqlClient.SqlBulkCopy(SQLConn, System.Data.SqlClient.SqlBulkCopyOptions.TableLock | System.Data.SqlClient.SqlBulkCopyOptions.FireTriggers | System.Data.SqlClient.SqlBulkCopyOptions.UseInternalTransaction, null);
                        //BulkCopy.DestinationTableName = "Product";
                        //SQLConn.Open();

                        //BulkCopy.WriteToServer(dt.Tables[0]);
                        //SQLConn.Close();

                    }
                }
            }
            catch
            {
                Result = false;
            }

            Cursor.Current = Cursors.Default;

            return Result;
        }

        private bool UploadFile()
        {
            bool Result = false;

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + txtFTPHost.Text + "/" + txtFTPLocation.Text + "/" + txtOutputFile.Text);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(txtFTPUsername.Text, txtFTPPassword.Text);

            // Copy the contents of the file to the request stream.
            StreamReader sourceStream = new StreamReader(txtLocalFolder.Text + @"\" + txtOutputFile.Text);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;

            FtpWebResponse response = null;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                response = (FtpWebResponse)request.GetResponse();

                lblStatus.Text = "Upload File complete, status: " + response.StatusDescription.ToString();
                Result = true;
            }
            catch
            {
                lblStatus.Text = "**** Upload File error, status: " + response.StatusDescription.ToString();
                Result = false;
            }

            response.Close();

            Cursor.Current = Cursors.Default;

            return Result;
        }

        private void btnCreateAndUpload_Click(object sender, EventArgs e)
        {
            if (CreateFile())
                UploadFile();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            this.Height = 300;
            this.Width = 800;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            btnAdvanced.Enabled = false;
            tabAdmin.Enabled = true;
            tabAdmin.Visible = true;
        }
    }
}
