using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eventTest_1
{
    public delegate void TestDel();
    class MyTestClass
    {
        public TestDel TestEevnt;

        public void RaiseEvent()
        {
            TestEevnt();
        }
    }
}
