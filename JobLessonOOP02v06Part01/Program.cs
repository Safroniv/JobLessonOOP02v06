using System;

namespace JobLessonOOP02v06Part02
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
