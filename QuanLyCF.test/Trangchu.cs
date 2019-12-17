using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanCafe.DAO;

namespace QuanLyCF.test
{
    [TestClass]
    public class Trangchu
    {
       
        [TestMethod]
        public void TestGetUncheckBillIDByTableID()
        {
            Assert.AreEqual(11, BillDAO.Instance.GetUncheckBillIDByTableID(1));
        }

    }
}
