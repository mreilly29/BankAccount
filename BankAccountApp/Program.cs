using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool appRunState = true; //application run state control variable    
            
            Client myClientInfo = new Client();
            Checking myCheckingAcct = new Checking();
            myCheckingAcct.AcctBal = 300;
            Savings mySavingsAcct = new Savings();
            mySavingsAcct.AcctBal = 300;
            mySavingsAcct.MinBal = 150;

            //promt user for Clent Info for UI
            Console.WriteLine("Welcome to Bank Account. Please enter Your First Name");
            myClientInfo.FName = Console.ReadLine();

            Console.WriteLine("Please enter Your Last Name");
            myClientInfo.LName = Console.ReadLine();

            Console.WriteLine("Please enter your account number");
            myClientInfo.AccountNum = Console.ReadLine();

            do
            { 
                Console.WriteLine();
                Console.WriteLine("< 1 > View Client Information");
                Console.WriteLine("< 2 > View Account Balance");
                Console.WriteLine("< 3 > Deposit Funds");
                Console.WriteLine("< 4 > Withdraw Funds");
                Console.WriteLine("< 5 > Exit \n");

                
                // prompt menu response
                int menuSelection = int.Parse(Console.ReadLine());

                //display action and call class methods
                if (menuSelection == 1)
                {
                    // view client info
                    Console.WriteLine("First Name: {0}", myClientInfo.FName);
                    Console.WriteLine("Last Name: {0}", myClientInfo.LName);
                    Console.WriteLine("Account Number: {0}", myClientInfo.AccountNum);


                }
                else if (menuSelection == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("< a > Checking Account");                    
                    Console.WriteLine("< b > Savings Account \n");
                    // prompt sub- menu response
                    string subMenuSelection = Console.ReadLine().ToLower();
                    if (subMenuSelection == "a")
                    {//balance from checkings                                      
                        double input = myCheckingAcct.GetBalance();
                        Console.WriteLine("Checking balance: is ${0}", input);
                    }
                    if (subMenuSelection == "b")
                    {//balance from savings
                        double input = mySavingsAcct.GetBalance();
                        Console.WriteLine("Checking balance: is ${0}", input);
                        
                    }
                }
                else if (menuSelection == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("< a > Checking Account");
                    Console.WriteLine("< b > Savings Account\n");
                    // prompt sub- menu response
                    string subMenuSelection = Console.ReadLine().ToLower();
                    if (subMenuSelection == "a")
                    {//deposit into checkings
                        Console.WriteLine("How much would you like to deposit?");
                        double input = double.Parse(Console.ReadLine());
                        myCheckingAcct.GetDeposit(input);
                    }
                    if (subMenuSelection == "b")
                    {//deposit into savings
                        Console.WriteLine("How much would you like to deposit?");
                        double input = double.Parse(Console.ReadLine());
                        mySavingsAcct.GetDeposit(input);
                    }
                }
                else if (menuSelection == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("< a > Checking Account");
                    Console.WriteLine("< b > Savings Account \n");
                    // prompt sub- menu response
                    string subMenuSelection = Console.ReadLine().ToLower();
                    if (subMenuSelection == "a")
                    {//withdraw from checking
                        Console.WriteLine("How much would you like to withdraw?");
                        double input = double.Parse(Console.ReadLine());
                        myCheckingAcct.GetWithdraw(input);
                    }
                    if (subMenuSelection == "b")
                    {//withdraw from savings
                        Console.WriteLine("How much would you like to withdraw?");
                        double input = double.Parse(Console.ReadLine());
                        mySavingsAcct.GetWithdraw(input);
                    }
                }
                else if (menuSelection == 5)
                {
                    appRunState = false;
                }
                else
                {
                    Console.WriteLine("Number invalid.");
                }

            } while (appRunState);
        }
    }
}
