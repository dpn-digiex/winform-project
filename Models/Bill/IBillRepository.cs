using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu.Models.Bill
{
    internal interface IBillRepository
    {
        bool Add(BillModel billModel);
        void Edit(BillModel billModel);
        void Delete(int id);

        BillModel GetBillDetail(int id);
        IEnumerable<BillModel> GetAll();
        IEnumerable<BillModel> GetAllByKeyColumn(Dictionary<string, object> fieldValuePair);
    }
}
