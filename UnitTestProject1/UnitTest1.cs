
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
            //Arrange
            int actual,expected;
            list.InsertBeginning(70);
            list.InsertBeginning(30);
            list.InsertBeginning(10);
            list.InsertBeginning(40);
            //act
            list.DeleteMiddle(10);
            actual = list.Size();
            expected = 3;
            //assert
            Assert.AreEqual(actual, expected);
            
        }
    }
}
