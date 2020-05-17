using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork05162020
{
    class Atm
    {
        User user;

        #region Operation ATM
        public void Operation(string pin)
        {
            User[] users = GetAllUsers();
            foreach (var user in users)
            {
                if (pin == user.CreditCard.PIN)
                {
                    this.user = user;
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine($" Welcome {user.Name } {user.Surname}");
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    GetBalanceAndMoney();
                    return;
                }
            }





        }
        #endregion


        #region User Array
        public User[] GetAllUsers()
        {
            User[] users = new User[]
           {
                new User("Farid","Xabarov",new Card("56565432654121","5555","145","06/22",235)),
                new User("Fexri","Nuruyev",new Card("56565432654121","4444","213","06/22",200)),
                new User("ELi","Eliyev",new Card("56565432654121","3333","537","06/22",195)),


           };
            return users;

        }
        #endregion

        #region getBAlance && Money
        public void GetBalanceAndMoney()
        {
            Console.WriteLine(" Please select operation ---> Balans(1) / Nagd Pul(2)");

            int.TryParse(Console.ReadLine(), out int word);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            switch (word)
            {
                case 1:
                    Console.WriteLine("\n");
                    Console.WriteLine($" Your balance is:{user.CreditCard.Balans} azn");
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.WriteLine(" Please enter amount of money \n");

                    int pul = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (user.CreditCard.Balans >= pul)
                    {
                        Console.WriteLine($" {pul} azn was deducted from the balance");
                        Console.WriteLine("\n");
                        user.CreditCard.Balans -= pul;

                        Console.WriteLine($" {user.CreditCard.Balans} azn  balans \n");
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        throw new Exception(" You don't have enough money \n");
                    }
                    return;
            }
        }
        #endregion


    }
}
