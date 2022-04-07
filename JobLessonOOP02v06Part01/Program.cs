using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLessonOOP02v06Part01
{
    class Program
    {
        static void Main()
        {
            BankAccount mybankAccount = new BankAccount();
            mybankAccount.SetNumberBankAcconut(1);
            mybankAccount.SetBallanceBankAccount(9999.99m);
            mybankAccount.SetTypeBankAccount(TypeBankAccount.Current);
            mybankAccount.Print();
        }
    }
}
