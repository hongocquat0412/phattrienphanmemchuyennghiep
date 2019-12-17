using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanCafe.DAO;

namespace QuanLyCF.test
{
    [TestClass]
    public class QuanLySanPham
    {
        [TestMethod]
        public void TestSearchFoodByName()
        {
            int result = FoodDAO.Instance.SearchFoodByName("m").Count();
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestInsertFood()
        {
            bool result = FoodDAO.Instance.InsertFood("Đen đá không đường", 2, 20000);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestDeleteFood()
        {
            bool result = FoodDAO.Instance.DeleteFood(3);
            Assert.AreEqual(true, result);
        }
    }
}
