using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Components
{
    public partial class PaperProduct : UserControl
    {
        private bool isHovered = false;
        public int ProductId { set; get; }

        public string Name
        {
            set { labelProductName.Text = value; }
            get { return labelProductName.Text; }
        }

        public string CurrentPrice
        {
            set { labelCurrentPrice.Text = value; }
            get { return labelCurrentPrice.Text; }
        }
        public string OriginalPrice
        {
            set { labelOriginalPrice.Text = value; }
            get { return labelOriginalPrice.Text; }
        }

        public string Discount
        {
            set { labelDiscount.Text = value; }
            get { return labelDiscount.Text; }
        }
        public string Likenew
        {
            set { labelLikenew.Text = value; }
            get { return labelLikenew.Text; }
        }
        public string YearPurchase
        {
            set { labelYearPurchase.Text = "Năm: " + value; }
            get { return labelYearPurchase.Text; }
        }
        public string Status
        {
            set { labelStatus.Text = "Tình trạng: " + value; }
            get { return labelLikenew.Text; }
        }
        public byte[] ImageProduct
        {
            set { pictureProduct.Image = HelperApplication.ConvertByteArrayToImage(value); }
        }
        public PaperProduct()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.MouseEnter += OnMouseEnterPaper;
            this.MouseLeave += OnMouseLeavePaper;
            foreach (Control child in this.Controls)
            {
                child.MouseEnter += OnMouseEnterPaper;
                child.MouseLeave += OnMouseLeavePaper;
            }
        }
        private void OnMouseEnterPaper(object sender, EventArgs e)
        {
            isHovered = true;
            Invalidate(); // Yêu cầu vẽ lại control
        }
        private void OnMouseLeavePaper(object sender, EventArgs e)
        {
            isHovered = false;
            Invalidate(); // Yêu cầu vẽ lại control
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawControl(e.Graphics);
        }
        private void DrawControl(Graphics graphics)
        {
            int radius = 16;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                //string colorHex = isHovered ? "#7BAFD4" : "#5F73C4";
                string colorHex = isHovered ? "#444444" : "#323232";
                using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml(colorHex)))
                {
                    graphics.FillPath(brush, path);
                }
            }
        }
        private void PaperProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
