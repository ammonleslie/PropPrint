
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
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.comboBoxUoM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPageFormat = new System.Windows.Forms.ComboBox();
            this.buttonApplySettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOverlap = new System.Windows.Forms.TextBox();
            this.textBoxMargin = new System.Windows.Forms.TextBox();
            this.imageListPages = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExportPDF = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelSizeUnits = new System.Windows.Forms.Label();
            this.labelMarginUnits = new System.Windows.Forms.Label();
            this.labelOverlapUnits = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.buttonImportImage.Size = new System.Drawing.Size(123, 23);
            this.buttonImportImage.TabIndex = 3;
            this.buttonImportImage.Text = "&Import image...";
            this.buttonImportImage.UseVisualStyleBackColor = true;
            this.buttonImportImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size:";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(153, 73);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize.TabIndex = 5;
            // 
            // comboBoxUoM
            // 
            this.comboBoxUoM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.comboBoxUoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUoM.FormattingEnabled = true;
            this.comboBoxUoM.Location = new System.Drawing.Point(200, 46);
            this.comboBoxUoM.Name = "comboBoxUoM";
            this.comboBoxUoM.Size = new System.Drawing.Size(53, 21);
            this.comboBoxUoM.TabIndex = 7;
            this.comboBoxUoM.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizeUnits_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Page format:";
            // 
            // comboBoxPageFormat
            // 
            this.comboBoxPageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPageFormat.FormattingEnabled = true;
            this.comboBoxPageFormat.Location = new System.Drawing.Point(153, 99);
            this.comboBoxPageFormat.Name = "comboBoxPageFormat";
            this.comboBoxPageFormat.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPageFormat.TabIndex = 9;
            this.comboBoxPageFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageSize_SelectedIndexChanged);
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
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Page margin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Overlap:";
            // 
            // textBoxOverlap
            // 
            this.textBoxOverlap.Location = new System.Drawing.Point(153, 152);
            this.textBoxOverlap.Name = "textBoxOverlap";
            this.textBoxOverlap.Size = new System.Drawing.Size(100, 20);
            this.textBoxOverlap.TabIndex = 13;
            // 
            // textBoxMargin
            // 
            this.textBoxMargin.Location = new System.Drawing.Point(153, 126);
            this.textBoxMargin.Name = "textBoxMargin";
            this.textBoxMargin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMargin.TabIndex = 15;
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
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Units of Measurement:";
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Location = new System.Drawing.Point(521, 694);
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
            this.labelSizeUnits.Location = new System.Drawing.Point(253, 78);
            this.labelSizeUnits.Name = "labelSizeUnits";
            this.labelSizeUnits.Size = new System.Drawing.Size(177, 13);
            this.labelSizeUnits.TabIndex = 19;
            this.labelSizeUnits.Text = "Please select a unit of measurement";
            // 
            // labelMarginUnits
            // 
            this.labelMarginUnits.AutoSize = true;
            this.labelMarginUnits.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMarginUnits.Location = new System.Drawing.Point(253, 131);
            this.labelMarginUnits.Name = "labelMarginUnits";
            this.labelMarginUnits.Size = new System.Drawing.Size(177, 13);
            this.labelMarginUnits.TabIndex = 20;
            this.labelMarginUnits.Text = "Please select a unit of measurement";
            // 
            // labelOverlapUnits
            // 
            this.labelOverlapUnits.AutoSize = true;
            this.labelOverlapUnits.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOverlapUnits.Location = new System.Drawing.Point(253, 157);
            this.labelOverlapUnits.Name = "labelOverlapUnits";
            this.labelOverlapUnits.Size = new System.Drawing.Size(177, 13);
            this.labelOverlapUnits.TabIndex = 21;
            this.labelOverlapUnits.Text = "Please select a unit of measurement";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOverlapUnits);
            this.groupBox1.Controls.Add(this.labelMarginUnits);
            this.groupBox1.Controls.Add(this.labelSizeUnits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxMargin);
            this.groupBox1.Controls.Add(this.textBoxOverlap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxPageFormat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxUoM);
            this.groupBox1.Controls.Add(this.textBoxSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 201);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewPrintPreview);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(521, 13);
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
            this.ClientSize = new System.Drawing.Size(928, 732);
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
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.ComboBox comboBoxUoM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPageFormat;
        private System.Windows.Forms.Button buttonApplySettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOverlap;
        private System.Windows.Forms.TextBox textBoxMargin;
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
    }
}

