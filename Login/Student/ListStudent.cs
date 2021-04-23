using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;



namespace Login
{
    public partial class ListStudent : Form
    {
        public ListStudent()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        //public IEnumerable<Section> Sections { get; private set; }
        //public object Application { get; private set; }

        //Load student from database into datagridview
        private void ListStudent_Load(object sender, EventArgs e)
        {
            
            dataGridViewListStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = student.getStudent();
            picCol = (DataGridViewImageColumn)dataGridViewListStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewListStudent.AllowUserToAddRows = false;
        }

        //Double click to go into other form
        private void dataGridViewListStudent_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeletefrm = new UpdateDeleteStudentForm();
            updateDeletefrm.txtStudentId.Text = dataGridViewListStudent.CurrentRow.Cells[0].Value.ToString();
            updateDeletefrm.txtFName.Text = dataGridViewListStudent.CurrentRow.Cells[1].Value.ToString();
            updateDeletefrm.txtLName.Text = dataGridViewListStudent.CurrentRow.Cells[2].Value.ToString();
            updateDeletefrm.dateTimePickerBDate.Value = (DateTime)dataGridViewListStudent.CurrentRow.Cells[3].Value;

            //gender
            if ((dataGridViewListStudent.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                updateDeletefrm.radioButtonGFemale.Checked = true;
            }

            updateDeletefrm.txtNumberPhone.Text = dataGridViewListStudent.CurrentRow.Cells[5].Value.ToString();
            updateDeletefrm.txtAddressStudent.Text = dataGridViewListStudent.CurrentRow.Cells[6].Value.ToString();

            //picture student
            byte[] pic;
            pic = (byte[])dataGridViewListStudent.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletefrm.pictureBoxImageStudent.Image = Image.FromStream(picture);

            updateDeletefrm.Show();
        }


        private void dataGridViewListStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        //button refresh
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewListStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = student.getStudent();
            picCol = (DataGridViewImageColumn)dataGridViewListStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewListStudent.AllowUserToAddRows = false;
        }

        private void buttonSaveToText_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridViewListStudent, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
                for (r = 0; r <= RowCount - 1; r++)
                {
                    byte[] imgbyte = (byte[])dataGridViewListStudent.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    //Image sparePicture = Image.FromStream(ms);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.InsertParagraph();
                }
                //header text
                foreach (Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.Text = "Danh Sách Sinh Viên";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                }




                //save the file
                oDoc.SaveAs2(filename);


            }

        }
       
    }
}
