using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class BillDAO
    {
        private static BillDAO instance = null;
        private static readonly object instanceLock = new object();
        private BillDAO() { }
        public static BillDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BillDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Bill> GetBillList()
        {
            var bills = new List<Bill>();
            try
            {
                using var context = new PRNProjectContext();
                bills = context.Bills.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bills;
        }

        public Bill GetBillByID(int BillID)
        {
            Bill bill = null;
            try
            {
                using var context = new PRNProjectContext();
                bill = context.Bills.SingleOrDefault(c => c.BillId == BillID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bill;
        }

        // Add new a Bill
        public void AddNew(Bill bill)
        {
            try
            {
                Bill _bill = GetBillByID(bill.BillId);
                if (_bill == null)
                {
                    using var context = new PRNProjectContext();
                    context.Bills.Add(bill);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Bill is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Update a Bill
        public void Update(Bill bill)
        {
            try
            {
                Bill _bill = GetBillByID(bill.BillId);
                if (_bill != null)
                {
                    using var context = new PRNProjectContext();
                    context.Bills.Update(bill);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Bill does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Remove a Bill
        public void Remove(int billId)
        {
            try
            {
                Bill bill = GetBillByID(billId);
                if (bill != null)
                {
                    using var context = new PRNProjectContext();
                    bill.Status = 0;
                    context.Bills.Update(bill);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Bill does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
