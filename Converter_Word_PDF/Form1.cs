using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Create_WordPDF;
using System.IO;

namespace Converter_Word_PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 控制項提示視窗

            ToolTip toolTip_MergePDF_M1 = new ToolTip();
            toolTip_MergePDF_M1.SetToolTip(this.rbt_MergePDF_M1, "Free version is limited to 10 pages of PDF.");
            toolTip_MergePDF_M1.InitialDelay = 0;

            ToolTip toolTip_MergePDF_M2 = new ToolTip();
            toolTip_MergePDF_M2.SetToolTip(this.rbt_MergePDF_M2, "No limitation of pages, but the conversion is time-consuming and the format may differ.");
            toolTip_MergePDF_M2.InitialDelay = 0;

            #endregion
        }

        private Cls_WordPDF clsWordPDF { get; set; } = new Cls_WordPDF();
        private Cls_File_ByteArray clsFile_ByteArray { get; set; } = new Cls_File_ByteArray();
        private Cls_ExcelPDF clsExcelPDF { get; set; } = new Cls_ExcelPDF();

        /// <summary>
        /// 模式切換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_Mode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;
            if (rbtn.Checked == false) return;

            if (this.rbt_File_to_Byte_Array.Checked || this.rbt_ByteArray_to_File.Checked)
            {
                this.checkBox_Batch.Enabled = false;
                this.checkBox_Batch.Checked = false;
                this.panel_MergePDF.Enabled = false;
            }
            else if (this.rbt_MergePDF.Checked || this.rbt_MergeWord.Checked)
            {
                this.checkBox_Batch.Enabled = false;
                this.checkBox_Batch.Checked = true;
                if (this.rbt_MergePDF.Checked)
                    this.panel_MergePDF.Enabled = true;
                else
                    this.panel_MergePDF.Enabled = false;
            }
            else
            {
                this.checkBox_Batch.Enabled = true;
                this.panel_MergePDF.Enabled = false;
            }
            this.checkBox_Batch_CheckedChanged(null, null);

            if (rbtn == this.rbt_Word_to_PDF)
            {
                this.rbt_pdf.Checked = true;
                this.Set_rbt_Format_Enabled("PDF");

                this.button_1.Image = global::Converter_Word_PDF.Properties.Resources.Word_32;
                this.button_2.Image = global::Converter_Word_PDF.Properties.Resources.PDF_32;

            }
            else if (rbtn == this.rbt_PDF_to_Word)
            {
                this.rbt_docx.Checked = true;
                this.Set_rbt_Format_Enabled("Word");

                this.button_1.Image = global::Converter_Word_PDF.Properties.Resources.PDF_32;
                this.button_2.Image = global::Converter_Word_PDF.Properties.Resources.Word_32;

            }
            else if (rbtn == this.rbt_Excel_to_PDF)
            {
                this.rbt_pdf.Checked = true;
                this.Set_rbt_Format_Enabled("PDF");

                this.button_1.Image = global::Converter_Word_PDF.Properties.Resources.Excel_32;
                this.button_2.Image = global::Converter_Word_PDF.Properties.Resources.PDF_32;

            }
            else if (rbtn == this.rbt_MergePDF)
            {
                this.rbt_pdf.Checked = true;
                this.Set_rbt_Format_Enabled("PDF", "Word");

                this.button_1.Image = global::Converter_Word_PDF.Properties.Resources.PDF_32;
                this.button_2.Image = global::Converter_Word_PDF.Properties.Resources.PDF_32;
            }
            else if (rbtn == this.rbt_MergeWord)
            {
                this.rbt_docx.Checked = true;
                this.Set_rbt_Format_Enabled("PDF", "Word");

                this.button_1.Image = global::Converter_Word_PDF.Properties.Resources.Word_32;
                this.button_2.Image = global::Converter_Word_PDF.Properties.Resources.Word_32;
            }
            else if (rbtn == this.rbt_File_to_Byte_Array)
            {
                this.Set_rbt_Format_Enabled();
                this.radioButton_Format_CheckedChanged(null, null);
            }
            else if (rbtn == this.rbt_ByteArray_to_File)
            {
                this.Set_rbt_Format_Enabled();
                this.radioButton_Format_CheckedChanged(null, null);
            }
        }

        /// <summary>
        /// 【Batch】切換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_Batch_CheckedChanged(object sender, EventArgs e)
        {
            this.tbx_Path_1.Text = "";
            this.tbx_Path_2.Text = "";
        }

        /// <summary>
        /// 設定載入路徑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Path_1_Click(object sender, EventArgs e)
        {
            if (this.checkBox_Batch.Checked == false) // 載入一個檔案
            {
                OpenFileDialog OpenFileDilg = new OpenFileDialog();
                OpenFileDilg.FileName = this.tbx_Path_1.Text;
                if (this.rbt_Word_to_PDF.Checked)
                    OpenFileDilg.Filter = "Word|*.docx|Word|*.doc";
                else if (this.rbt_PDF_to_Word.Checked)
                    OpenFileDilg.Filter = "PDF|*.pdf";
                else if (this.rbt_Excel_to_PDF.Checked)
                    OpenFileDilg.Filter = "Excel|*.xlsx|Excel|*.xls";
                else if (this.rbt_File_to_Byte_Array.Checked)
                {
                    if (this.rbt_pdf.Checked)
                        OpenFileDilg.Filter = "PDF|*.pdf";
                    else if (this.rbt_docx.Checked)
                        OpenFileDilg.Filter = "Word|*.docx";
                    else if (this.rbt_doc.Checked)
                        OpenFileDilg.Filter = "Word|*.doc";
                    else if (this.rbt_xlsx.Checked)
                        OpenFileDilg.Filter = "Excel|*.xlsx";
                    else if (this.rbt_xls.Checked)
                        OpenFileDilg.Filter = "Excel|*.xls";
                }
                else if (this.rbt_ByteArray_to_File.Checked)
                    OpenFileDilg.Filter = "XML|*.xml";

                OpenFileDilg.Title = "Set Load File Path";
                if (OpenFileDilg.ShowDialog() != DialogResult.OK)
                    return;
                this.tbx_Path_1.Text = OpenFileDilg.FileName;
                
            }
            else // 批量載入
            {
                FolderBrowserDialog Dilg = new FolderBrowserDialog();
                Dilg.Description = "Set Load Folder";
                Dilg.SelectedPath = this.tbx_Path_1.Text; // 初始路徑
                if (Dilg.ShowDialog() != DialogResult.OK)
                    return;
                this.tbx_Path_1.Text = Dilg.SelectedPath;
            }
        }

        /// <summary>
        /// 設定輸出路徑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_Path_2_Click(object sender, EventArgs e)
        {
            if (this.checkBox_Batch.Checked == false || this.rbt_MergePDF.Checked || this.rbt_MergeWord.Checked) // 輸出一個檔案
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = this.tbx_Path_2.Text;
                if (this.rbt_File_to_Byte_Array.Checked)
                    saveFileDialog.Filter = "XML|*.xml";
                else
                {
                    if (this.rbt_pdf.Checked)
                        saveFileDialog.Filter = "PDF|*.pdf";
                    else if (this.rbt_docx.Checked)
                        saveFileDialog.Filter = "Word|*.docx";
                    else if (this.rbt_doc.Checked)
                        saveFileDialog.Filter = "Word|*.doc";
                    else if (this.rbt_xlsx.Checked)
                        saveFileDialog.Filter = "Excel|*.xlsx";
                    else if (this.rbt_xls.Checked)
                        saveFileDialog.Filter = "Excel|*.xls";
                }

                saveFileDialog.Title = "Set Output File Path";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                this.tbx_Path_2.Text = saveFileDialog.FileName;
            }
            else // 批量輸出
            {
                FolderBrowserDialog Dilg = new FolderBrowserDialog();
                Dilg.Description = "Set Output Folder";
                Dilg.SelectedPath = this.tbx_Path_2.Text; // 初始路徑
                if (Dilg.ShowDialog() != DialogResult.OK)
                    return;
                this.tbx_Path_2.Text = Dilg.SelectedPath;
            }
        }

        /// <summary>
        /// 設定 panel_Format 內元件 Enabled狀態
        /// </summary>
        /// <param name="Tag">預設為全部開啟</param>
        private void Set_rbt_Format_Enabled(string Tag = "", string Tag2 = "")
        {
            foreach (Control c in this.panel_Format.Controls)
            {
                if (Tag == "")
                    c.Enabled = true;
                else
                {
                    if (c.Tag.ToString() == Tag || c.Tag.ToString() == Tag2)
                        c.Enabled = true;
                    else
                        c.Enabled = false;
                }
            }
        }

        private void radioButton_Format_CheckedChanged(object sender, EventArgs e)
        {
            this.tbx_Path_2.Text = "";
            if (this.rbt_Word_to_PDF.Checked || this.rbt_PDF_to_Word.Checked || this.rbt_Excel_to_PDF.Checked)
                return;

            string Tag = "";
            if (sender != null)
            {
                RadioButton rbtn = sender as RadioButton;
                if (rbtn.Checked == false) return;
                Tag = rbtn.Tag.ToString();
            }
            else
            {
                foreach (Control c in this.panel_Format.Controls)
                {
                    if ((c as RadioButton).Checked)
                    {
                        Tag = c.Tag.ToString();
                        break;
                    }
                }
            }

            Bitmap bm = null;
            switch (Tag)
            {
                case "PDF":
                    bm = global::Converter_Word_PDF.Properties.Resources.PDF_32;
                    break;
                case "Word":
                    bm = global::Converter_Word_PDF.Properties.Resources.Word_32;
                    break;
                case "Excel":
                    bm = global::Converter_Word_PDF.Properties.Resources.Excel_32;
                    break;
            }

            if (this.rbt_File_to_Byte_Array.Checked)
            {
                this.button_1.Image = bm;
                this.button_2.Image = global::Converter_Word_PDF.Properties.Resources.database_32;
            }
            else if (this.rbt_ByteArray_to_File.Checked)
            {
                this.button_1.Image = global::Converter_Word_PDF.Properties.Resources.database_32;
                this.button_2.Image = bm;
            }
            else if (this.rbt_MergePDF.Checked || this.rbt_MergeWord.Checked)
                this.button_2.Image = bm;
        }

        /// <summary>
        /// 【Execute】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Execute_Click(object sender, EventArgs e)
        {
            #region 檢查輸入資訊是否完整
            
            if (this.tbx_Path_1.Text == "")
            {
                MessageBox.Show("Please choose load path/folder", "Gentle Reminders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.tbx_Path_2.Text == "")
            {
                MessageBox.Show("Please choose output path/folder", "Gentle Reminders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            #endregion

            enu_OutputFormat format = enu_OutputFormat.pdf;
            if (this.rbt_pdf.Checked)
                format = enu_OutputFormat.pdf;
            else if (this.rbt_docx.Checked)
                format = enu_OutputFormat.docx;
            else if (this.rbt_doc.Checked)
                format = enu_OutputFormat.doc;
            else if (this.rbt_xlsx.Checked)
                format = enu_OutputFormat.xlsx;
            else if (this.rbt_xls.Checked)
                format = enu_OutputFormat.xls;

            bool b_status_ = false;
            try
            {
                if (this.checkBox_Batch.Checked == false) // 轉換一個檔案
                {
                    #region 轉換一個檔案

                    if (this.rbt_Word_to_PDF.Checked || this.rbt_PDF_to_Word.Checked)
                        b_status_ = this.clsWordPDF.Convert_2_WordPDF(this.tbx_Path_1.Text, this.tbx_Path_2.Text, format);
                    else if (this.rbt_Excel_to_PDF.Checked)
                        b_status_ = this.clsExcelPDF.Excel_to_PDF(this.tbx_Path_1.Text, this.tbx_Path_2.Text);
                    else if (this.rbt_File_to_Byte_Array.Checked)
                    {
                        byte[] fileContent = this.clsFile_ByteArray.File_to_ByteArray(this.tbx_Path_1.Text);
                        b_status_ = clsStaticTool.SaveXML(fileContent, this.tbx_Path_2.Text);
                    }
                    else if (this.rbt_ByteArray_to_File.Checked)
                    {
                        byte[] fileContent;
                        if (clsStaticTool.LoadXML(this.tbx_Path_1.Text, out fileContent))
                            b_status_ = this.clsFile_ByteArray.ByteArray_to_File(this.tbx_Path_2.Text, fileContent);
                    }

                    #endregion
                }
                else // 批量轉換
                {
                    #region 批量轉換

                    List<string> extension = new List<string>();
                    if (this.rbt_Word_to_PDF.Checked || this.rbt_MergeWord.Checked)
                    {
                        extension.Add("docx");
                        extension.Add("doc");
                    }
                    else if (this.rbt_PDF_to_Word.Checked || this.rbt_MergePDF.Checked)
                        extension.Add("pdf");
                    else if (this.rbt_Excel_to_PDF.Checked)
                    {
                        extension.Add("xlsx");
                        extension.Add("xls");
                    }

                    IEnumerable<string> files = Directory.GetFiles(this.tbx_Path_1.Text, "*.*", SearchOption.TopDirectoryOnly).Where(f => this.b_Path_Extension(f, extension));
                    if (this.rbt_MergePDF.Checked)
                    {
                        if (this.rbt_MergePDF_M1.Checked) // Method 1: Free version is limited to 10 pages of PDF.
                            b_status_ = Cls_WordPDF.MergePDF(files.ToArray(), this.tbx_Path_2.Text, format);
                        else // Method 2: 無頁數限制，但轉換時間較久，且格式可能會跑掉! (No limitation of pages, but the conversion is time-consuming and the format may differ.)
                            b_status_ = Cls_WordPDF.Merge_PDFWord(files.ToArray(), this.tbx_Path_2.Text, format);
                    }
                    else if (this.rbt_MergeWord.Checked)
                    {
                        b_status_ = Cls_WordPDF.Merge_PDFWord(files.ToArray(), this.tbx_Path_2.Text, format);
                    }
                    else
                    {
                        List<string> path_files = files.ToList();
                        foreach (string path in path_files) // 一次轉換一個檔案
                        {
                            string name = Path.GetFileNameWithoutExtension(path);
                            if (this.rbt_Word_to_PDF.Checked || this.rbt_PDF_to_Word.Checked)
                                this.clsWordPDF.Convert_2_WordPDF(path, this.tbx_Path_2.Text + "\\" + name + "." + format.ToString(), format);
                            else if (this.rbt_Excel_to_PDF.Checked)
                                this.clsExcelPDF.Excel_to_PDF(path, this.tbx_Path_2.Text + "\\" + name + "." + format.ToString());
                        }

                        b_status_ = true;
                    }
                    
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Execute Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (b_status_)
                MessageBox.Show("Finish", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failure", "Execute Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 路徑檔之副檔名是否符合要求
        /// </summary>
        /// <param name="path">路徑檔</param>
        /// <param name="extension">副檔名</param>
        /// <returns></returns>
        private bool b_Path_Extension(string path, List<string> extension)
        {
            bool b_status_ = false;
            foreach (string f in extension)
            {
                if (path.ToLower().EndsWith(f))
                {
                    b_status_ = true;
                    break;
                }
            }
            return b_status_;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
