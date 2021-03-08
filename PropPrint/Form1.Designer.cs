
namespace PropPrint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxImagePreview = new System.Windows.Forms.PictureBox();
            this.listViewPrintPreview = new System.Windows.Forms.ListView();
            this.buttonImportImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSizeWidth = new System.Windows.Forms.TextBox();
            this.comboBoxUoM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPageFormat = new System.Windows.Forms.ComboBox();
            this.buttonApplySettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOverlapTop = new System.Windows.Forms.TextBox();
            this.textBoxMarginTop = new System.Windows.Forms.TextBox();
            this.imageListPages = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExportPDF = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelSizeUnits = new System.Windows.Forms.Label();
            this.labelMarginUnits = new System.Windows.Forms.Label();
            this.labelOverlapUnits = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxOverlapAllSides = new System.Windows.Forms.CheckBox();
            this.checkBoxMarginAllSides = new System.Windows.Forms.CheckBox();
            this.checkBoxMaintainSizeRatio = new System.Windows.Forms.CheckBox();
            this.textBoxOverlapSides = new System.Windows.Forms.TextBox();
            this.textBoxMarginSides = new System.Windows.Forms.TextBox();
            this.textBoxSizeHeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImagePreview
            // 
            this.pictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImagePreview.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxImagePreview.Name = "pictureBoxImagePreview";
            this.pictureBoxImagePreview.Size = new System.Drawing.Size(444, 387);
            this.pictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagePreview.TabIndex = 0;
            this.pictureBoxImagePreview.TabStop = false;
            // 
            // listViewPrintPreview
            // 
            this.listViewPrintPreview.BackColor = System.Drawing.Color.Gray;
            this.listViewPrintPreview.HideSelection = false;
            this.listViewPrintPreview.Location = new System.Drawing.Point(26, 19);
            this.listViewPrintPreview.Name = "listViewPrintPreview";
            this.listViewPrintPreview.Size = new System.Drawing.Size(338, 638);
            this.listViewPrintPreview.TabIndex = 1;
            this.listViewPrintPreview.TileSize = new System.Drawing.Size(32, 32);
            this.listViewPrintPreview.UseCompatibleStateImageBehavior = false;
            // 
            // buttonImportImage
            // 
            this.buttonImportImage.Location = new System.Drawing.Point(165, 420);
            this.buttonImportImage.Name = "buttonImportImage";
            this.buttonImportImage.Size = new System.Drawing.Size(123, 31);
            this.buttonImportImage.TabIndex = 3;
            this.buttonImportImage.Text = "&Import image...";
            this.buttonImportImage.UseVisualStyleBackColor = true;
            this.buttonImportImage.Click += new System.EventHandler(this.buttonImportImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size:";
            // 
            // textBoxSizeWidth
            // 
            this.textBoxSizeWidth.Location = new System.Drawing.Point(199, 73);
            this.textBoxSizeWidth.Name = "textBoxSizeWidth";
            this.textBoxSizeWidth.Size = new System.Drawing.Size(77, 20);
            this.textBoxSizeWidth.TabIndex = 5;
            this.textBoxSizeWidth.Leave += new System.EventHandler(this.textBoxSizeWidth_Leave);
            // 
            // comboBoxUoM
            // 
            this.comboBoxUoM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.comboBoxUoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUoM.FormattingEnabled = true;
            this.comboBoxUoM.Location = new System.Drawing.Point(223, 46);
            this.comboBoxUoM.Name = "comboBoxUoM";
            this.comboBoxUoM.Size = new System.Drawing.Size(53, 21);
            this.comboBoxUoM.TabIndex = 7;
            this.comboBoxUoM.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizeUnits_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Page format:";
            // 
            // comboBoxPageFormat
            // 
            this.comboBoxPageFormat.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPageFormat.FormattingEnabled = true;
            this.comboBoxPageFormat.Location = new System.Drawing.Point(199, 99);
            this.comboBoxPageFormat.Name = "comboBoxPageFormat";
            this.comboBoxPageFormat.Size = new System.Drawing.Size(178, 21);
            this.comboBoxPageFormat.TabIndex = 9;
            this.comboBoxPageFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageFormat_SelectedIndexChanged);
            // 
            // buttonApplySettings
            // 
            this.buttonApplySettings.Location = new System.Drawing.Point(313, 694);
            this.buttonApplySettings.Name = "buttonApplySettings";
            this.buttonApplySettings.Size = new System.Drawing.Size(143, 23);
            this.buttonApplySettings.TabIndex = 10;
            this.buttonApplySettings.Text = "&Apply Settings";
            this.buttonApplySettings.UseVisualStyleBackColor = true;
            this.buttonApplySettings.Click += new System.EventHandler(this.buttonApplySettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Page margin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Overlap:";
            // 
            // textBoxOverlapTop
            // 
            this.textBoxOverlapTop.Location = new System.Drawing.Point(199, 152);
            this.textBoxOverlapTop.Name = "textBoxOverlapTop";
            this.textBoxOverlapTop.Size = new System.Drawing.Size(77, 20);
            this.textBoxOverlapTop.TabIndex = 13;
            this.textBoxOverlapTop.Leave += new System.EventHandler(this.textBoxOverlapTop_Leave);
            // 
            // textBoxMarginTop
            // 
            this.textBoxMarginTop.Location = new System.Drawing.Point(199, 126);
            this.textBoxMarginTop.Name = "textBoxMarginTop";
            this.textBoxMarginTop.Size = new System.Drawing.Size(77, 20);
            this.textBoxMarginTop.TabIndex = 15;
            this.textBoxMarginTop.Leave += new System.EventHandler(this.textBoxMarginTop_Leave);
            // 
            // imageListPages
            // 
            this.imageListPages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPages.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListPages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Units of Measurement:";
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Location = new System.Drawing.Point(949, 694);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(102, 23);
            this.buttonExportPDF.TabIndex = 18;
            this.buttonExportPDF.Text = "&Export PDF...";
            this.buttonExportPDF.UseVisualStyleBackColor = true;
            this.buttonExportPDF.Click += new System.EventHandler(this.buttonExportPDF_Click);
            // 
            // labelSizeUnits
            // 
            this.labelSizeUnits.AutoSize = true;
            this.labelSizeUnits.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSizeUnits.Location = new System.Drawing.Point(383, 76);
            this.labelSizeUnits.Name = "labelSizeUnits";
            this.labelSizeUnits.Size = new System.Drawing.Size(40, 13);
            this.labelSizeUnits.TabIndex = 19;
            this.labelSizeUnits.Text = "UNITS";
            // 
            // labelMarginUnits
            // 
            this.labelMarginUnits.AutoSize = true;
            this.labelMarginUnits.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMarginUnits.Location = new System.Drawing.Point(407, 129);
            this.labelMarginUnits.Name = "labelMarginUnits";
            this.labelMarginUnits.Size = new System.Drawing.Size(40, 13);
            this.labelMarginUnits.TabIndex = 20;
            this.labelMarginUnits.Text = "UNITS";
            // 
            // labelOverlapUnits
            // 
            this.labelOverlapUnits.AutoSize = true;
            this.labelOverlapUnits.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOverlapUnits.Location = new System.Drawing.Point(407, 155);
            this.labelOverlapUnits.Name = "labelOverlapUnits";
            this.labelOverlapUnits.Size = new System.Drawing.Size(40, 13);
            this.labelOverlapUnits.TabIndex = 21;
            this.labelOverlapUnits.Text = "UNITS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxOverlapAllSides);
            this.groupBox1.Controls.Add(this.checkBoxMarginAllSides);
            this.groupBox1.Controls.Add(this.checkBoxMaintainSizeRatio);
            this.groupBox1.Controls.Add(this.textBoxOverlapSides);
            this.groupBox1.Controls.Add(this.textBoxMarginSides);
            this.groupBox1.Controls.Add(this.textBoxSizeHeight);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelOverlapUnits);
            this.groupBox1.Controls.Add(this.labelMarginUnits);
            this.groupBox1.Controls.Add(this.labelSizeUnits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxMarginTop);
            this.groupBox1.Controls.Add(this.textBoxOverlapTop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxPageFormat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxUoM);
            this.groupBox1.Controls.Add(this.textBoxSizeWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 201);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkBoxOverlapAllSides
            // 
            this.checkBoxOverlapAllSides.AutoSize = true;
            this.checkBoxOverlapAllSides.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxOverlapAllSides.Location = new System.Drawing.Point(471, 154);
            this.checkBoxOverlapAllSides.Name = "checkBoxOverlapAllSides";
            this.checkBoxOverlapAllSides.Size = new System.Drawing.Size(139, 17);
            this.checkBoxOverlapAllSides.TabIndex = 33;
            this.checkBoxOverlapAllSides.Text = "One overlap for all sides";
            this.checkBoxOverlapAllSides.UseVisualStyleBackColor = true;
            this.checkBoxOverlapAllSides.CheckedChanged += new System.EventHandler(this.checkBoxOverlapAllSides_CheckedChanged);
            // 
            // checkBoxMarginAllSides
            // 
            this.checkBoxMarginAllSides.AutoSize = true;
            this.checkBoxMarginAllSides.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxMarginAllSides.Location = new System.Drawing.Point(471, 128);
            this.checkBoxMarginAllSides.Name = "checkBoxMarginAllSides";
            this.checkBoxMarginAllSides.Size = new System.Drawing.Size(135, 17);
            this.checkBoxMarginAllSides.TabIndex = 32;
            this.checkBoxMarginAllSides.Text = "One margin for all sides";
            this.checkBoxMarginAllSides.UseVisualStyleBackColor = true;
            this.checkBoxMarginAllSides.CheckedChanged += new System.EventHandler(this.checkBoxMarginAllSides_CheckedChanged);
            // 
            // checkBoxMaintainSizeRatio
            // 
            this.checkBoxMaintainSizeRatio.AutoSize = true;
            this.checkBoxMaintainSizeRatio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxMaintainSizeRatio.Location = new System.Drawing.Point(471, 75);
            this.checkBoxMaintainSizeRatio.Name = "checkBoxMaintainSizeRatio";
            this.checkBoxMaintainSizeRatio.Size = new System.Drawing.Size(124, 17);
            this.checkBoxMaintainSizeRatio.TabIndex = 31;
            this.checkBoxMaintainSizeRatio.Text = "Maintain aspect ratio";
            this.checkBoxMaintainSizeRatio.UseVisualStyleBackColor = true;
            this.checkBoxMaintainSizeRatio.CheckedChanged += new System.EventHandler(this.checkBoxMaintainSizeRatio_CheckedChanged);
            // 
            // textBoxOverlapSides
            // 
            this.textBoxOverlapSides.Location = new System.Drawing.Point(324, 152);
            this.textBoxOverlapSides.Name = "textBoxOverlapSides";
            this.textBoxOverlapSides.Size = new System.Drawing.Size(77, 20);
            this.textBoxOverlapSides.TabIndex = 29;
            this.textBoxOverlapSides.Leave += new System.EventHandler(this.textBoxOverlapSides_Leave);
            // 
            // textBoxMarginSides
            // 
            this.textBoxMarginSides.Location = new System.Drawing.Point(324, 126);
            this.textBoxMarginSides.Name = "textBoxMarginSides";
            this.textBoxMarginSides.Size = new System.Drawing.Size(77, 20);
            this.textBoxMarginSides.TabIndex = 28;
            this.textBoxMarginSides.Leave += new System.EventHandler(this.textBoxMarginSides_Leave);
            // 
            // textBoxSizeHeight
            // 
            this.textBoxSizeHeight.Location = new System.Drawing.Point(300, 73);
            this.textBoxSizeHeight.Name = "textBoxSizeHeight";
            this.textBoxSizeHeight.Size = new System.Drawing.Size(77, 20);
            this.textBoxSizeHeight.TabIndex = 27;
            this.textBoxSizeHeight.Leave += new System.EventHandler(this.textBoxSizeHeight_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sides:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Top/Bottom:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Top/Bottom:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sides:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewPrintPreview);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(949, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 675);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pages Preview";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExportPDF);
            this.Controls.Add(this.buttonApplySettings);
            this.Controls.Add(this.buttonImportImage);
            this.Controls.Add(this.pictureBoxImagePreview);
            this.Name = "Form1";
            this.Text = "PropPrint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagePreview;
        private System.Windows.Forms.Button buttonImportImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSizeWidth;
        private System.Windows.Forms.ComboBox comboBoxUoM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPageFormat;
        private System.Windows.Forms.Button buttonApplySettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOverlapTop;
        private System.Windows.Forms.TextBox textBoxMarginTop;
        private System.Windows.Forms.ImageList imageListPages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewPrintPreview;
        private System.Windows.Forms.Button buttonExportPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelSizeUnits;
        private System.Windows.Forms.Label labelMarginUnits;
        private System.Windows.Forms.Label labelOverlapUnits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMarginSides;
        private System.Windows.Forms.TextBox textBoxSizeHeight;
        private System.Windows.Forms.TextBox textBoxOverlapSides;
        private System.Windows.Forms.CheckBox checkBoxOverlapAllSides;
        private System.Windows.Forms.CheckBox checkBoxMarginAllSides;
        private System.Windows.Forms.CheckBox checkBoxMaintainSizeRatio;
    }
}

