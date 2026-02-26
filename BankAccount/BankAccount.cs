using System;

class BankAccount
{
    private readonly string _accountNumber;
    private string _ownerName;
    private int _balance = 0;

    public string OwnerName { get { return _ownerName; } set { _ownerName = value; } }
    public int Balance 
    {
        get { return _balance; } 
        private set 
        {
            if (value >= 0)
            {
                _balance = value;
            }
        } 
    }

    public BankAccount(string accountNumber, string ownerName)
    {
        this._accountNumber = accountNumber;
        OwnerName = ownerName;
        Console.WriteLine($"계좌번호: {this._accountNumber}\n예금주: {OwnerName}\n잔액: {Balance}");
    }

    public void Deposit(int amount)
    {
        if(amount >= 0)
        {
            Balance += amount;
            Console.WriteLine($"--- {amount}원 입금 ---");
            Console.WriteLine($"잔액: {Balance}");
        }
        else
        {
            Console.WriteLine($"--- {amount}원 입금 ---");
            Console.WriteLine("입금 실패");
        }
    }

    public void Withdraw(int amount)
    {
        Balance -= amount;
        if(Balance < amount)
        {
            Console.WriteLine($"--- {amount}원 출금 시도 ---");
            Console.WriteLine("출금 성공: False");
            Console.WriteLine($"잔액: {Balance}");
        }
        else
        {
            Console.WriteLine($"--- {amount}원 출금 ---");
            Console.WriteLine("출금 성공: True");
            Console.WriteLine($"잔액: {Balance}");
        }
    }
}