namespace Programapplicationsomething
{
    public class Program
    {

        static void QueueTest()
        {
            var queue = new Queue<string>();

            Console.Write("How many names will be added? ");
            var numNames = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numNames; i++)
            {
                Console.Write($"Write name number {i + 1}");
                queue.Enqueue(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"\nThe first name in the queue is {queue.Peek()}");
            Console.WriteLine();
            Console.WriteLine($"This name is now being removed: {queue.Dequeue()}");
            foreach (var name in queue)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
            Console.WriteLine("\nCheck if name (or character) is in the queue: ");
            var isInQueue = queue.Contains(Console.ReadLine());
            Console.WriteLine(isInQueue ? "It is in the queue!" : "It is not in the queue... :(");
        }

        static void StackTest()
        {

            var stack = new Stack<string>();
            Console.WriteLine("How many names will be added? ");
            var numNames = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numNames; i++)
            {
                Console.WriteLine($"Write name #{i + 1}");
                stack.Push(Console.ReadLine());
            }
            Console.WriteLine($"The top name in the stack is {stack.Peek()}.");
            Console.WriteLine($"We remove the top name in the stack, {stack.Pop()}.");
            foreach (var name in stack)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

        }
        static void HashSetTest()
        {
            var hashset = new HashSet<String>();
            Console.WriteLine("How many names will be added? ");
            var numNames = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numNames; i++)
            {
                Console.WriteLine($"Write name #{i + 1}");
                hashset.Add(Console.ReadLine());
            }
            Console.WriteLine("Check for a name in the hashset: ");
            var IsItemInHashset = hashset.Contains(Console.ReadLine());
            Console.WriteLine(IsItemInHashset ? "It is in the hashet!" : "It is not in the hashet : (");
            Console.WriteLine($"There is #{hashset.Count} items in the hashset");
        }

        static void DictionaryTest()
        {
            var dict = new Dictionary<string, int>();
            dict.Add("windows users", -100);
            dict.Add("vim enjoyers", 1000000);
            dict.Add("i use arch btw", int.MaxValue);
            foreach (var key in dict.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("Look up a key: ");
            var keyToLookup = Console.ReadLine().ToLower();

            if (!dict.Keys.Contains(keyToLookup))
            { 
                Console.WriteLine("You looked up something that isn't in the dictionary : (");
                return;
            }
            else
            {
                Console.WriteLine($"The value of the key is: {dict[keyToLookup]}");
            }
        }

        static void SortedListTest()
        {
            var SortedList = new SortedList<int, string>();
            SortedList.Add(3, "Liisa");
            SortedList.Add(1, "Alisha");
            SortedList.Add(2, "Gwen");
            SortedList.Add(4, "Mona");
            SortedList.Add(10, "Hedvig");
            SortedList.Add(5, "Lillemor");

            foreach (int key in SortedList.Keys)
            {
                Console.WriteLine($"key: {key}, name: {SortedList[key]}");
            }
            //Console.WriteLine("\nOrdering Sorted List...\n");

            //SortedList.OrderBy(x => x.Key);
        }

        static void Main()
        {

            //använde var istället för Queue<string>, inte java lmao
            //Queue<string>() random_queue = new Queue<string>(); < -java syntax bad

            Console.WriteLine("What do you want to run? \nQueue, stack, hashset, dictionary or a sorted list? ");
            var answer = Console.ReadLine().ToLower();

            switch (answer) 
            {
                case "stack":
                    StackTest();
                    break;
                case "queue":
                    QueueTest();
                    break;
                case "hashet":
                    HashSetTest();
                    break;
                case "dictionary":
                    DictionaryTest();
                    break;
                default:
                    SortedListTest();
                    break;
            }
         
        }
    }
}
