using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_oo222bu_2_2_digital_vackarklocka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Första testet
            ViewTestHeader("Test 1:\nTest av standardkonstruktorn");
            AlarmClock firstClock = new AlarmClock();
            Console.WriteLine(firstClock.ToString());
           
            //Andra testet
            ViewTestHeader("Test 2:\nTest av konstruktorn med två parametrar. (9,42)");
            AlarmClock secondClock = new AlarmClock(9, 42);
            Console.WriteLine(secondClock.ToString());
          
            //Tredje testet
            ViewTestHeader("Test 3:\nTest av konstruktorn med fyra parametrar. (13,24,7,35)");
            AlarmClock thirdClock = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(thirdClock.ToString());
           
            //Fjärde testet
            ViewTestHeader("Test 4:\nStäll ett befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
            thirdClock.Hour = 23;
            thirdClock.Minute = 58;
            Run(thirdClock, 13);
           
            //Femte testet
            ViewTestHeader("Test 5:\nStäller befintligt AlarmClock-objekt till tiden 6:12\noch alarmtiden till 6:15 och låter den gå 6 minuter.");
            thirdClock.Hour = 6;
            thirdClock.Minute = 12;
            thirdClock.AlarmHour = 6;
            thirdClock.AlarmMinute = 15;
            Run(thirdClock, 6);
            
            //Sjätte testet
            ViewTestHeader("Test 6:\nTest av egenskaperna så att undantag kastas \ndå tid och alarmtid tilldelas felaktiga värden");
            try
            {
                thirdClock.Hour = 27;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23 .");                
            }
            try
            {
                thirdClock.Minute = 99;
            }
            catch (ArgumentException)
            {

                ViewErrorMessage("Minuten är inte i intervallet 0-59 .");
            }
            try
            {
                thirdClock.AlarmHour = 27;
            }
            catch (ArgumentException)
            {

                ViewErrorMessage("AlarmTimmen är inte i intervallet 0-23 .");
            }
            try
            {
                thirdClock.AlarmMinute = 99;
            }
            catch (ArgumentException)
            {

                ViewErrorMessage("AlarmMinuten är inte i intervallet 0-59 .");
            }

            //Sjunde testet
            ViewTestHeader("Test 7:\nTest av konstruktorer så att undantag kastas då tid och alarmtid tilldelas \nfelaktiga värden.");
            try
            {
                AlarmClock fourthClock=new AlarmClock(27,0);
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23 .");
            }
            try
            {
                AlarmClock fifthClock=new AlarmClock(0,0,27,0);
            }
            catch (ArgumentException)
            {                
                ViewErrorMessage("AlarmTimmen är inte i intervallet 0-23 .");
            }

        }
        //Skapar metoderna
        private static void ViewTestHeader(string header)
        {
            Console.WriteLine("===============================================================================");
            Console.WriteLine(header);
            Console.WriteLine();
        }
        private static void ViewErrorMessage(string message) 
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void Run(AlarmClock ac, int minutes)
        {            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED (TM)       ║ ");
            Console.WriteLine(" ║        Modellnr:1DV402S2L2A          ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.WriteLine();
            Console.ResetColor();       
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock())
                {                    
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(ac.ToString() + "BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(ac.ToString());
                }
            }   
        }
    }
}
