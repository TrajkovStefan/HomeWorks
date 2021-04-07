using Exercise4.Classes;
using System;

namespace Exercise4
{
    class Program
    {
        static Customer FindCustomer(Customer[] customers, string cardNumber)
        {
            foreach (Customer customer in customers)
            {
                if (customer.CardNumber == cardNumber)
                {
                    return customer;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            Customer[] customers = new Customer[] {
            new Customer("Bob", "Bobsky", "1234-1234-1234-1234", 1234, 750),
            new Customer("Jilly", "Wayne", "8235-8235-8235-8235", 8923, 1000),
            new Customer("Kate", "Anderson", "0090-1191-2292-3393", 3214, 400),
            new Customer("Greg", "Gregson", "0000-2203-1101-2203", 1477, 800),
            };
            while (true)
            {
                Console.WriteLine("Welcome to our ATM");
                Console.WriteLine("Enter card number");
                string cardNum = Console.ReadLine();


                bool again = false;

                if (String.IsNullOrEmpty(cardNum))
                {
                    Console.WriteLine("You must enter card number");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (cardNum.Length < 16 || cardNum.Length > 16)
                {
                    Console.WriteLine("The card number must be 16 digits");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    string cardNumber = String.Format("{0}-{1}-{2}-{3}", cardNum.Substring(0, 4),
                    cardNum.Substring(4, 4),
                    cardNum.Substring(8, 4),
                    cardNum.Substring(12, 4));

                    Customer customer = FindCustomer(customers, cardNumber);
                    if (customer == null)
                    {
                        Console.WriteLine("You are not found in the system. \nDo you want to register in the system? (yes/no)");
                        string response = Console.ReadLine();
                        if (response.ToLower() == "yes")
                        {
                            Array.Resize(ref customers, customers.Length + 1);
                            customers[customers.Length - 1] = new Customer(cardNumber);
                            Console.WriteLine("You are now a new customer in the system. For other information, please visit us.");
          
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Have a nice day. Goodbye.");
                            Console.ReadLine();
                            break;
                        }
                    }
                    Console.WriteLine("Enter pin");
                    bool success = int.TryParse(Console.ReadLine(), out int pin);
                    Console.WriteLine("Confirm pin");
                    bool success2 = int.TryParse(Console.ReadLine(), out int confirmedPin);
                    if (success && success2)
                    {
                        if (pin == confirmedPin)
                        {
                            if (customer.CheckPin(pin))
                            {
                                Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName}!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect pin");
                                Console.ReadLine();
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                            Console.ReadLine();
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The passwords cant be parsed");
                    }
                    do
                    {
                        Console.WriteLine("What would you like to do? \n 1.Check Balance \n 2.Cash Withdrawal \n 3.Cash Deposit");
                        bool success3 = int.TryParse(Console.ReadLine(), out int option);
                        if (success3)
                        {
                            if (option <= 0 || option > 3)
                            {
                                Console.WriteLine("Choose a number from the list provided");
                                Console.ReadLine();
                                return;
                            }
                            else if (option == 1)
                            {
                                Console.WriteLine($"{ customer.GetAccountBalance()}$");
                            }

                            else if (option == 2)
                            {
                                Console.WriteLine("Enter the amount you want to withdraw");
                                bool success4 = int.TryParse(Console.ReadLine(), out int amount);
                                if (success4)
                                {
                                    if (customer.MakeWithdrawal(amount))
                                    {
                                        Console.WriteLine($"You withdrew {amount}$ from your card. Now you have {customer.GetAccountBalance()}$ left on your card");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You have {customer.GetAccountBalance()}$. You cant withdrawl {amount}$");
                                        Console.ReadLine();
                                        return;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The amount cant be parsed");
                                    Console.ReadLine();
                                    return;
                                }
                            }
                            else if (option == 3)
                            {
                                Console.WriteLine("Enter the amount you want to deposit");
                                bool success5 = int.TryParse(Console.ReadLine(), out int amountDeposit);
                                if (success5)
                                {
                                    if (amountDeposit > 0)
                                    {
                                        customer.MakeDeposit(amountDeposit);
                                        Console.WriteLine($"On your card now you have {customer.GetAccountBalance()}$");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You must enter an amount greater than 0$.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The amount for deposit cant be parsed");
                                    Console.ReadLine();
                                    return;
                                }
                            }
                        }
                        Console.WriteLine("Want to do another option? (y/n)");
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            again = true;
                        }
                        else
                        {
                            again = false;
                            Console.WriteLine($"Goodbye {customer.FirstName}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    while (again == true);
                }
            }
        }
    }
}
