using System;

namespace HWnumber8Lab.Classes
{
    internal class BankTransaction
    {
        readonly DateTime DateTime;
        readonly decimal AmountOfMoney;

        public BankTransaction(decimal amountOfMoney)
        {
            DateTime = DateTime.Now;
            AmountOfMoney = amountOfMoney;
        }
    }
}
