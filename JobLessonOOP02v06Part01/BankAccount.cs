using System;

namespace JobLessonOOP02v06Part01
{
    class BankAccount
    {
        private int _numberBankAccount;
        private decimal _ballanceBankAccount;
        private TypeBankAccount _typeBankAccount;
        public int GetNumberBankAcconut() { return _numberBankAccount; }
        public void SetNumberBankAcconut(int numberBankAccount)
        { _numberBankAccount= numberBankAccount; }
        public decimal GetBallanceBankAccount() { return _ballanceBankAccount; }
        public void SetBallanceBankAccount(decimal ballanceBankAccount)
        { _ballanceBankAccount = ballanceBankAccount; }
        public TypeBankAccount GetTypeBankAccount() { return _typeBankAccount; }
        public void SetTypeBankAccount(TypeBankAccount typeBankAccount)
        { _typeBankAccount = typeBankAccount; }
        public void Print()
        {
            Console.WriteLine(
                $"Банковский счёт пользователя: # {GetNumberBankAcconut()} " + "\n" +
                $"Количество средств на счёте пользователя: {GetBallanceBankAccount() } " + "\n" +
                $"Тип счёта: {GetTypeBankAccount()}" + "\n" +
                $"======================================================== ");
            Console.ReadLine();
        }
    }
}
