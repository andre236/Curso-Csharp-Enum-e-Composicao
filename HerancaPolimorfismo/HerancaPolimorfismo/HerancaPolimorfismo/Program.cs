﻿using System;
using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alek", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
