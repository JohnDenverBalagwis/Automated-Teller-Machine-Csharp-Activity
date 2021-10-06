using System;

namespace BalagwisJohnDenverActivityatm
{
    class BalagwisUsingWhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine(" BALAGWIS JOHN DENVER ");
            Console.WriteLine("=================================\n");

            int accountNumber = 554433221;
            int pin = 1984;
            string name = "JUAN DELA CRUZ";
            double balance = 35000.00;
            double withdrawAmount;
            int option;

            Console.Write("ENTER ATM NUMBER : ");
            accountNumber = Convert.ToInt32(Console.ReadLine());
            if (accountNumber != 554433221)
            {
                Console.WriteLine("\n");
                Console.WriteLine("INCORRECT ACCOUNT NUMBER ");
                Console.ReadLine();
            }
            else
            {
                Console.Write("ENTER ATM PIN # : ");
                pin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                if (pin != 1984)
                {
                    Console.WriteLine("INCORRECT PIN NUMBER PLEASE TRY AGAIN");
                    Console.ReadLine();
                }
                else if (pin == 1984)
                {
                    while (true)
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("CHOOSE TRANSACTION: 1, 2, 3\n");
                        Console.WriteLine("1. INQUIRE\n");
                        Console.WriteLine("2. WITHDRAW\n");
                        Console.WriteLine("3. EXIT PROGRAM \n");
                        Console.Write("CHOOSE TRANSACTION : ");
                        option = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        if (option == 1)
                        {
                            Console.WriteLine("ATM ACCOUNT NUMBER : " + accountNumber);
                            Console.WriteLine("ACCOUNT NAME : " + name);
                            Console.WriteLine("BALANCE : P " + balance);
                            Console.WriteLine("THANK YOU");
                            Console.ReadLine();
                        }
                        else if (option == 2)
                        {
                            Console.Write("ENTER AMOUNT TO WITHDRAW : ");
                            withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            if (withdrawAmount > 10000.00)
                            {

                                Console.WriteLine("SORRY, WITHDRAWAL IS UP TO 10,000.00 MAXIMUM ONLY");
                                Console.WriteLine("THIS IS YOUR REMAINING BALANCE: P " + balance);
                                Console.ReadLine();
                            }
                            else
                            {
                                balance = balance - withdrawAmount;
                                Console.WriteLine("THIS IS YOUR REMAINING BALANCE: P " + balance);
                                Console.WriteLine("THANK YOU");
                                Console.ReadLine();
                            }
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("THANK YOU");
                            Console.ReadLine();
							break;
                        }
                        else
                        {
                            Console.WriteLine("PLEASE ENTER VALID OPTION");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
