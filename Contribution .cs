using System;
using System.Collections.Generic;

public class ExampleCode
{
    public static void Main(string[] args)
    {
        // Example 1: Basic console output and input
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");

        // Example 2: Looping through a list
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Example 3: Conditional statement
        int age = 25;
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }

        // Example 4: A simple method
        int sum = Add(10, 20);
        Console.WriteLine($"The sum is: {sum}");

        //Example 5: Working with Classes.
        Person myPerson = new Person("Alice", 30);
        myPerson.Introduce();

        //Example 6: Using a dictionary.
        Dictionary<string, string> capitals = new Dictionary<string, string>();
        capitals.Add("USA", "Washington D.C.");
        capitals.Add("France", "Paris");
        capitals.Add("Japan", "Tokyo");

        if(capitals.ContainsKey("USA")){
            Console.WriteLine($"The capital of USA is {capitals["USA"]}");
        }

        //Example 7: Try-Catch block.
        try{
            int result = 10/0; //This will cause a divide by zero exception.
        }
        catch(DivideByZeroException ex){
            Console.WriteLine("An error occurred: " + ex.Message);
        }

    }

    // Example 4: Simple method
    public static int Add(int a, int b)
    {
        return a + b;
    }

    //Example 5: Simple class.
    public class Person{
        public string Name {get; set;}
        public int Age {get; set;}

        public Person(string name, int age){
            Name = name;
            Age = age;
        }

        public void Introduce(){
            Console.WriteLine($"My name is {Name} and I am {Age} years old.");
        }
    }
}
