using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models.Bill
{
    public class BillModel
    {
        // Fields
        private int bill_id;
        private int seller_id;
        private int buyer_id;
        private int product_id;
        private string product_name;
        private decimal cost;
        private DateTime bill_date;

        // Properties - Validations
        [DisplayName("ID đơn hàng")]
        public int BillId { get => bill_id; set => bill_id = value; }
        [DisplayName("ID người bán")]
        public int SellerId { get => seller_id; set => seller_id = value; }
        [DisplayName("ID người mua")]
        public int BuyerId { get => buyer_id; set => buyer_id = value; }
        [DisplayName("ID sản phẩm")]
        public int ProductId { get => product_id; set => product_id = value; }

        [DisplayName("Tên sản phẩm")]
        public string ProductName { get => product_name; set => product_name = value; }

        [DisplayName("Giá trị đơn hàng")]
        public decimal Cost { get => cost; set => cost = value; }
        [DisplayName("Ngày lên đơn")]
        public DateTime BillDate { get => bill_date; set => bill_date = value; }
    }
}
