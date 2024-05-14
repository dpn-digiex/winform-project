using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemTraoDoiDoCu.Components
{
    public partial class LabelPagination : UserControl
    {
        // Fields
        private bool isCurrentPage;

        public event EventHandler LabelClick;
        public string LabelText
        {
            get { return labelPage.Text; }
            set { labelPage.Text = value; }
        }
        public bool IsCurrentPage
        {
            get { return isCurrentPage; }
            set
            {
                isCurrentPage = value;
                labelPage.ForeColor = isCurrentPage ? ColorTranslator.FromHtml("#2d55ff") : ColorTranslator.FromHtml("#ccc");
            }
        }
        public LabelPagination()
        {
            InitializeComponent();
            labelPage.ForeColor = ColorTranslator.FromHtml("#ccc"); // Màu mặc định
            this.labelPage.Click += LabelPage_Click;
            labelPage.MouseEnter += Label_MouseEnter;
            labelPage.MouseLeave += Label_MouseLeave;
        }
        private void LabelPage_Click(object sender, EventArgs e)
        {
            LabelClick?.Invoke(this, e);
        }
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            if (!isCurrentPage) // Chỉ thay đổi màu khi không phải là trang hiện tại
            {
                labelPage.ForeColor = ColorTranslator.FromHtml("#2d55ff");
            }
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            if (!isCurrentPage) // Khôi phục màu mặc định khi không phải là trang hiện tại
            {
                labelPage.ForeColor = ColorTranslator.FromHtml("#ccc");
            }
        }
    }
}
