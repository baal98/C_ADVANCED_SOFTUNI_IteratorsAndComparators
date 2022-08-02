using System;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Skip(1).ToList();

            string command;

            ListyIterator<string> listyIterator = new ListyIterator<string>(inputs);

            try
            {
                while ((command = Console.ReadLine()) != "END")
                {
                    if (command == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (command == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (command == "PrintAll")
                    {
                        Console.WriteLine(String.Join(" ", listyIterator));
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
