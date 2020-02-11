using System;

namespace CoffeeCounter
{
  public class CoffeeCounterApp
  {
    public void StartApp()
    {
      int numberOfCupsOfCoffee;
      numberOfCupsOfCoffee = 3;

      var fullName = " Natalie Pagan";

      var today = DateTime.Now.ToString(" MM/dd/yyyy");

      Console.WriteLine(numberOfCupsOfCoffee + fullName + today);

      Console.WriteLine("What is your name?");
      var user = Console.ReadLine();
      if (user == "Alice")
      {
        Console.WriteLine("Hello there, Alice, we've missed you in Wonderland...follow the white rabbit...");
      }
      else
      {
        Console.WriteLine("Hello there, " + user);
      }

      Console.WriteLine(user + ", please enter a number...");
      var firstNumber = Console.ReadLine();
      var operand1 = double.Parse(firstNumber);

      Console.WriteLine("Please enter another number...");
      var secondNumber = Console.ReadLine();
      var operand2 = double.Parse(secondNumber);

      var sum = operand1 + operand2;

      var difference = operand1 - operand2;

      var quotient = operand1 / operand2;

      var product = operand1 * operand2;

      var remainder = operand1 % operand2;

      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Difference: " + difference);
      Console.WriteLine("Quotient: " + quotient);
      Console.WriteLine("Product: " + product);
      Console.WriteLine("Remainder: " + remainder);


    }
  }
}