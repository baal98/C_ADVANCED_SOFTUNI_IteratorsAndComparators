using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] inputs = command.Split(' ');

                string name = inputs[0];
                int age = int.Parse(inputs[1]);
                string town = inputs[2];

                Person person = new Person(name, age, town);
                persons.Add(person);
            }
            int searcheIndex = int.Parse(Console.ReadLine());

            int totalPeople = 0;
            int equalPeople = 0;
            int difPeople = 0;
            Person personToCompare = persons[searcheIndex - 1];

            foreach (Person person in persons)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    difPeople++;
                }
                totalPeople++;
            }
            if (equalPeople == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {difPeople} {totalPeople}");
            }
        }
    }
}
