using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Utils;

namespace PhanMemTraoDoiDoCu.Components
{
    public partial class CardProduct : UserControl
    {
        private bool isHovered = false;
        public int ProductId { set;  get; }

        public string Name
        {
            set { labelName.Text = value; }
            get { return labelName.Text; }
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
        public byte[] ImageProduct
        {
            set { pictureProduct.Image = HelperApplication.ConvertByteArrayToImage(value); }
        }
        public CardProduct()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            labelLikenew.Paint += BorderedLabel_Paint;
            this.MouseEnter += OnMouseEnterCard;
            this.MouseLeave += OnMouseLeaveCard;
            foreach (Control child in this.Controls)
            {
                child.MouseEnter += OnMouseEnterCard;
                child.MouseLeave += OnMouseLeaveCard;
            }
        }

        private void OnMouseEnterCard(object sender, EventArgs e)
        {
            isHovered = true;
            Invalidate(); // Yêu cầu vẽ lại control
        }
        private void OnMouseLeaveCard(object sender, EventArgs e)
        {
            isHovered = false;
            Invalidate(); // Yêu cầu vẽ lại control
        }

        private void BorderedLabel_Paint(object sender, PaintEventArgs e)
        {
            int radius = 12;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.labelLikenew.Width - 1, this.labelLikenew.Height - 1);

            // Tạo một path mới
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                // Vẽ border color
                using (Pen pen = new Pen(ColorTranslator.FromHtml("#ff9d00"), 2))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawControl(e.Graphics);
        }

        private void DrawControl(Graphics graphics)
        {
            int radius = 12;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                string colorHex = isHovered ? "#444444" : "#323232";
                using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml(colorHex)))
                {
                    graphics.FillPath(brush, path);
                }
            }
        }

        private void CardProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
