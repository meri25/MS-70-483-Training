using System;
using System.Collections.Generic;
using System.Text;

namespace MS_70_483
{
    class Question7
    {
    }
    public class Class1 : Class2
    {
    }
    public interface INewInterface
    {
        void Method1();
    }
    public class Class2 : INewInterface
    {
        void INewInterface.Method1()
        {
            throw new NotImplementedException();
        }

    }
}
