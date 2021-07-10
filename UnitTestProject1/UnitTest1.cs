
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
            int index;
            list.InsertBeginning(70);
            list.InsertBeginning(30);
            list.InsertBeginning(10);
            list.InsertBeginning(40);
            index = list.Search(30);
            if (index > 0)
            {
                list.InsertMiddle(100, index + 1);
            }
            
        }
    }
}
