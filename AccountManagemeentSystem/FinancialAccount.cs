using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagemeentSystem
{
    internal static class FinancialAccount
    {

        private static Account[] Account = new Account[10];
        private static int count = 0;
        internal static void AddAccount(Account s)
        {
            Account[count] = s;
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                Account[index].ShowInfo();
                index++;
            }
        }

        internal static bool SearchIndividual(string key, out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
            while (index < count)
            {
                if (Account[index].Id == key)
                {
                    Console.WriteLine("Account Found :");
                    Account[index].ShowInfo();
                    found = true;
                    i = index;
                    return found; //break;
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Account Not found.");

            return found;
        }

        internal static void DeleteAccount(string key)
        {
            int index;
            bool decision = SearchIndividual(key, out index);
            string name = Account[index].Name;
            if (decision)
            {
                Account[index] = null;
                Console.WriteLine(name + " has been deleted.");
            }
        }


        internal static void GetDeposit(string key,int amount)
        {
            
            int index;
            bool decision = SearchIndividual(key, out index);

            if (decision)
            {
                Account[index].Deposit(amount);
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Deposit unsuccessful.");
            }
        }
  
        internal static void GetWithdraw(string key, int amount)
        {

            int index;
            bool decision = SearchIndividual(key, out index);

            if (decision)
            {
                Account[index].Withdraw(amount);
                Console.WriteLine("Withdraw successful.");
            }
            else
            {
                Console.WriteLine("Withdraw unsuccessful.");
            }
       }



    }



}
