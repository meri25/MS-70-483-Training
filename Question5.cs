using System;
using System.Collections.Generic;
using System.Text;

namespace MS_70_483
{
    class Question5
    {
        #region Option.1
        private static void CovertAmount(float amount)
        {
            TransferFunds((double)amount);
        }
        private static void TransferFunds(double funds)
        {
            Console.WriteLine(funds);
        }
        #endregion

        #region Option.2
        private static void CovertAmount_2(float amount)
        {
            TransferFunds_2((decimal)amount);
        }
        private static void TransferFunds_2(decimal funds)
        {
            Console.WriteLine(funds);
        }
        #endregion

        #region Option.3
        private static void CovertAmount_3(float amount)
        {
           // TransferFunds_3(amount);
        }
        private static void TransferFunds_3(int funds)
        {
            Console.WriteLine(funds);
        }
        #endregion

        #region Option.4
        private static void CovertAmount_4(float amount)
        {
            TransferFunds_4((int)amount);
        }
        private static void TransferFunds_4(float funds)
        {
            Console.WriteLine(funds);
        }
        #endregion
    }

}
