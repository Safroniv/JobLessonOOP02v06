using System;

namespace JobLessonOOP02v06Part04
{
    class BankAccount
    {
        private int _numberBankAccount;
        private decimal _ballanceBankAccount;
        private TypeBankAccount _typeBankAccount;
        private static int _generateNumberBankAccount=0000_0000_1000_0000;
        public static int GenerateNumberBankAccount(){return _generateNumberBankAccount++;}
        public int NumberBankAcconut{get{ return _numberBankAccount; } }
        public decimal BallanceBankAccount { get { return _ballanceBankAccount; } }       
        public TypeBankAccount TypeBankAccount { get { return _typeBankAccount; } }

        public BankAccount() : this(100, TypeBankAccount.Current) { }
        public BankAccount(decimal ballanceBankAccount) : this(ballanceBankAccount, TypeBankAccount.Budget) { }
        public BankAccount(TypeBankAccount typeBankAccount) : this(2000, typeBankAccount) { }
        public BankAccount (decimal ballanceBankAccount, TypeBankAccount typeBankAccount)
        {
            _numberBankAccount = GenerateNumberBankAccount();
            _ballanceBankAccount = ballanceBankAccount;
            _typeBankAccount = typeBankAccount;
        }
        public void Print()
        {
            Console.WriteLine(
                $"Банковский счёт пользователя: # {NumberBankAcconut} " + "\n" +
                $"Количество средств на счёте пользователя: {BallanceBankAccount } " + "\n" +
                $"Тип счёта: {TypeBankAccount}" + "\n" +
                $"======================================================== ");            
        }
    }
}
