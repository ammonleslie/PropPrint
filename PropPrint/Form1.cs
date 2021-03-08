using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropPrint
{
    public partial class Form1 : Form
    {
        // stores a copy of the original imported image
        private Image originalImage;
        // copy of original to use for editing
        private Image editImage;

        // lists for available units and page formats
        private List<UoM> unitsList = new List<UoM>();
        private List<PageFormat> pagesList = new List<PageFormat>();

        // list for storing generated pages
        private List<Image> generatedPagesList = new List<Image>();

        // used to store generated PDF file
        private PdfDocument pdf;

        // variables for user input
        UoM selectedUnit;
        PageFormat selectedFormat;
        double sizeWidth, marginTop, overlapTop;

        // variables for finer control
        double sizeHeight, marginSides, overlapSides;

        // booleans to track if user is using finer controls
        bool maintainAspect, sameMargin, sameOverlap;

        // Supported UoMs and PageLayouts
        UoM cm, inch;
        PageFormat A4_port, letter_port, A4_land, letter_land;

        // list of unit label controls
        List<Label> unitLabelsList;

        // default value constants
        public const double DEFAULT_SIZE = 10;
        public const double DEFAULT_MARGIN = 1;
        public const double DEFAULT_OVERLAP = 1;
        public const double MIN_SIZE = 1;
        public const double MIN_MARGIN = 0;
        public const double MIN_OVERLAP = 0;

        public Form1()
        {
            InitializeComponent();

            // setup openfiledialog filters
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.bmp|All Files|*.*";

            // setup saveFileDialog filter
            saveFileDialog1.Filter = "PDF document (*.pdf)|*.pdf";

            // populate unit labels list
            unitLabelsList = new List<Label>() { labelMarginUnits, labelOverlapUnits, labelSizeUnits };

            // populate units list
            populateUnits();
            // populate pages list
            populatePageSizes();

            // set default values and update form fields
            SetInputDefaults();

            // set imageList size
            imageListPages.ImageSize = new Size(256, 256);

        }

        // ####### INITIALIZATION METHODS #######

        /// <summary>
        /// Creates Page Formats and adds them to the appropriate form control
        /// </summary>
        private void populatePageSizes()
        {
            A4_port = new PageFormat("A4 Portrait", 21.0, 29.7, cm, true);
            letter_port = new PageFormat("Letter Portrait", 8.5, 11, inch, true);
            A4_land = new PageFormat("A4 Landscape", 29.7, 21.0, cm, false);
            letter_land = new PageFormat("Letter Landscape", 11, 8.5, inch, false);


            pagesList.Add(A4_port);
            pagesList.Add(letter_port);
            pagesList.Add(A4_land);
            pagesList.Add(letter_land);

            foreach (PageFormat p in pagesList)
            {
                comboBoxPageFormat.Items.Add(p);
            }
        }

        /// <summary>
        /// Creates UoM objects and adds them to the appropriate form control
        /// </summary>
        private void populateUnits()
        {
            cm = new UoM("cm", 28.3465);
            inch = new UoM("in", 72);

            unitsList.Add(cm);
            unitsList.Add(inch);

            foreach (UoM u in unitsList)
            {
                comboBoxUoM.Items.Add(u);
            }
        }

        /// <summary>
        /// Sets the input variables to their default values 
        /// and updates the form fields with the corresponding values
        /// </summary>
        private void SetInputDefaults()
        {
            // set variables
            selectedUnit = cm;
            selectedFormat = A4_port;
            sizeWidth = DEFAULT_SIZE;
            sizeHeight = DEFAULT_SIZE;
            marginTop = DEFAULT_MARGIN;
            overlapTop = DEFAULT_OVERLAP;

            // set form fields
            comboBoxUoM.SelectedItem = cm;
            comboBoxPageFormat.SelectedItem = A4_port;

            textBoxSizeWidth.Text = sizeWidth.ToString("F2");
            textBoxSizeHeight.Text = sizeHeight.ToString("F2");
            textBoxMarginTop.Text = marginTop.ToString("F2");
            textBoxOverlapTop.Text = overlapTop.ToString("F2");

            checkBoxMaintainSizeRatio.Checked = true;
            checkBoxMarginAllSides.Checked = true;
            checkBoxOverlapAllSides.Checked = true;
        }

        // ####### CHECKBOX CHECKED CHANGED EVENTS #######

        /// <summary>
        /// On check change, switches the value of the maintain aspect tracker boolean 
        /// and if aspect ratio is set to be maintained, updates the size height textbox 
        /// based on the size width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxMaintainSizeRatio_CheckedChanged(object sender, EventArgs e)
        {
            // track if ratio to be maintained
            maintainAspect = checkBoxMaintainSizeRatio.Checked;

            // update size height textbox value
            textBoxSizeHeight.Text = GetSizeHeight().ToString("F2");

            if (maintainAspect)
            {
                textBoxSizeWidth.BackColor = Color.FromArgb(220, 240, 255);
                textBoxSizeHeight.BackColor = Color.FromArgb(220, 240, 255);
            }
            else
            {
                textBoxSizeWidth.BackColor = SystemColors.Window;
                textBoxSizeHeight.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// On check change, switches the value of the same margin on all sides tracker, 
        /// updates the read-only property of the margin sides textbox accordingly,
        /// and updates the margin sides value to the top value if all sides are set to be the same
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxMarginAllSides_CheckedChanged(object sender, EventArgs e)
        {
            sameMargin = checkBoxMarginAllSides.Checked;

            textBoxMarginSides.ReadOnly = sameMargin;

            if (sameMargin)
            {
                marginSides = marginTop;
                textBoxMarginSides.Text = textBoxMarginTop.Text;
            }
        }

        /// <summary>
        /// On check change, switches the value of the same overlap on all sides tracker, 
        /// updates the read-only property of the overlap sides textbox accordingly,
        /// and updates the overlap sides value to the top value if all sides are set to be the same
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxOverlapAllSides_CheckedChanged(object sender, EventArgs e)
        {
            sameOverlap = checkBoxOverlapAllSides.Checked;

            textBoxOverlapSides.ReadOnly = sameOverlap;

            if (sameOverlap)
            {
                overlapSides = overlapTop;
                textBoxOverlapSides.Text = textBoxOverlapTop.Text;
            }
        }

        // ####### TEXTBOX LEAVE EVENTS #######

        /// <summary>
        /// On leave, tries to convert the input text to the size width variable, 
        /// updates size height if aspect ratio is maintained, 
        /// and updates the size textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSizeWidth_Leave(object sender, EventArgs e)
        {
            try
            {
                double tempSize = Convert.ToDouble(textBoxSizeWidth.Text);

                if (tempSize >= MIN_SIZE)
                {
                    sizeWidth = tempSize;

                    // update height if aspect ratio is maintained
                    if (maintainAspect)
                    {
                        sizeHeight = GetSizeHeight();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid value entered. Please enter a decimal value greater than or equal to " + MIN_SIZE + ".");
                }
            }
            catch
            {
                MessageBox.Show("Invalid value entered. Please enter a proper decimal value eg. 2, 11.5, 7.0.");
            }

            textBoxSizeHeight.Text = sizeHeight.ToString("F2");
            textBoxSizeWidth.Text = sizeWidth.ToString("F2");

        }

        /// <summary>
        /// On leave, tries to convert the input text to the size height variable,
        /// updates size width if aspect ratio is maintained. 
        /// and updates the size textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSizeHeight_Leave(object sender, EventArgs e)
        {
            try
            {
                double tempSizeHeight = Convert.ToDouble(textBoxSizeHeight.Text);

                if (tempSizeHeight >= MIN_SIZE)
                {
                    sizeHeight = tempSizeHeight;

                    // update width if aspect ratio is maintained
                    if (maintainAspect)
                    {
                        sizeWidth = GetSizeWidth();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid value entered. Please enter a decimal value greater than or equal to " + MIN_SIZE + ".");
                }
            }
            catch
            {
                MessageBox.Show("Invalid value entered. Please enter a proper decimal value eg. 2, 11.5, 7.0.");
            }

            textBoxSizeHeight.Text = sizeHeight.ToString("F2");
            textBoxSizeWidth.Text = sizeWidth.ToString("F2");
        }

        /// <summary>
        /// On leave, tries to convert the input text to the margin top variable, 
        /// sets the margin sides variable if all sides are set to be the same, and 
        /// updates the margin textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxMarginTop_Leave(object sender, EventArgs e)
        {
            try
            {
                double tempMarginTop = Convert.ToDouble(textBoxMarginTop.Text);

                if (tempMarginTop >= MIN_MARGIN)
                {
                    marginTop = tempMarginTop;
                }
                else
                {
                    MessageBox.Show("Invalid value entered. Please enter a decimal value greater than or equal to " + MIN_MARGIN + ".");
                }
            }
            catch
            {
                MessageBox.Show("Invalid value entered. Please enter a proper decimal value eg. 2, 11.5, 7.0.");
            }

            if (sameMargin)
            {
                marginSides = marginTop;
            }

            textBoxMarginTop.Text = marginTop.ToString("F2");
            textBoxMarginSides.Text = marginSides.ToString("F2");
        }

        /// <summary>
        /// On leave, if side margins are not set to be the same as the top, 
        /// tries to convert the input text to the margin sides variable, 
        /// and updates the margin sides textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxMarginSides_Leave(object sender, EventArgs e)
        {
            if (!sameMargin)
            {
                try
                {
                    double tempMarginSides = Convert.ToDouble(textBoxMarginSides.Text);

                    if (tempMarginSides >= MIN_MARGIN)
                    {
                        marginSides = tempMarginSides;
                    }
                    else
                    {
                        MessageBox.Show("Invalid value entered. Please enter a decimal value greater than or equal to " + MIN_MARGIN + ".");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid value entered. Please enter a proper decimal value eg. 2, 11.5, 7.0.");
                }
            }

            textBoxMarginSides.Text = marginSides.ToString("F2");
        }

        /// <summary>
        /// On leave, tries to set convert the input text to the overlap top variable, 
        /// sets the overlap sides variable if they are set to be the same, 
        /// and updates the overlap textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxOverlapTop_Leave(object sender, EventArgs e)
        {
            try
            {
                double tempOverlapTop = Convert.ToDouble(textBoxOverlapTop.Text);

                if (tempOverlapTop >= MIN_OVERLAP)
                {
                    overlapTop = tempOverlapTop;
                }
                else
                {
                    MessageBox.Show("Invalid value entered. Please enter a decimal value greater than or equal to " + MIN_OVERLAP + ".");
                }
            }
            catch
            {
                MessageBox.Show("Invalid value entered. Please enter a proper decimal value eg. 2, 11.5, 7.0.");
            }

            if (sameOverlap)
            {
                overlapSides = overlapTop;
            }

            textBoxOverlapTop.Text = overlapTop.ToString("F2");
            textBoxOverlapSides.Text = overlapSides.ToString("F2");
        }

        /// <summary>
        /// On leave, if side overlap is not set to be the same as top, 
        /// tries to convert the input text to the overlap sides variable, 
        /// and updates the overlap sides textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxOverlapSides_Leave(object sender, EventArgs e)
        {
            if (!sameOverlap)
            {
                try
                {
                    double tempOverlapSides = Convert.ToDouble(textBoxOverlapSides.Text);

                    if (tempOverlapSides >= MIN_OVERLAP)
                    {
                        overlapSides = tempOverlapSides;
                    }
                    else
                    {
                        MessageBox.Show("Invalid value entered. Please enter a decimal value greater than or equal to " + MIN_OVERLAP + ".");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid value entered. Please enter a proper decimal value eg. 2, 11.5, 7.0.");
                }
            }

            textBoxOverlapSides.Text = overlapSides.ToString("F2");
        }

        // ####### COMBOBOX INDEX CHANGED EVENTS #######

        /// <summary>
        /// On index change, updates the selected UoM variable, 
        /// and changes the unit labels on the form to match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSizeUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUnit = (UoM)comboBoxUoM.SelectedItem;

            foreach (Label l in unitLabelsList)
            {
                l.Text = selectedUnit.ToString();
            }
        }

        /// <summary>
        /// On index change, updates the selected page format variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPageFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFormat = (PageFormat)comboBoxPageFormat.SelectedItem;
        }

        // ####### BUTTON CLICK EVENTS #######

        /// <summary>
        /// On click, allows the user to import an image for processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImportImage_Click(object sender, EventArgs e)
        {
            // if the user imports an image, store the original and an editing copy
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originalImage = Image.FromFile(openFileDialog1.FileName);
                editImage = (Image)originalImage.Clone();
            }

            textBoxSizeHeight.Text = GetSizeHeight().ToString("F2");
            UpdatePreview();
        }

        private void buttonApplySettings_Click(object sender, EventArgs e)
        {
            Console.WriteLine("----- START PROCESSING -----");

            // check inputs are valid
            if (CheckImageImported())
            {
                int newPixelWidth, newPixelHeight;

                // reset preview images
                imageListPages.Images.Clear();
                listViewPrintPreview.Items.Clear();

                // reset generated images
                generatedPagesList.Clear();

                try
                {
                    // convert original pixel dimensions to selected UoM
                    double currentUnitWidth, currentUnitHeight;
                    currentUnitWidth = selectedUnit.FromPixels(originalImage.Width);
                    currentUnitHeight = selectedUnit.FromPixels(originalImage.Height);

                    // calculate scale
                    double scaleX = sizeWidth / currentUnitWidth;
                    double scaleY = sizeHeight / currentUnitHeight;

                    // get new pixel dimensions based on scale
                    newPixelWidth = (int)(originalImage.Width * scaleX);
                    newPixelHeight = (int)(originalImage.Height * scaleY);

                    // resize original image and save to edit image
                    editImage = ResizeImage(originalImage, newPixelWidth, newPixelHeight);

                    // refresh preview
                    UpdatePreview();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Please enter proper decimal values eg. 5.25, 2.0, 8");
                    Console.WriteLine("-----------------------------------");
                    return;
                }

                // calculate individual page image size
                Size individualImageSize = CalculatePageImageSize();

                if (individualImageSize.Width <= 0 || individualImageSize.Height <= 0)
                {
                    MessageBox.Show("Individual image size calculation failed.");
                    Console.WriteLine("-----------------------------------");
                    return;
                }

                // default start point
                Point origin = new Point(0, 0);

                // check and convert page format units to selected units
                double selectedFormatWidth = selectedFormat.Width();
                double selectedFormatHeight = selectedFormat.Height();

                if (selectedFormat.Units() != selectedUnit)
                {
                    if (selectedUnit == cm)
                    {
                        selectedFormatWidth = UoM.ConvertInchToCM(selectedFormatWidth);
                        selectedFormatHeight = UoM.ConvertInchToCM(selectedFormatHeight);
                    }
                    else
                    {
                        selectedFormatWidth = UoM.ConvertCMtoInch(selectedFormatWidth);
                        selectedFormatHeight = UoM.ConvertCMtoInch(selectedFormatHeight);
                    }
                }

                // save copy of edit image
                Image editImageClean = (Image)editImage.Clone();

                // convert overlap to pixels
                int pixelOverlapTop = selectedUnit.ToPixels(overlapTop);
                int pixelOverlapSides = selectedUnit.ToPixels(overlapSides);

                // create cutting rectangle at start point
                Rectangle cutLines = new Rectangle(origin, individualImageSize);

                // graphics objects for drawing and cutting
                Graphics graphics = Graphics.FromImage(editImage);
                Pen pen = new Pen(Color.Red, 3);

                // get margin size in pixels
                int marginPixelsTop = selectedUnit.ToPixels(marginTop);
                int marginPixelsSides = selectedUnit.ToPixels(marginSides);

                selectedFormat = (PageFormat)comboBoxPageFormat.SelectedItem;

                // for entire height of image
                for (int y = 0; y < newPixelHeight; y += (individualImageSize.Height - pixelOverlapTop))
                {
                    // for each width of image
                    for (int x = 0; x < newPixelWidth; x += (individualImageSize.Width - pixelOverlapSides))
                    {
                        cutLines.X = x;

                        cutLines.Y = y;

                        graphics.DrawRectangle(pen, cutLines);

                        // create cutout and move to list
                        Image cutImage = new Bitmap(selectedUnit.ToPixels(selectedFormatWidth), selectedUnit.ToPixels(selectedFormatHeight));

                        using (Graphics g = Graphics.FromImage(cutImage))
                        {
                            g.FillRectangle(Brushes.White, 0, 0, cutImage.Width, cutImage.Height);
                            g.DrawImage(editImageClean, marginPixelsSides, marginPixelsTop, cutLines, GraphicsUnit.Pixel);
                        }

                        generatedPagesList.Add(cutImage);

                        // create thumbnail of image
                        Bitmap thumb = GenerateThumbnail(cutImage);
                        this.imageListPages.Images.Add(thumb);
                    }
                }

                this.listViewPrintPreview.LargeImageList = this.imageListPages;

                for (int j = 0; j < this.imageListPages.Images.Count; j++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = j;
                    this.listViewPrintPreview.Items.Add(item);
                }

                UpdatePreview();

            }

            else
            {
                Console.WriteLine("Failed!");
            }

            Console.WriteLine("----- END PROCESSING -----");
            Console.WriteLine();
        }

        /// <summary>
        /// On click, turns the generated pages list into PDF pages, 
        /// saves it to the directory specified from the save file dialog, 
        /// and opens the saved PDF file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            // check pages have been generated
            if (generatedPagesList.Count > 0)
            {
                pdf = new PdfDocument();

                // create a page for each image
                foreach (Image p in generatedPagesList)
                {
                    PdfPage newPage = pdf.AddPage();

                    // set page size to image size
                    newPage.Width = p.Width;
                    newPage.Height = p.Height;

                    // get PDF page graphics to draw onto
                    XGraphics g = XGraphics.FromPdfPage(newPage);

                    // get xImage copy of image
                    MemoryStream strm = new MemoryStream();
                    p.Save(strm, System.Drawing.Imaging.ImageFormat.Png);
                    XImage xImage = XImage.FromStream(strm);

                    // draw image onto PDF page
                    g.DrawImage(xImage, 0, 0, xImage.Width, xImage.Height);

                    // keep it clean
                    strm.Close();
                }

                // save the file and open
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pdf.Save(saveFileDialog1.FileName);
                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("No image has been processed. Please import an image and apply your settings before trying to export to PDF.");
            }
        }

        // ####### CUSTOM METHODS #######

        private double GetSizeHeight()
        {

            if (originalImage == null)
            {
                return DEFAULT_SIZE;
            }
            try
            {
                sizeWidth = Convert.ToDouble(textBoxSizeWidth.Text);

                double ratio = sizeWidth / originalImage.Width;

                sizeHeight = originalImage.Height * ratio;

                return sizeHeight;
            }
            catch
            {
                return 0;
            }
        }

        private double GetSizeWidth()
        {
            if (originalImage == null)
            {
                return DEFAULT_SIZE;
            }
            try
            {
                sizeHeight = Convert.ToDouble(textBoxSizeHeight.Text);

                double ratio = sizeHeight / originalImage.Height;

                sizeWidth = originalImage.Width * ratio;

                return sizeWidth;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Refreshes the image preview to display the most recent version of the editing image
        /// </summary>
        private void UpdatePreview()
        {
            pictureBoxImagePreview.Image = editImage;
        }

        private bool CheckImageImported()
        {
            // check if image imported
            if (originalImage == null)
            {
                MessageBox.Show("Please import an image for processing.");
                return false;
            }

            return true;
        }

        private Bitmap GenerateThumbnail(Image image)
        {
            int tw, th, tx, ty;

            int w = image.Width;
            int h = image.Height;

            //get the ratio of width / height
            double whRatio = (double)w / h;

            if (image.Width >= image.Height)

            {
                //set the width to 32 and compute the height
                tw = 256;
                th = (int)(tw / whRatio);
            }
            else
            {
                //otherwise set the height to 32 and compute the width
                th = 256;
                tw = (int)(th * whRatio);
            }

            //now we compute where in our final image we're going to draw it
            tx = (256 - tw) / 2;
            ty = (256 - th) / 2;

            //create our final image - you can set the PixelFormat to anything that suits
            Bitmap thumb = new Bitmap(256, 256, PixelFormat.Format24bppRgb);

            //get a Graphics from this final image
            Graphics g = Graphics.FromImage(thumb);

            //clear the final image to white (or anything else) for the areas that the input image doesn't cover

            g.Clear(Color.FromArgb(150, 150, 150));

            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(image, new Rectangle(tx, ty, tw, th), new Rectangle(0, 0, w, h), GraphicsUnit.Pixel);

            return thumb;
        }

        private Size CalculatePageImageSize()
        {
            try
            {
                // check and convert page format units to selected units
                double selectedFormatWidth = selectedFormat.Width();
                double selectedFormatHeight = selectedFormat.Height();

                if (selectedFormat.Units() != selectedUnit)
                {
                    if (selectedUnit == cm)
                    {
                        selectedFormatWidth = UoM.ConvertInchToCM(selectedFormatWidth);
                        selectedFormatHeight = UoM.ConvertInchToCM(selectedFormatHeight);
                    }
                    else
                    {
                        selectedFormatWidth = UoM.ConvertCMtoInch(selectedFormatWidth);
                        selectedFormatHeight = UoM.ConvertCMtoInch(selectedFormatHeight);
                    }
                }

                // account for margin
                double imageWidth = selectedFormatWidth - marginSides * 2;
                double imageHeight = selectedFormatHeight - marginTop * 2;

                // calculate pixel dimensions
                int width = selectedUnit.ToPixels(imageWidth);
                int height = selectedUnit.ToPixels(imageHeight);

                Size size = new Size(width, height);

                return size;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return new Size(0, 0);
            }

            
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;

        }

        
    }
}
