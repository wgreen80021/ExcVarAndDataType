using System;
 

namespace ExcVarAndDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course are you on ? ");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number ? ");
            string intPageNum = Console.ReadLine();
            Console.WriteLine("Do you need help with anything ? Please answer true or false");
            string boolHelp = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string strExp = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string intHour = Console.ReadLine();
            
            //Console.WriteLine("You have answered the following questions :  ") ;

            //Console.WriteLine("What Course are you on >  " + courseName );
            //Console.WriteLine("What page number >  " + intPageNum);
            //Console.WriteLine("Do you need help with anything ? Please answer true or false >  " + boolHelp);
            //Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics > " + strExp);
            //Console.WriteLine("How many hours did you study today > " + intHour);
           
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day! ");
            Console.ReadLine();





        }
    }
}
