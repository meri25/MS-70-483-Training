using System;
using System.Collections.Generic;
using System.Text;

namespace MS_70_483
{
    class Question6
    {
    }

    #region Option.1
    public abstract class Connection_1
    {
/*        public static Connection_1 Create()
        {
            return new Connection_1();
        }*/
    }
    #endregion

    #region Option.2
    public static class Connection_2
    {
/*        public static Connection_2 Create()
        {
            return new Connection_2();
        }*/
    }
    #endregion

    #region
    public class Connection_3
    {
        public static Connection_3 Create()
        {
            return new Connection_3();
        }

        private Connection_3 () { }
    }
    #endregion

    #region
    public class Connection_4
    {
        public static Connection_4 Create()
        {
            return new Connection_4();
        }

        protected Connection_4() { }
    }
    #endregion
}
