using System;

namespace GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            float points = 0f;
            float GPA=0f;
            string studentName="";


            while (studentName.Equals(""))
            {
                Console.Write("Stunent name: ");
                studentName = Console.ReadLine();
            }

           while (true)
            {
                float score;               
                Console.WriteLine("please enter the -{0}- (whole number 0-20) if finished enter (-1)" ,i+1);
                bool succes = float.TryParse(Console.ReadLine(), out score);
                if (score == -1)
                {
                    break;
                }
                if (!succes || score<0 || score>20)
                {
                    Console.WriteLine("this is not correct entry, try again!");
                    continue;
                }
                
                points += score;
                i++;
            }
            GPA = (points / (float)i);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("{0}'s GPA is: {1}",studentName,GPA);
            Console.ReadLine();
        }
        
    }
}
