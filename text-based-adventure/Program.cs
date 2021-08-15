using System;
using System.Threading.Tasks;

namespace text_based_adventure
{
    class Program
    {
        static void warning()
        {
            Console.SetCursorPosition(1, 50);
            Console.WriteLine("Loading...  |  Please note: This project is a WIP");
        }
        
        static void menu()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Welcome to...");
            string intro = @"
 ______      __                        __                       __     
/\  _  \    /\ \                      /\ \__                   /\ \    
\ \ \L\ \   \_\ \  __  __    __    ___\ \ ,_\ __  __  _ __   __\ \ \   
 \ \  __ \  /'_` \/\ \/\ \ /'__`\/' _ `\ \ \//\ \/\ \/\`'__/'__`\ \ \  
  \ \ \/\ \/\ \L\ \ \ \_/ /\  __//\ \/\ \ \ \\ \ \_\ \ \ \/\  __/\ \_\ 
   \ \_\ \_\ \___,_\ \___/\ \____\ \_\ \_\ \__\ \____/\ \_\ \____\\/\_\
    \/_/\/_/\/__,_ /\/__/  \/____/\/_/\/_/\/__/\/___/  \/_/\/____/ \/_/
                                                                       
                                                                                                 
                            ";
            Console.WriteLine(intro);
        }
        
        static void Main(string[] args)
        {
            warning();
            var pause = Task.Delay(2000);
            pause.Wait();
            Console.Clear();
            menu();
            //Console.WriteLine("insert welcome ascii here");



            /*
             ADDITIONAL LINKS 
             */

            //Follow these links for the main menu
            //https://www.youtube.com/watch?v=qAWhGEPMlS8
            //https://www.youtube.com/watch?v=A3UqpcQu4E0
        }
    }
}
