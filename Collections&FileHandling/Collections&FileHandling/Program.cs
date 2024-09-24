using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_FileHandling
{
    internal class Program
    {
        private int[] originalArray;

        static void Main(string[] args)
        {
            Program program = new Program();

            // Array Collection
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[2]);

            Console.WriteLine("1D Array Elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Find Minimum and Maximum
            program.RunFindMinAndMax();

            // Reversing Array
            program.RunReversingArray();

            //ArrayLists VS LinkedLists
            List<int> arrayList = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(i);
                linkedList.AddLast(i);
            }

            long startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            int elementAL = arrayList[500000];
            long endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long durationAL = endTime - startTime;

            startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            int elementLL = linkedList.ElementAt(500000);
            endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long durationLL = endTime - startTime;

            Console.WriteLine("Element retrieved from ArrayList: " + elementAL);
            Console.WriteLine("Element retrieved from LinkedList: " + elementLL);
            Console.WriteLine($"Time taken by ArrayList: {durationAL} miliseconds");
            Console.WriteLine($"Time taken by LinkedList: {durationLL} miliseconds");

            // Dictionaries
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
            ageDictionary["John"] = 25;
            ageDictionary["Alice"] = 30;
            ageDictionary["Bob"] = 22;

            Console.WriteLine($"John's age: {ageDictionary["John"]}");
            Console.WriteLine($"Alice's age: {ageDictionary["Alice"]}");
            Console.WriteLine($"Bob's age: {ageDictionary["Bob"]}");

            string searchName = "Alice";

            if (ageDictionary.ContainsKey(searchName)) Console.WriteLine($"{searchName} exists in the dictionary with age {ageDictionary[searchName]}.");
            else Console.WriteLine($"{searchName} does not exist in the dictionary.");

            // Dictionary Value Existence Check
            Dictionary<string, string> employeeRecords = new Dictionary<string, string>();
            Console.WriteLine("Enter employee records. Enter 'exit' to stop.");

            while (true)
            {
                Console.Write("Enter employee ID: ");
                string employeeID = Console.ReadLine();

                if (employeeID.ToLower() == "exit") break;

                Console.Write("Enter employee name: ");
                string employeeName = Console.ReadLine();

                employeeRecords[employeeID] = employeeName;
            }
            Console.WriteLine("Enter an employee name to check in the records: ");
            string employeeNameToCheck = Console.ReadLine();

            bool employeeExists = false;
            foreach (var record in employeeRecords)
            {
                if (record.Value == employeeNameToCheck)
                {
                    employeeExists = true;
                    break;
                }
            }
            if (employeeExists) Console.WriteLine($"The employee '{employeeNameToCheck}' exists in the records.");
            else Console.WriteLine($"The employee '{employeeNameToCheck}' does not exist in the records.");

            // Hot Potato Game Simulation
            program.RunHotPotatoGame();

            // Guess the number
            program.RunGuessTheNumber();
        }

        #region Find Minimum and Maximum
        public int FindMin(int[] array)
        {
            int min = array[0];
            foreach (int num in array)
            {
                if (num < min) min = num;
            }
            return min;
        }

        public int FindMax(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max) max = num;
            }
            return max;
        }

        public void RunFindMinAndMax()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = FindMin(arr);
            int max = FindMax(arr);

            Console.WriteLine($"Minimum number in the array: {min}");
            Console.WriteLine($"Maximum number in the array: {max}");
        }
        #endregion

        #region Reversing Array
        private void ReverseArray()
        {
            int start = 0;
            int end = originalArray.Length - 1;

            while ( start < end )
            {
                int temp = originalArray[start];
                originalArray[start] = originalArray[end];
                originalArray [end] = temp;

                start++;
                end--;
            }
        }

        private void PrintArray(int[] arr)
        {
            foreach(var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void RunReversingArray()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            originalArray = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0;i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine()) ;
            }

            Console.WriteLine("\nOriginal Array:");
            PrintArray(originalArray);

            ReverseArray();

            Console.WriteLine("\nReversed Array:");
            PrintArray(originalArray);
        }
        #endregion

        #region Hot Potato Game Simulation
        private void PlayHotPotatoGame(int numberOfPlayers, int eliminationInterval)
        {
            Queue<string> playersQueue = new Queue<string>();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                playersQueue.Enqueue($"Player {i}");
            }

            Stack<string> eliminatedPlayers = new Stack<string>();
            while (playersQueue.Count > 1)
            {
                for (int i = 1; i <= eliminationInterval; i++)
                {
                    string currentPlayer = playersQueue.Dequeue();
                    playersQueue.Enqueue(currentPlayer);
                }

                string eliminatedPlayer = playersQueue.Dequeue();
                eliminatedPlayers.Push(eliminatedPlayer);
                Console.WriteLine($"{eliminatedPlayer} is eliminated!");
            }

            string winner = playersQueue.Dequeue();
            Console.WriteLine($"The winner is {winner}!");

            Console.WriteLine("\nOrder of elimination:");
            while(eliminatedPlayers.Count > 0)
            {
                Console.WriteLine(eliminatedPlayers.Pop());
            }
        }

        private void RunHotPotatoGame()
        {
            Console.Write("Enter the number of players: ");
            int numberOfPlayers = int.Parse(Console.ReadLine());

            Console.Write("Enter the elimination interval (e.g., every 3rd player): ");
            int eliminationInterval = int.Parse(Console.ReadLine());

            PlayHotPotatoGame(numberOfPlayers, eliminationInterval);
        }
        #endregion

        #region Guess the number
        private void PlayGuessTheNumber(int number)
        {
            Stack<int> attemps = new Stack<int>();
            int attemp;

            do
            {
                Console.Write("Your guess: ");
                attemp = int.Parse(Console.ReadLine());
                attemps.Push(attemp);

                if (attemp < number) Console.WriteLine("The guess is too Low");
                if (attemp > number) Console.WriteLine("The guess is too High");

            } while (attemp != number);

            Console.WriteLine($"Congratulations! You win after {attemps.Count} attemps");
        }

        private void RunGuessTheNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);

            Console.WriteLine("Hello! Welcome to the 'Guess the number' game.");
            Console.WriteLine("Take your guess and read the tips, they may help you.");
            Console.WriteLine("The player with the fewest attempts wins!");

            Console.WriteLine(number);

            PlayGuessTheNumber(number);
            
        }
        #endregion
    }
}
