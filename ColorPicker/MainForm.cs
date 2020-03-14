using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class MainForm : Form
    {
        private ColorControl colorControl = new ColorControl();
        private Point point;

        [DllImport("user32")]
        private static extern IntPtr LoadCursorFromFile(string fileName);

        public MainForm()
        {
            InitializeComponent();
        }


        private void getPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                LoadCursor loadCursor = new LoadCursor();
                loadCursor.CreateCursor();

                Cursor newCur = new Cursor(LoadCursorFromFile("temp.cur"));
                Cursor = newCur;
            }
            catch
            {
                Cursor = Cursors.Default;
            }

            timer.Enabled = true;
        }

        private void getPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            colorControl.SaveHistory();
            Cursor = Cursors.Default;
            timer.Enabled = false;  
        } 

        private void timer_Tick(object sender, EventArgs e)
        {
            point = MousePosition;
            
            //Image Show
            Image img = this.pictureBox.BackgroundImage;
            Bitmap bitmap = new Bitmap(80, 80);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(this.point.X - 40, this.point.Y - 40), new Point(0, 0), new Size(bitmap.Width, bitmap.Height));
            this.pictureBox.BackgroundImage = this.ZoomPicture(bitmap, this.pictureBox.Size);

            colorControl.color = bitmap.GetPixel(bitmap.Width / 2, bitmap.Height / 2);

            //Color Box
            this.showPictureBox.BackColor = colorControl.color;

            //HEX
            this.hexTextBox.Text = colorControl.ToHex();

            //RGB
            this.rTextBox.Text = colorControl.color.R.ToString();
            this.gTextBox.Text = colorControl.color.G.ToString();
            this.bTextBox.Text = colorControl.color.B.ToString();

            //HSI
            this.hTextBox.Text = colorControl.ToHSI().Hue.ToString("0.0000");
            this.sTextBox.Text = colorControl.ToHSI().Saturation.ToString("0.0000");
            this.iTextBox.Text = colorControl.ToHSI().Intensity.ToString("0.0000");

            //CMYK
            this.cTextBox.Text = colorControl.ToCMYK().C.ToString("0.0000");
            this.mTextBox.Text = colorControl.ToCMYK().M.ToString("0.0000");
            this.yTextBox.Text = colorControl.ToCMYK().Y.ToString("0.0000");
            this.kTextBox.Text = colorControl.ToCMYK().K.ToString("0.0000");

            //History
            hisPictureBox1.BackColor = colorControl.history[0];
            hisPictureBox2.BackColor = colorControl.history[1];
            hisPictureBox3.BackColor = colorControl.history[2];
            hisPictureBox4.BackColor = colorControl.history[3];
            hisPictureBox5.BackColor = colorControl.history[4];

            //Pantone
            Pantone pantone = new Pantone();
            this.pantoneTextBox.Text = pantone.getPantone(colorControl.ToHex());
        }

        public Bitmap ZoomPicture(Bitmap bitmap, Size size)
        {
            Bitmap img = new Bitmap(size.Width, size.Height);

            Graphics g = Graphics.FromImage(img);
            g.Clear(Color.Transparent);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            g.DrawImage(bitmap, new Rectangle(0, 0, size.Width, size.Height),
                new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);

            return img;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
    }
}
