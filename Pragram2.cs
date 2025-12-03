using PersonDetails;
using System;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace BasicFunction2
{
    public class PractiseSet2 
    {
        int GetFactorial(string s)
        {
            int n = int.Parse(s);
            return GetFactorial(n);
        }

        int GetFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * GetFactorial(n - 1);
        }
        public static void Main(string[] args)
        {
            //PractiseSet2 obj = new PractiseSet2();
            //Console.WriteLine(obj.GetFactorial(5));
            PersonDetails.Person objPerson = new PersonDetails.Person("Rahul", 30);
            objPerson.DisplayInfo();

            objPerson.Name = "Raushan";
            objPerson.Age = 25;
            objPerson.DisplayInfo();

            objPerson.Name = "Raushan1";
            objPerson.Age = 27;
            objPerson.DisplayInfo();
            

            PersonDetails.BankAccount objbankAccount = new PersonDetails.BankAccount();
            objbankAccount.Deposit(5000.12);
            objbankAccount.Withdraw(220.00);
            objbankAccount.DisplayBankAccountInfo();

            Console.ReadLine();
        }

    }
}

namespace PersonDetails
{
    class Person
    {
        public String Name;
        private int age1;
        public int Age
        {
            get { return age1; }
            set
            {
                age1 = value;
            }
        }
        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name = {Name}, Age = {age1}, , Age = {Age}");
        }
    }
    class BankAccount
    {
        private double amount { get; set; }
        static int transactionCount = 0;
        public void Deposit(double amount)
        {
            amount += amount;
            transactionCount++;
        }
        public void Withdraw(double amount)
        {
            amount -= amount;
            transactionCount++;
        }
        public void DisplayBankAccountInfo()
        {
            Console.WriteLine($"amount = {amount} , transactionCount = {transactionCount}");
        }
    }
}