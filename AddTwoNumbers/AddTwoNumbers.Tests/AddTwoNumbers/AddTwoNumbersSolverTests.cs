using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AddTwoNumbers.AddTwoNumbersSolver;

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

        [TestMethod]
        public void AddTwoNumbersSolver_ShouldBeAbleToAddMoreThanOneNodesLength()
        {
            var answer = new ListNode(4, new ListNode(1));
            var sut = new AddTwoNumbersSolver();
            var list1 = new ListNode(3);
            list1.next = new ListNode(2);
            var list2 = new ListNode(1);
            var result = sut.AddTwoNumbers(list1, list2);
            Assert.IsNotNull(result);
            AssertListsWereAddedProperly(result, answer);
        }

        private void AssertListsWereAddedProperly(ListNode l1, ListNode l2)
        {
            var next1 = l1;
            var next2 = l2;
            while(next1.next != null)
            {
                if(next1.val == next2.val)
                {
                    next1 = next1.next;
                    next2 = next2.next;
                }
                else
                {
                    Assert.Fail("Values were not the expected result.");
                }
            }
            if(next1.next == null && next2.next != null)
            {
                Assert.Fail("List 1 did not complete the addition process correctly.");
            }
        }
    }
}
