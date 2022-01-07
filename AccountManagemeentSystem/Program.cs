using System;

namespace AccountManagemeentSystem
{
    class Program
    {

        private static int option = 0;

        internal static void StartSystem()
        {
            /*
		   FinancialAccount.AddAccount(new Savings("Kazi", new JoiningDate(2, "May", 1999), new OurAddress(10, 20, "Chittagong", "Wakanda"), 30000));
		   FinancialAccount.AddAccount(new Current("Gazi", new JoiningDate(12, "June", 1997), new OurAddress(10, 20, "Dhaka", "Ugaanda"), 20000));
		   FinancialAccount.AddAccount(new Loan("Mir", new JoiningDate(12, "June", 1997), new OurAddress(10, 20, "Kulna", "Hogwarts"), 10000));
		   //FinancialAccount.ShowAll();
		   //FinancialAccount.SearchIndividual("P-2-s");
		   // FinancialAccount.DeleteAccount("P-2-s");
		   FinancialAccount.ShowAll();
            */

           

           
            
            Console.WriteLine("Welcome To Dhaka Bank");
            Console.WriteLine("Welcome To Account Management System");
            Console.WriteLine("Choose a option you want");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Search Account");
            Console.WriteLine("3. Show All Account");
            Console.WriteLine("4. Delete Account");
            Console.WriteLine("5. Deposit Account");
            Console.WriteLine("6.Withdraw");
            Console.WriteLine("7.Transfer");
            Console.WriteLine("8.Check Balance");
            Console.WriteLine("9. Exit System");



            while (true)
            {
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    FinancialAccount.AddAccount(new Savings("Kazi Samin Mahmud", new JoiningDate(12, "july", 1992), new OurAddress(25, 50, "Chittagong", "Bangladesh"), 50000));
                    FinancialAccount.AddAccount(new Savings("Nowrin Akhter", new JoiningDate(11, "March", 1994), new OurAddress(50, 40 , "Chittagong", "Bangladesh"), 40000));
                    FinancialAccount.AddAccount(new Current(" Tafannum Tory", new JoiningDate(14, "July", 1995), new OurAddress(10, 30, "Dhaka", "Bangladesh"), 25000));
                    FinancialAccount.AddAccount(new Loan("Shakil Khan", new JoiningDate(17, "August", 1991), new OurAddress(40, 27, "Sylhet", "Bangladesh"), 10000));
                    Console.WriteLine("1.Acoount Created");
                    Console.WriteLine("2.Acoount Created");
                    Console.WriteLine("3.Acoount Created");
                    Console.WriteLine("4.Acoount Created");

                }
                else if (option == 2)
                {
                    
                    FinancialAccount.SearchIndividual("AS-1", out int a);

                }
                else if (option == 3)
                {
                    FinancialAccount.ShowAll();

                }
                else if (option == 4)
                {
                    FinancialAccount.DeleteAccount("AC-1");

                }
                else if (option == 5)
                {
                   
                    FinancialAccount.GetDeposit("AS-2",500);

                }
                else if (option == 6)
                {
                    
                    FinancialAccount.GetWithdraw("AS-2",500);

                }
                else if (option == 7)
                {

                  FinancialAccount.GetWithdraw("AS-1", 500);

                }
                else if (option == 8)
                {

                    //FinancialAccount.GetTransfer("As-2", 500);

                }

                else if (option == 9)
                {
                    break;

                }

            }
        }










        static void Main(string[] args)
        {

            /*
                 Account a1 = new Savings("Kazi", new JoiningDate(2, "May", 1999), new OurAddress(10, 20, "Chittagong", "Wakanda"), 30000);
                 Account a2 = new Loan("Gazi", new JoiningDate(12, "June", 1997), new OurAddress(10, 20, "Dhaka", "Ugaanda"), 20000);
                 Account a3 = new Current("Mir", new JoiningDate(12, "June", 1997), new OurAddress(10, 20, "Kulna", "Hogwarts"), 10000);

                 a1.ShowInfo();
                 a2.ShowInfo();
                 a3.ShowInfo();
             */

            StartSystem();

        }
    }
    
}
