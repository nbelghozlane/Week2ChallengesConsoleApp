using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ChallengesConsoleApp
{
    public class GreeterConsoleApp
    {
        static void Main(string[] args)
        {
              //Challenge 1:  Build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.

                Console.WriteLine("What's your name?");
                string userInputName = Console.ReadLine();
                Greeter greeter = new Greeter();
                string placeholder = greeter.HelloName(userInputName);
                
                // Challenge 2: Build another method that outputs(writes to the Console) some sort of farewell to the name it is given as a parameter.

                Greeter farewell = new Greeter();
                string placeholder2 = farewell.GoodbyeName(userInputName);

               //Challenge 3: Build a method that outputs(writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.

                Greeter greetingResponse = new Greeter();
                TimeSpan timeNow = DateTime.Now.TimeOfDay;
                int timeNowHrs = timeNow.Hours;
               
              //Challenge 4: Call all of the methods you've built out.

                Console.WriteLine(placeholder);
                Console.WriteLine(placeholder2);
                Console.WriteLine(greetingResponse.GiveATimeOfDay(timeNowHrs));
                Console.ReadLine();        
        }
    }
}
