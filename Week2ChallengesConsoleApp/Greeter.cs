using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ChallengesConsoleApp
{
    public class Greeter
    {
        //Challenge 1:  Build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.

        public string userInputName { get; set; }
        public string HelloName(string userInputName)
        {
            string concatenate = "Hello" + " " + userInputName;
            return concatenate;
        }

        // Challenge 2: Build another method that outputs(writes to the Console) some sort of farewell to the name it is given as a parameter.

        public string GoodbyeName(string userInputName)
        {
            string concatenate = "Goodbye" + " " + userInputName;
            return concatenate;
        }

        //Challenge 3: Build a method that outputs(writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.
        public int givenHourTime { get; set; }
        public string GiveATimeOfDay(int givenHourTime)
        {
            int Hour = givenHourTime;
            string greetingResponse = "";

            if (Hour < 12 && Hour >= 0)
            {
                greetingResponse = "Good Morning!";
                return greetingResponse;
            }

            else if (Hour >= 12 && Hour < 17)
            {
                greetingResponse = "Good Afternoon!";
                return greetingResponse;
            }

            else if (Hour >= 17 && Hour < 20)
            {
                greetingResponse = "Good Evening!";
                return greetingResponse;
            }

            else if (Hour >= 20 && Hour <= 23)
            {
                greetingResponse = "Good Night!";
                return greetingResponse;
            }

            return greetingResponse;
        }

    }
}

