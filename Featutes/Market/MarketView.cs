using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Features.ProductDetail;
using PhanMemTraoDoiDoCu.Models.Product;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanMemTraoDoiDoCu.Features.Market
{
    public partial class MarketView : Form, IMarketView
    {
        //Fields
        private string message;
        public MarketView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }
        public string SearchProductValue {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler ViewDetailProductEvent;

        public void SetProductListBindingSource(BindingSource productList)
        {
            dataGridViewProduct.DataSource = productList;
        }

        //Singleton pattern (Open a single form instance)
        private static MarketView instance;
        public static MarketView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MarketView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void dataGridViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem click có phải là header row hay không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng tại vị trí được click
                DataGridViewRow row = dataGridViewProduct.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột cụ thể
                int productId = Convert.ToInt32(row.Cells[0].Value);  // Sử dụng chỉ số cột nếu biết chính xác
                var productDetailView = new ProductDetailForm(productId);
                IProductRepository repo = new ProductRepository();
                new ProductDetailPresenter(productDetailView, repo);
            }
        }

        private void MarketView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewProduct.Columns[e.ColumnIndex].Name == "OriginalPrice" && e.Value != null)
            {
                try
                {
                    e.Value = decimal.Parse(e.Value.ToString()).ToString("#,##0") + " đ";
                    e.FormattingApplied = true;
                }
                catch
                {
                    e.FormattingApplied = false;
                }
            }
            if (dataGridViewProduct.Columns[e.ColumnIndex].Name == "Discount" && e.Value != null)
            {
                try
                {
                    e.Value = e.Value.ToString() + "%";
                    e.FormattingApplied = true;
                }
                catch
                {
                    e.FormattingApplied = false;
                }
            }
            if (dataGridViewProduct.Columns[e.ColumnIndex].Name == "LikenewPercentage" && e.Value != null)
            {
                try
                {
                    e.Value = e.Value.ToString() + "%";
                    e.FormattingApplied = true;
                }
                catch
                {
                    e.FormattingApplied = false;
                }
            }
        }
    }
}
