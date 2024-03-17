using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository
{
    public class BillRepository : IBillRepository
    {
        public Bill GetBillByID(int billID) => BillDAO.Instance.GetBillByID(billID);

        public IEnumerable<Bill> GetBills() => BillDAO.Instance.GetBillList();

        public void InsertBill(Bill bill) => BillDAO.Instance.AddNew(bill);

        public void DeleteBill(int billID) => BillDAO.Instance.Remove(billID);

        public void UpdateBill(Bill bill) => BillDAO.Instance.Update(bill);
    }
}
