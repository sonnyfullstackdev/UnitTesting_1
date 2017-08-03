using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestApi.Service;
using System.Collections.Generic;

namespace UnitTestApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("1234", "1234");

        }
        public class MockStorage: IDataStorage
        {
            List<string> names = new List<string>();
            public List<string> NameList { get
                {
                    return names;
                } }
            public int Insert(string name)
            {
                names.Add(name);
                return names.Count;
            }
        }

        [TestMethod]
        public void TestCrudService()
        {
            int expectedId = 3;
            MockStorage ms = new MockStorage();
            CrudService cs = new CrudService(ms);
            cs.Create("Testing");
            cs.Create("Testing");
            cs.Create("Testing");

            Assert.AreEqual(expectedId, ms.NameList.Count);
        }
    }
}
