using Patagames.Pdf.Enums;
using Patagames.Pdf.Net;
using System.Drawing.Imaging;
using System.Security;
using System.Windows.Forms;

namespace PDFtoImage
{
    public partial class PDFtoImage : Form
    {
        public PDFtoImage()
        {
            InitializeComponent();
        }
        private void PDFtoImage_Load(object sender, EventArgs e)
        {
            OFD.Title = "Open Image...";
            OFD.Filter = "PDF Files|*.pdf";

            SFD.Title = "Save As...";
            SFD.Filter = "PNG Image|*.png";
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
                txtOFN.Text = OFD.FileName;
        }

        private void BtnSFD_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK)
                txtSFN.Text = SFD.FileName;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                using (var doc = PdfDocument.Load(txtOFN.Text))
                {
                    int iPage = 1;
                    foreach (var page in doc.Pages)
                    {
                        int width = (int)(page.Width / 72.0 * 96);
                        int height = (int)(page.Height / 72.0 * 96);
                        using var bitmap = new PdfBitmap(width, height, true);
                        bitmap.FillRect(0, 0, width, height, Patagames.Pdf.FS_COLOR.White);
                        page.Render(bitmap, 0, 0, width, height, PageRotate.Normal, RenderFlags.FPDF_LCD_TEXT);
                        string strSFN = txtSFN.Text;
                        strSFN = strSFN.Replace(".png", string.Format(".{0}.png", iPage++), StringComparison.OrdinalIgnoreCase);
                        bitmap.GetImage().Save(string.Format(string.Format(@"{0}", strSFN), ImageFormat.Png));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
