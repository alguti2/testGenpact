using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace programExercise
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtPath.Clear();
            txtPath.ReadOnly = true;
            btnStop.Enabled = false;
            btnStart.Enabled = false;
            this.Height = 144;
            btnExamine.Focus();
            Thread1.Enabled = false;
            DGVMonitor.Rows.Clear();
        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Select the folder";
            folder.ShowDialog();
            if (folder.SelectedPath != "")
            {
                txtPath.Text = folder.SelectedPath;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnExamine.Enabled = false;
            Thread1.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            DGVMonitor.Rows.Clear();

        }




        string monitor()
        {
            try
            {
                string pathProcessed = txtPath.Text + "\\Processed";
                string pathNotApl = txtPath.Text + "\\Not applicable";
                string masterBook = txtPath.Text + "\\MasterWorkBook.xlsx";
                string resultcreate = createDirectoryAndMasterBook(pathProcessed, pathNotApl, masterBook);


                if (resultcreate == "ok")
                {
                    string[] files = Directory.GetFiles(txtPath.Text, "*.xls*");
                    foreach (var file in files)
                    {
                        if (!Path.GetFileName(file).Contains("MasterWorkBook"))
                        {
                            string copyExcel = copySheetsNew(file, masterBook);
                            if (copyExcel == "ok")
                            {
                                string fileMoving = fileMove(file, pathProcessed);
                                if (fileMoving == "ok")
                                {

                                    DGVMonitor.Rows.Add(Path.GetFileName(file), DateTime.Now.ToString());
                                    this.Height = 388;
                                }
                                else
                                {
                                    return "An error occurred while moving the files in Excel format: " + fileMoving;

                                }
                            }
                            else
                            {
                                return "An error occurred when copying the sheets to the master workbook: " + copyExcel;

                            }


                        }

                    }
                    string[] files2 = Directory.GetFiles(txtPath.Text);

                    foreach (var file2 in files2)
                    {
                        if (!Path.GetFileName(file2).Contains("MasterWorkBook"))
                        {
                            string fileMoving = fileMove(file2, pathNotApl);
                            if (fileMoving == "ok")
                            {
                                DGVMonitor.Rows.Add(Path.GetFileName(file2), DateTime.Now.ToString());
                                this.Height = 388;
                            }
                            else
                            {
                                return "An error occurred while moving the files: " + fileMoving;

                            }

                        }
                    }
                }
                else
                {
                    return "An error occurred in the creation of the folders and master book: " + resultcreate;
                }

                lcount.Text = "Processed files: " + DGVMonitor.Rows.Count;
                return "ok";
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }


        void clear()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnExamine.Enabled = true;
            DGVMonitor.Rows.Clear();
            lcount.Text = "Processed files: 0";
            Thread1.Enabled = false;
            this.Height = 144;
        }


        string createDirectoryAndMasterBook(string fileProcessed, string fileNotApli, string fileMaster)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (!Directory.Exists(fileProcessed))
                {
                    Directory.CreateDirectory(fileProcessed);
                }

                if (!Directory.Exists(fileNotApli))
                {
                    Directory.CreateDirectory(fileNotApli);
                }

                if (!File.Exists(fileMaster))
                {

                    excel.Visible = false;
                    excel.DisplayAlerts = false;
                    Microsoft.Office.Interop.Excel.Workbook worKbooK = excel.Workbooks.Add(Type.Missing);
                    worKbooK.SaveAs(fileMaster);
                    worKbooK.Close();
                }
                string[] files = Directory.GetFiles(fileProcessed);
                string[] files2 = Directory.GetFiles(fileNotApli);
                if (DGVMonitor.Rows.Count == 0 && (files.Length > 0 || files2.Length > 0))
                {
                    foreach (var file in files)
                    {
                        DateTime fileCreatedDate = File.GetLastWriteTime(file);
                        DGVMonitor.Rows.Add(Path.GetFileName(file), fileCreatedDate.ToString());
                    }

                    foreach (var file2 in files2)
                    {
                        DateTime fileCreatedDate = File.GetLastWriteTime(file2);
                        DGVMonitor.Rows.Add(Path.GetFileName(file2), fileCreatedDate.ToString());
                    }
                    this.Height = 388;
                }

                return "ok";
            }

            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                excel.DisplayAlerts = false;
                excel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            }

        }

        string copySheetsNew(String fileFrom, string fileto)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                Object defaultArg = Type.Missing;
                Workbook curWorkBook = app.Workbooks.Open(fileFrom, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg);
                Workbook destWorkbook = app.Workbooks.Open(fileto, defaultArg, false, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg);
                int count = 1;
                foreach (Worksheet sheet in curWorkBook.Worksheets)
                {
                    curWorkBook.Worksheets[count].Copy(destWorkbook.Worksheets[count]);
                    count++;
                }

                destWorkbook.Save();
                destWorkbook.Close(defaultArg, defaultArg, defaultArg);
                curWorkBook.Save();
                curWorkBook.Close(defaultArg, defaultArg, defaultArg);
                return "ok";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                app.DisplayAlerts = false;
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            }

        }

        string fileMove(string pathStart, string pathEnd)
        {

            try
            {

                File.Move(pathStart, pathEnd + "\\" + Path.GetFileName(pathStart));

                return "ok";
            }
            catch (System.IO.IOException)
            {
                File.Replace(pathStart, pathEnd + "\\" + Path.GetFileName(pathStart), null, false);
                return "ok";
            }

            catch (Exception e)
            {

                return e.ToString();
            }




        }

        private void Thread1_Tick(object sender, EventArgs e)
        {

            string monitoring = monitor();
            if (monitoring != "ok")
            {
                clear();
                MessageBox.Show(monitoring, "File Watcher", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Thread1.Enabled = false;
            btnStart.Enabled = true;
            btnExamine.Enabled = true;
            btnStop.Enabled = false;
        }

     
    }



}

