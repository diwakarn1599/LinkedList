
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;


namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        UserLinkedList list;

        [TestInitialize]
        public void Setup()
        {
            list= new UserLinkedList();
        }
        [TestMethod]
        public void TestMethod1()
        {
            int actual,expected;
            list.InsertBeginning(70);
            list.InsertBeginning(30);
            list.InsertBeginning(10);
            list.InsertBeginning(40);
            actual = list.Search(30);
            expected = 3;
            Assert.AreEqual(actual, expected);

        }
    }
}
