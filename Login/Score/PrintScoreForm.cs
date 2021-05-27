using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        private void listBoxCourse_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //load data contact
                int courseid = (int)listBoxCourse.SelectedValue;
                dataGridViewListScore.ReadOnly = true;
               
                dataGridViewListScore.RowTemplate.Height = 80;
                dataGridViewListScore.DataSource = score.getScoreByCourse(courseid);
                
                dataGridViewListScore.AllowUserToAddRows = false;

                
            }
            catch { }
            dataGridViewListScore.ClearSelection();
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            //load data list score
            dataGridViewListScore.ReadOnly = true;
            dataGridViewListScore.DataSource = score.getStudentAndScore();
            dataGridViewListScore.RowTemplate.Height = 80;
            dataGridViewListScore.AllowUserToAddRows = false;
            dataGridViewListScore.Columns[0].Width = 45;
            dataGridViewListScore.Columns[3].Width = 45;
            dataGridViewListScore.Columns[3].HeaderText = "Course ID";
            dataGridViewListScore.Columns[4].Width = 110;
            dataGridViewListScore.Columns[5].Width = 54;
            dataGridViewListScore.Columns[5].HeaderText = "Student Score";

            //load data list student

            dataGridViewListStudent.ReadOnly = true;
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = student.getStudentWithThreeAtribute();
            dataGridViewListStudent.AllowUserToAddRows = false;
            dataGridViewListStudent.Columns[0].Width = 50;

            //load data list course
            listBoxCourse.DataSource = course.getCourses();
            listBoxCourse.ValueMember = "Id";
            listBoxCourse.DisplayMember = "Label";
            listBoxCourse.SelectedItem = null;
            dataGridViewListScore.ClearSelection();

        }

        private void buttonToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridViewListScore, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Document oDoc = new Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;


                //save image
                //for (r = 0; r <= RowCount - 1; r++)
                //{
                //    byte[] imgbyte = (byte[])dataGridViewListStudent.Rows[r].Cells[7].Value;
                //    MemoryStream ms = new MemoryStream(imgbyte);
                //    //Image sparePicture = Image.FromStream(ms);
                //    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                //    Clipboard.SetDataObject(finalPic);
                //    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.Paste();
                //    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.InsertParagraph();
                //}
                //header text
                foreach (Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.Text = "Bảng điểm Sinh Viên";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                }


                //save the file
                oDoc.SaveAs2(filename);


            }
        }
    }
}
