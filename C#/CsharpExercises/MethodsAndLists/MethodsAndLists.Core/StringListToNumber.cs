using System.Linq;

namespace MethodsAndLists.Core
{
    public class StringListToNumber
    {
        public int ElevatorGoUpAndDown(string[] input)
        {

            if (input == null)
                return 0;

            int elevatorFloor = 0;
            foreach (string command in input)
            {
                if (command == "NER")
                {
                    elevatorFloor--;
                }
                else if (command == "UPP")
                    elevatorFloor++;
            }
            return elevatorFloor;
        }

        public int ElevatorGoUpAndDown_Linq(string[] input)
        {
            if (input == null)
                return 0;

            //return input.Count(x => x == "UPP") - input.Count(x => x == "NER");

            return input.Sum(X => X == "UPP" ? 1 : X == "NER" ? -1 : 0);
        }
    }
}

