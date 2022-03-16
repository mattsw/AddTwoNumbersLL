using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers.Tests.AddTwoNumbers
{
    [TestClass]
    public class AddTwoNumbersSolverTests
    {
        [TestMethod]
        public void AddTwoNumbersSolver_ShouldBeAbleToAddTwoSimplenumbers()
        {
            var sut = new AddTwoNumbersSolver();
            var list1 = new AddTwoNumbersSolver.ListNode(3);
            var list2 = new AddTwoNumbersSolver.ListNode(1);
            var result = sut.AddTwoNumbers(list1, list2);
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.val);
        }
    }
}
