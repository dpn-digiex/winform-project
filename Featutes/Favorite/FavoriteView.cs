using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemTraoDoiDoCu.Features.ProductDetail;
using PhanMemTraoDoiDoCu.Models.Product;

namespace PhanMemTraoDoiDoCu.Features.Favourite
{
    public partial class FavoriteView : Form, IFavoriteView
    {
        //Fields
        private string message;
        public FavoriteView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler ViewListUserFavoriteEvent;
        public event EventHandler UnlikeProductEvent;

        public void SetProductListBindingSource(BindingSource productList)
        {
            dataGridViewFavorite.DataSource = productList;
        }

        //Singleton pattern (Open a single form instance)
        private static FavoriteView instance;
        public static FavoriteView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FavoriteView();
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
        private void dataGridViewFavorite_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem click có phải là header row hay không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng tại vị trí được click
                DataGridViewRow row = dataGridViewFavorite.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột cụ thể
                int productId = Convert.ToInt32(row.Cells[0].Value);  // Sử dụng chỉ số cột nếu biết chính xác
                var productDetailView = new ProductDetailForm(productId);
                IProductRepository repo = new ProductRepository();
                new ProductDetailPresenter(productDetailView, repo);
            }
        }

        private void FavoriteView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewFavorite_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewFavorite.Columns[e.ColumnIndex].Name == "OriginalPrice" && e.Value != null)
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
            if (dataGridViewFavorite.Columns[e.ColumnIndex].Name == "Discount" && e.Value != null)
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
            if (dataGridViewFavorite.Columns[e.ColumnIndex].Name == "LikenewPercentage" && e.Value != null)
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
