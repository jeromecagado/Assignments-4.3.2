namespace Assignments_4._3._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Prompt();
            CalculateFrequency(myArray);
        }

        static int[] Prompt()
        {
            uint numElements;
            Console.Write("Input the number of elements to be stored in the array: ");
            while (!uint.TryParse(Console.ReadLine(), out numElements)) 
            {
                Console.WriteLine("Incorrect input, must be a number.");
            }
            int[] myArray = new int [(int)numElements];

            Console.WriteLine($"Input {numElements} elements in the array.");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"element - {i}: ");
                while(!int.TryParse(Console.ReadLine(), out myArray[i]))
                {
                    Console.WriteLine("Incorrect input, must enter a number");
                }
            }
            return myArray;
        }

        static void CalculateFrequency(int[] myArray)
        {
            Dictionary<int, int> countMap = new();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (countMap.ContainsKey(myArray[i]))
                {
                    countMap[myArray[i]]++;
                }
                else
                {
                    countMap[myArray[i]] = 1;
                }
            }

            DisplayMapValues(countMap);
        }

        static void DisplayMapValues(Dictionary<int, int> mapValues)
        {
            Console.WriteLine("Frequency of all elements of array:");
            foreach(KeyValuePair<int, int> entry in mapValues)
            {
                Console.WriteLine($"{entry.Key} occurs {entry.Value} times");
            }
        }
    }
}
