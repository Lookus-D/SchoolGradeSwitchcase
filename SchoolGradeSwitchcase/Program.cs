using System;

namespace SchoolGradeSwitchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App to change Arabic numeral to description.");
            //6 = Excellent;

            Console.WriteLine("Give me school grade:");
            string grade = Console.ReadLine();
            int chosenGrade = 0;
            Int32.TryParse(grade, out chosenGrade);

            //which grade is assigned to particular number 1-6 {chosenGrade}
            switch (chosenGrade)
            {
                case 6:
                    Console.WriteLine($"It is \"Excellent\"");
                    break;
                case 5:
                    Console.WriteLine($"It is \"Very good\"");
                    break;
                case 4:
                    Console.WriteLine($"It is \"Good\"");
                    break;
                case 3:
                    Console.WriteLine($"It is \"Satisfactory\"");
                    break;
                case 2:
                    Console.WriteLine($"It is \"Poor\"");
                    break;
                case 1:
                    Console.WriteLine($"It is \"Unsatisfactory\"");
                    break;
                default:
                    Console.WriteLine("Choose another number");
                    break;
            }
        }
    }

}
