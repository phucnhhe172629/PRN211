using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IBillRepository
    {
        IEnumerable<Bill> GetBills();
        Bill GetBillByID(int billId);
        void InsertBill(Bill bill);
        void DeleteBill(int billId);
        void UpdateBill(Bill bill);
    }
}
