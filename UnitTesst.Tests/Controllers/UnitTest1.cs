using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesst.Models;
using UnitTesst.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;

namespace UnitTesst.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndex()
        {
            var db = new Model1();
            var controller = new ExpenditureController();

            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(List<Expenditure>));
            Assert.AreEqual(db.Expenditures.Count(),(result.Model as List<Expenditure>).Count);
        }

     

    }
}
