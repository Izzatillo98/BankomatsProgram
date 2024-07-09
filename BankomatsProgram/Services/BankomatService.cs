using BankomatsProgram.Model;
using System;
namespace BankomatsProgram.BankomatsServices
{
    public class BankomatService
    {
        PlastCard plastCard = new PlastCard();
        public void UserInterfaceEnter()
        {
            bool isContinue = true;
            do
            {

                try
                {
                    Console.WriteLine("Good day! This program for use bankomat");
                    Console.WriteLine("\t\n1=> Chesk Balance \t\n2=> Withdraw From Balance\t\n3=>  Fill to Balance\n ");
                    Console.Write("Your choise: ");
                    string inputUser = Console.ReadLine();
                    int userInput = Convert.ToInt32(inputUser);

                    switch (userInput)
                    {
                        case 1: CheckBalanse(); break;
                        case 2: WithdrawFromBalance(); break;
                        case 3: FillToBalance(); break;

                        default: Console.WriteLine("Please enter the number between 1 to 3"); break;

                    }

                }
                catch (FormatException FormatException)
                {
                    Console.WriteLine("You should enter only number. Please try again");
                    IsContinue();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please tell to Admin {https://t.me/Itsmetillo} ");
                }

            } while (IsContinue());
        }
        public bool IsContinue()
        {
            bool isContinue = true;
            Console.WriteLine("Do you want continue press (yes/+) ");
            string userInput = Console.ReadLine();
            isContinue = userInput is "yes" or "+";
            return isContinue;
        }
        private void FillToBalance()
        {
            Console.WriteLine("Enter the password");
            string inputPassword = Console.ReadLine();
            if (inputPassword != null && inputPassword == plastCard.PlastCardPassword)
            {
                Console.Write("Enter price \t");
                string inputPrice = Console.ReadLine();
                decimal priceInput = Convert.ToDecimal(inputPrice);
                plastCard.PlastCardBalance = plastCard.PlastCardBalance + priceInput;

                Console.WriteLine("Succesfully");
            }
            else
            {
                Console.WriteLine("Wrong Password. Please try again!");
            }
        }

        private void WithdrawFromBalance()
        {
            Console.WriteLine("Enter the password");
            string inputPassword = Console.ReadLine();
            if (inputPassword != null && inputPassword == plastCard.PlastCardPassword)
            {
                Console.WriteLine("1=> 10$\n 2=> 20$\n 3=> 50$\n 4=> Your choise");
                string checkInput = Console.ReadLine();
                int inputCheck = Convert.ToInt32(checkInput);
                switch (inputCheck)
                {
                    case 1:
                        if (10 <= plastCard.PlastCardBalance)
                        {
                            plastCard.PlastCardBalance = plastCard.PlastCardBalance - 10;
                        }
                        break;
                    case 2:
                        if (20 <= plastCard.PlastCardBalance)
                        {
                            plastCard.PlastCardBalance = plastCard.PlastCardBalance - 20;
                        }
                        break;
                    case 3:
                        if (50 <= plastCard.PlastCardBalance)
                        {
                            plastCard.PlastCardBalance = plastCard.PlastCardBalance - 50;
                        }
                        break;
                    case 4:
                        Console.Write("Enter price \t");
                        string inputPrice = Console.ReadLine();
                        decimal priceInput = Convert.ToDecimal(inputPrice);
                        if (priceInput <= plastCard.PlastCardBalance)
                        {
                            plastCard.PlastCardBalance = plastCard.PlastCardBalance - priceInput;
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter number between 1 to 4"); break;
                }

            }
        }

        private void CheckBalanse()
        {
            Console.WriteLine("Enter the password");
            string inputPassword = Console.ReadLine();
            if (inputPassword != null && inputPassword == plastCard.PlastCardPassword)
            {
                Console.WriteLine($"Your balance have: {plastCard.PlastCardBalance}$");
            }
        }
    }
}

