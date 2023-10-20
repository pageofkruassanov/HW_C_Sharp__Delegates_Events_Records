using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp__Delegates_Events_Records
{
    internal class Program
    {
        delegate void ShowMessage(string mess);

        delegate double CalculateNumbers(double firstNum, double secondNum);

        delegate bool CheckNumber(int num);
        static void Main(string[] args)
        {
            // Task 1:
            Message message1 = new Message("Hello");
            Message messgae2 = new Message(", world!");

            ShowMessage getMessage = new ShowMessage(Message.DisplayMessage);
            getMessage.Invoke(message1.ToString());
            getMessage.Invoke(messgae2.ToString());

            // Task 2:

            Console.WriteLine("-----------------------");

            double firstNumD = 7.75;
            double secondNumD = 2.21;

            CalculateNumbers calculateNumbers = new CalculateNumbers(ArithmeticOperations.Addition);
            Console.WriteLine(calculateNumbers.Invoke(firstNumD, secondNumD));

            calculateNumbers += ArithmeticOperations.Subtraction;
            Console.WriteLine(calculateNumbers.Invoke(firstNumD, secondNumD));

            calculateNumbers += ArithmeticOperations.Multiplication;
            Console.WriteLine(calculateNumbers.Invoke(firstNumD, secondNumD));

            // Task 3:
            Console.WriteLine("-----------------------");

            int num = 7;

            CheckNumber checkNumber = new CheckNumber(CheckNum.IsPair);
            Console.WriteLine(checkNumber.Invoke(num));

            checkNumber += CheckNum.IsFibonacci;
            Console.WriteLine(checkNumber.Invoke(num));

            checkNumber += CheckNum.IsPrime;
            Console.WriteLine(checkNumber.Invoke(num));



            Console.ReadLine();

        }
    }
}
