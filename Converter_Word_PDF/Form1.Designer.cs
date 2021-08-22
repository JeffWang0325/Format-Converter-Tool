namespace Converter_Word_PDF
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rbt_Word_to_PDF = new System.Windows.Forms.RadioButton();
            this.rbt_PDF_to_Word = new System.Windows.Forms.RadioButton();
            this.tbx_Path_1 = new System.Windows.Forms.TextBox();
            this.tbx_Path_2 = new System.Windows.Forms.TextBox();
            this.button_Execute = new System.Windows.Forms.Button();
            this.panel_Format = new System.Windows.Forms.Panel();
            this.rbt_xls = new System.Windows.Forms.RadioButton();
            this.rbt_xlsx = new System.Windows.Forms.RadioButton();
            this.rbt_doc = new System.Windows.Forms.RadioButton();
            this.rbt_docx = new System.Windows.Forms.RadioButton();
            this.rbt_pdf = new System.Windows.Forms.RadioButton();
            this.rbt_File_to_Byte_Array = new System.Windows.Forms.RadioButton();
            this.rbt_ByteArray_to_File = new System.Windows.Forms.RadioButton();
            this.checkBox_Batch = new System.Windows.Forms.CheckBox();
            this.rbt_Excel_to_PDF = new System.Windows.Forms.RadioButton();
            this.btn_Down = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.rbt_MergePDF = new System.Windows.Forms.RadioButton();
            this.rbt_MergeWord = new System.Windows.Forms.RadioButton();
            this.panel_MergePDF = new System.Windows.Forms.Panel();
            this.rbt_MergePDF_M2 = new System.Windows.Forms.RadioButton();
            this.rbt_MergePDF_M1 = new System.Windows.Forms.RadioButton();
            this.panel_Format.SuspendLayout();
            this.panel_MergePDF.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbt_Word_to_PDF
            // 
            this.rbt_Word_to_PDF.AutoSize = true;
            this.rbt_Word_to_PDF.Checked = true;
            this.rbt_Word_to_PDF.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_Word_to_PDF.ForeColor = System.Drawing.Color.Black;
            this.rbt_Word_to_PDF.Location = new System.Drawing.Point(20, 10);
            this.rbt_Word_to_PDF.Name = "rbt_Word_to_PDF";
            this.rbt_Word_to_PDF.Size = new System.Drawing.Size(187, 24);
            this.rbt_Word_to_PDF.TabIndex = 86;
            this.rbt_Word_to_PDF.TabStop = true;
            this.rbt_Word_to_PDF.Tag = "";
            this.rbt_Word_to_PDF.Text = "Convert Word to PDF";
            this.rbt_Word_to_PDF.UseVisualStyleBackColor = true;
            this.rbt_Word_to_PDF.CheckedChanged += new System.EventHandler(this.radioButton_Mode_CheckedChanged);
            // 
            // rbt_PDF_to_Word
            // 
            this.rbt_PDF_to_Word.AutoSize = true;
            this.rbt_PDF_to_Word.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_PDF_to_Word.ForeColor = System.Drawing.Color.Black;
            this.rbt_PDF_to_Word.Location = new System.Drawing.Point(20, 40);
            this.rbt_PDF_to_Word.Name = "rbt_PDF_to_Word";
            this.rbt_PDF_to_Word.Size = new System.Drawing.Size(187, 24);
            this.rbt_PDF_to_Word.TabIndex = 85;
            this.rbt_PDF_to_Word.Tag = "";
            this.rbt_PDF_to_Word.Text = "Convert PDF to Word";
            this.rbt_PDF_to_Word.UseVisualStyleBackColor = true;
            this.rbt_PDF_to_Word.CheckedChanged += new System.EventHandler(this.radioButton_Mode_CheckedChanged);
            // 
            // tbx_Path_1
            // 
            this.tbx_Path_1.BackColor = System.Drawing.Color.White;
            this.tbx_Path_1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.tbx_Path_1.ForeColor = System.Drawing.Color.Blue;
            this.tbx_Path_1.Location = new System.Drawing.Point(77, 248);
            this.tbx_Path_1.Name = "tbx_Path_1";
            this.tbx_Path_1.ReadOnly = true;
            this.tbx_Path_1.Size = new System.Drawing.Size(520, 29);
            this.tbx_Path_1.TabIndex = 87;
            this.tbx_Path_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_Path_1.Click += new System.EventHandler(this.tbx_Path_1_Click);
            // 
            // tbx_Path_2
            // 
            this.tbx_Path_2.BackColor = System.Drawing.Color.White;
            this.tbx_Path_2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.tbx_Path_2.ForeColor = System.Drawing.Color.Blue;
            this.tbx_Path_2.Location = new System.Drawing.Point(77, 348);
            this.tbx_Path_2.Name = "tbx_Path_2";
            this.tbx_Path_2.ReadOnly = true;
            this.tbx_Path_2.Size = new System.Drawing.Size(520, 29);
            this.tbx_Path_2.TabIndex = 89;
            this.tbx_Path_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_Path_2.Click += new System.EventHandler(this.tbx_Path_2_Click);
            // 
            // button_Execute
            // 
            this.button_Execute.BackColor = System.Drawing.Color.Lime;
            this.button_Execute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Execute.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.button_Execute.Location = new System.Drawing.Point(17, 438);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(90, 35);
            this.button_Execute.TabIndex = 95;
            this.button_Execute.Text = "Execute";
            this.button_Execute.UseVisualStyleBackColor = false;
            this.button_Execute.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // panel_Format
            // 
            this.panel_Format.Controls.Add(this.rbt_xls);
            this.panel_Format.Controls.Add(this.rbt_xlsx);
            this.panel_Format.Controls.Add(this.rbt_doc);
            this.panel_Format.Controls.Add(this.rbt_docx);
            this.panel_Format.Controls.Add(this.rbt_pdf);
            this.panel_Format.Location = new System.Drawing.Point(17, 394);
            this.panel_Format.Name = "panel_Format";
            this.panel_Format.Size = new System.Drawing.Size(357, 37);
            this.panel_Format.TabIndex = 96;
            // 
            // rbt_xls
            // 
            this.rbt_xls.AutoSize = true;
            this.rbt_xls.Enabled = false;
            this.rbt_xls.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_xls.ForeColor = System.Drawing.Color.Black;
            this.rbt_xls.Location = new System.Drawing.Point(290, 6);
            this.rbt_xls.Name = "rbt_xls";
            this.rbt_xls.Size = new System.Drawing.Size(50, 24);
            this.rbt_xls.TabIndex = 91;
            this.rbt_xls.Tag = "Excel";
            this.rbt_xls.Text = ".xls";
            this.rbt_xls.UseVisualStyleBackColor = true;
            this.rbt_xls.CheckedChanged += new System.EventHandler(this.radioButton_Format_CheckedChanged);
            // 
            // rbt_xlsx
            // 
            this.rbt_xlsx.AutoSize = true;
            this.rbt_xlsx.Enabled = false;
            this.rbt_xlsx.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_xlsx.ForeColor = System.Drawing.Color.Black;
            this.rbt_xlsx.Location = new System.Drawing.Point(220, 6);
            this.rbt_xlsx.Name = "rbt_xlsx";
            this.rbt_xlsx.Size = new System.Drawing.Size(58, 24);
            this.rbt_xlsx.TabIndex = 90;
            this.rbt_xlsx.Tag = "Excel";
            this.rbt_xlsx.Text = ".xlsx";
            this.rbt_xlsx.UseVisualStyleBackColor = true;
            this.rbt_xlsx.CheckedChanged += new System.EventHandler(this.radioButton_Format_CheckedChanged);
            // 
            // rbt_doc
            // 
            this.rbt_doc.AutoSize = true;
            this.rbt_doc.Enabled = false;
            this.rbt_doc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_doc.ForeColor = System.Drawing.Color.Black;
            this.rbt_doc.Location = new System.Drawing.Point(150, 6);
            this.rbt_doc.Name = "rbt_doc";
            this.rbt_doc.Size = new System.Drawing.Size(59, 24);
            this.rbt_doc.TabIndex = 89;
            this.rbt_doc.Tag = "Word";
            this.rbt_doc.Text = ".doc";
            this.rbt_doc.UseVisualStyleBackColor = true;
            this.rbt_doc.CheckedChanged += new System.EventHandler(this.radioButton_Format_CheckedChanged);
            // 
            // rbt_docx
            // 
            this.rbt_docx.AutoSize = true;
            this.rbt_docx.Enabled = false;
            this.rbt_docx.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_docx.ForeColor = System.Drawing.Color.Black;
            this.rbt_docx.Location = new System.Drawing.Point(80, 6);
            this.rbt_docx.Name = "rbt_docx";
            this.rbt_docx.Size = new System.Drawing.Size(67, 24);
            this.rbt_docx.TabIndex = 88;
            this.rbt_docx.Tag = "Word";
            this.rbt_docx.Text = ".docx";
            this.rbt_docx.UseVisualStyleBackColor = true;
            this.rbt_docx.CheckedChanged += new System.EventHandler(this.radioButton_Format_CheckedChanged);
            // 
            // rbt_pdf
            // 
            this.rbt_pdf.AutoSize = true;
            this.rbt_pdf.Checked = true;
            this.rbt_pdf.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_pdf.ForeColor = System.Drawing.Color.Black;
            this.rbt_pdf.Location = new System.Drawing.Point(10, 6);
            this.rbt_pdf.Name = "rbt_pdf";
            this.rbt_pdf.Size = new System.Drawing.Size(56, 24);
            this.rbt_pdf.TabIndex = 87;
            this.rbt_pdf.TabStop = true;
            this.rbt_pdf.Tag = "PDF";
            this.rbt_pdf.Text = ".pdf";
            this.rbt_pdf.UseVisualStyleBackColor = true;
            this.rbt_pdf.CheckedChanged += new System.EventHandler(this.radioButton_Format_CheckedChanged);
            // 
            // rbt_File_to_Byte_Array
            // 
            this.rbt_File_to_Byte_Array.AutoSize = true;
            this.rbt_File_to_Byte_Array.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_File_to_Byte_Array.ForeColor = System.Drawing.Color.Black;
            this.rbt_File_to_Byte_Array.Location = new System.Drawing.Point(20, 160);
            this.rbt_File_to_Byte_Array.Name = "rbt_File_to_Byte_Array";
            this.rbt_File_to_Byte_Array.Size = new System.Drawing.Size(329, 24);
            this.rbt_File_to_Byte_Array.TabIndex = 98;
            this.rbt_File_to_Byte_Array.Tag = "";
            this.rbt_File_to_Byte_Array.Text = "Convert File to Byte Array (saved in XML)";
            this.rbt_File_to_Byte_Array.UseVisualStyleBackColor = true;
            this.rbt_File_to_Byte_Array.CheckedChanged += new System.EventHandler(this.radioButton_Mode_CheckedChanged);
            // 
            // rbt_ByteArray_to_File
            // 
            this.rbt_ByteArray_to_File.AutoSize = true;
            this.rbt_ByteArray_to_File.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_ByteArray_to_File.ForeColor = System.Drawing.Color.Black;
            this.rbt_ByteArray_to_File.Location = new System.Drawing.Point(20, 190);
            this.rbt_ByteArray_to_File.Name = "rbt_ByteArray_to_File";
            this.rbt_ByteArray_to_File.Size = new System.Drawing.Size(329, 24);
            this.rbt_ByteArray_to_File.TabIndex = 97;
            this.rbt_ByteArray_to_File.Tag = "";
            this.rbt_ByteArray_to_File.Text = "Convert Byte Array (saved in XML) to File";
            this.rbt_ByteArray_to_File.UseVisualStyleBackColor = true;
            this.rbt_ByteArray_to_File.CheckedChanged += new System.EventHandler(this.radioButton_Mode_CheckedChanged);
            // 
            // checkBox_Batch
            // 
            this.checkBox_Batch.AutoSize = true;
            this.checkBox_Batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Batch.ForeColor = System.Drawing.Color.Magenta;
            this.checkBox_Batch.Location = new System.Drawing.Point(77, 296);
            this.checkBox_Batch.Name = "checkBox_Batch";
            this.checkBox_Batch.Size = new System.Drawing.Size(76, 28);
            this.checkBox_Batch.TabIndex = 99;
            this.checkBox_Batch.Text = "Batch";
            this.checkBox_Batch.UseVisualStyleBackColor = true;
            this.checkBox_Batch.CheckedChanged += new System.EventHandler(this.checkBox_Batch_CheckedChanged);
            // 
            // rbt_Excel_to_PDF
            // 
            this.rbt_Excel_to_PDF.AutoSize = true;
            this.rbt_Excel_to_PDF.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_Excel_to_PDF.ForeColor = System.Drawing.Color.Black;
            this.rbt_Excel_to_PDF.Location = new System.Drawing.Point(20, 70);
            this.rbt_Excel_to_PDF.Name = "rbt_Excel_to_PDF";
            this.rbt_Excel_to_PDF.Size = new System.Drawing.Size(183, 24);
            this.rbt_Excel_to_PDF.TabIndex = 100;
            this.rbt_Excel_to_PDF.Tag = "";
            this.rbt_Excel_to_PDF.Text = "Convert Excel to PDF";
            this.rbt_Excel_to_PDF.UseVisualStyleBackColor = true;
            this.rbt_Excel_to_PDF.CheckedChanged += new System.EventHandler(this.radioButton_Mode_CheckedChanged);
            // 
            // btn_Down
            // 
            this.btn_Down.BackgroundImage = global::Converter_Word_PDF.Properties.Resources.down_24;
            this.btn_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Down.Enabled = false;
            this.btn_Down.FlatAppearance.BorderSize = 0;
            this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Down.Location = new System.Drawing.Point(27, 296);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(30, 30);
            this.btn_Down.TabIndex = 94;
            this.btn_Down.UseVisualStyleBackColor = true;
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.White;
            this.button_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.Image = global::Converter_Word_PDF.Properties.Resources.PDF_32;
            this.button_2.Location = new System.Drawing.Point(17, 337);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(50, 50);
            this.button_2.TabIndex = 92;
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.tbx_Path_2_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.White;
            this.button_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.Image = global::Converter_Word_PDF.Properties.Resources.Word_32;
            this.button_1.Location = new System.Drawing.Point(17, 237);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(50, 50);
            this.button_1.TabIndex = 91;
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.tbx_Path_1_Click);
            // 
            // rbt_MergePDF
            // 
            this.rbt_MergePDF.AutoSize = true;
            this.rbt_MergePDF.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_MergePDF.ForeColor = System.Drawing.Color.Black;
            this.rbt_MergePDF.Location = new System.Drawing.Point(20, 100);
            this.rbt_MergePDF.Name = "rbt_MergePDF";
            this.rbt_MergePDF.Size = new System.Drawing.Size(110, 24);
            this.rbt_MergePDF.TabIndex = 101;
            this.rbt_MergePDF.Tag = "";
            this.rbt_MergePDF.Text = "Merge PDF";
            this.rbt_MergePDF.UseVisualStyleBackColor = true;
            this.rbt_MergePDF.CheckedChanged += new System.EventHandler(this.radioButton_Mode_CheckedChanged);
            // 
            // rbt_MergeWord
            // 
            this.rbt_MergeWord.AutoSize = true;
            this.rbt_MergeWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_MergeWord.ForeColor = System.Drawing.Color.Black;
            this.rbt_MergeWord.Location = new System.Drawing.Point(20, 130);
            this.rbt_MergeWord.Name = "rbt_MergeWord";
            this.rbt_MergeWord.Size = new System.Drawing.Size(122, 24);
            this.rbt_MergeWord.TabIndex = 102;
            this.rbt_MergeWord.Tag = "";
            this.rbt_MergeWord.Text = "Merge Word";
            this.rbt_MergeWord.UseVisualStyleBackColor = true;
            this.rbt_MergeWord.CheckedChanged += new System.EventHandler(this.radioButton_Mode_CheckedChanged);
            // 
            // panel_MergePDF
            // 
            this.panel_MergePDF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_MergePDF.Controls.Add(this.rbt_MergePDF_M2);
            this.panel_MergePDF.Controls.Add(this.rbt_MergePDF_M1);
            this.panel_MergePDF.Enabled = false;
            this.panel_MergePDF.Location = new System.Drawing.Point(147, 95);
            this.panel_MergePDF.Name = "panel_MergePDF";
            this.panel_MergePDF.Size = new System.Drawing.Size(200, 30);
            this.panel_MergePDF.TabIndex = 103;
            // 
            // rbt_MergePDF_M2
            // 
            this.rbt_MergePDF_M2.AutoSize = true;
            this.rbt_MergePDF_M2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_MergePDF_M2.ForeColor = System.Drawing.Color.Black;
            this.rbt_MergePDF_M2.Location = new System.Drawing.Point(104, 3);
            this.rbt_MergePDF_M2.Name = "rbt_MergePDF_M2";
            this.rbt_MergePDF_M2.Size = new System.Drawing.Size(86, 21);
            this.rbt_MergePDF_M2.TabIndex = 103;
            this.rbt_MergePDF_M2.Tag = "";
            this.rbt_MergePDF_M2.Text = "Method 2";
            this.rbt_MergePDF_M2.UseVisualStyleBackColor = true;
            // 
            // rbt_MergePDF_M1
            // 
            this.rbt_MergePDF_M1.AutoSize = true;
            this.rbt_MergePDF_M1.Checked = true;
            this.rbt_MergePDF_M1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_MergePDF_M1.ForeColor = System.Drawing.Color.Black;
            this.rbt_MergePDF_M1.Location = new System.Drawing.Point(7, 3);
            this.rbt_MergePDF_M1.Name = "rbt_MergePDF_M1";
            this.rbt_MergePDF_M1.Size = new System.Drawing.Size(86, 21);
            this.rbt_MergePDF_M1.TabIndex = 102;
            this.rbt_MergePDF_M1.TabStop = true;
            this.rbt_MergePDF_M1.Tag = "";
            this.rbt_MergePDF_M1.Text = "Method 1";
            this.rbt_MergePDF_M1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 485);
            this.Controls.Add(this.panel_MergePDF);
            this.Controls.Add(this.rbt_MergeWord);
            this.Controls.Add(this.rbt_MergePDF);
            this.Controls.Add(this.rbt_Excel_to_PDF);
            this.Controls.Add(this.checkBox_Batch);
            this.Controls.Add(this.rbt_File_to_Byte_Array);
            this.Controls.Add(this.rbt_ByteArray_to_File);
            this.Controls.Add(this.panel_Format);
            this.Controls.Add(this.button_Execute);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.tbx_Path_2);
            this.Controls.Add(this.tbx_Path_1);
            this.Controls.Add(this.rbt_Word_to_PDF);
            this.Controls.Add(this.rbt_PDF_to_Word);
            this.Name = "Form1";
            this.Text = "Format Converter Tool v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Format.ResumeLayout(false);
            this.panel_Format.PerformLayout();
            this.panel_MergePDF.ResumeLayout(false);
            this.panel_MergePDF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_Word_to_PDF;
        private System.Windows.Forms.RadioButton rbt_PDF_to_Word;
        private System.Windows.Forms.TextBox tbx_Path_1;
        private System.Windows.Forms.TextBox tbx_Path_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.Panel panel_Format;
        private System.Windows.Forms.RadioButton rbt_pdf;
        private System.Windows.Forms.RadioButton rbt_doc;
        private System.Windows.Forms.RadioButton rbt_docx;
        private System.Windows.Forms.RadioButton rbt_File_to_Byte_Array;
        private System.Windows.Forms.RadioButton rbt_ByteArray_to_File;
        private System.Windows.Forms.RadioButton rbt_xls;
        private System.Windows.Forms.RadioButton rbt_xlsx;
        private System.Windows.Forms.CheckBox checkBox_Batch;
        private System.Windows.Forms.RadioButton rbt_Excel_to_PDF;
        private System.Windows.Forms.RadioButton rbt_MergePDF;
        private System.Windows.Forms.RadioButton rbt_MergeWord;
        private System.Windows.Forms.Panel panel_MergePDF;
        private System.Windows.Forms.RadioButton rbt_MergePDF_M2;
        private System.Windows.Forms.RadioButton rbt_MergePDF_M1;
    }
}

