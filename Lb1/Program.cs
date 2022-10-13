using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1
{
    class Program
    {
        static void Main(string[] args) 
        {
            var account = new GameAccount("Timoner","Sergio", 50);
            Console.WriteLine($"Game Account was created with Nickname: {account.UserName} and your current Rating is {account.CurrentRating}");
            account.LoseGame("Sergio", 11);
            Console.WriteLine(account.CurrentRating);
            account.WinGame("Rak228", 20);
            Console.WriteLine(account.CurrentRating);

            Console.WriteLine(account.GetStats());

            try
            {
                var invalidAccount = new GameAccount("Timoner", "Sergio", -30);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            try
            {
                account.LoseGame("Sergio", 200);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
        }

    }
}
    