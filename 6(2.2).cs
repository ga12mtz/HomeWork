using System.IO;
using System;

class Program
{
    public enum Bank
    {
        tekushie,
        kreditnie,
        depositnie,
        budjetnie,
        socViplat
    }
    struct BankSchet
    {
        public int numberOfSchet;
        public decimal balans;
        public Bank bank;
        public void Init(int num, decimal bal, Bank b)
        {
            numberOfSchet = num;
            balans = bal;
            bank = b;
        }
        public void Write()
        {
            Console.WriteLine(numberOfSchet);
            Console.WriteLine(balans);
            Console.WriteLine(bank);
        }
    }
    static void Main()
    {
        BankSchet client = new BankSchet();
        client.Init(1245, 145, Bank.budjetnie);
        client.Write();
        
    }
}
