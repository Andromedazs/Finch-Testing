using System;


namespace Finch_Testing
{
    class Program
    {
        static void Main(string[] args)
        { 
         Finch myFinch;
         myfinch = new Finch();

                
            //
            // call connect method
            //
            myFinch.connect();

            //
            // Code
            //
            finchRobot.setLED(0, 102, 204);
            finchRobot.wait(3000);
            finchRobot.setLED(0, 255, 255);
            finchRobot.wait(3000);
            finchRobot.setLED(153, 204, 0);
            finchRobot.wait(3000);
            finchRobot.noteOff();

            //
            // disconnect method
            //
            myFinch.disconnect();
        {
         Console.WriteLine("Press any key to exit");
                Console.ReadKey();
        }
    }
}
