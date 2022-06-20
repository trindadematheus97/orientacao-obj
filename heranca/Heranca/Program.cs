using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinesAccount account = new BusinesAccount(1212,"bob",100.0,500.0);
            Console.WriteLine(account.Balance);
        }
    }
}
