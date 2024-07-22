using System; 

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter the first value:");

    string input1 = Console.ReadLine();

    Console.WriteLine("Enter the second value:");

    string input2 = Console.ReadLine();

    PerformDivision(input1, input2);
  }
  static void PerformDivision(string strNum1, string strNum2)
  {
    try
    {
      int num1 = Convert.ToInt32(strNum1);
      int num2 = Convert.ToInt32(strNum2);

      int result = num1 / num2;
      Console.WriteLine($"The results of dividing {num1} by {num2} is {result}.");
    }
    catch (FormatException ex)
    {
      Console.WriteLine($"Error: One or both of the inputs are not valid integers. Details: {ex.Message}");
    }
    catch (DivideByZeroException ex)
    {
      Console.WriteLine($"Error: Division by zero is not allowed. Details: {ex.Message}");
    }
    catch (OverflowException ex)
    {
      Console.WriteLine($"Error: One or both of the inputs are too large or too small for an Int32. Details: {ex.Message}");
    } 
    catch (Exception ex)
    {
      Console.WriteLine($"An unexpected error occurred. Details: {ex.Message}");
    }
  }
}

//  without the catch

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter the first value:");

    string input1 = Console.ReadLine();

    Console.WriteLine("Enter the second value:");

    string input2 = Console.ReadLine();

    PerformDivision(input1, input2);
  }

    static void PerformDivision(string strNum1, string strNum2)
  {
      int num1 = Convert.ToInt32(strNum1);
      int num2 = Convert.ToInt32(strNum2);

      int result = num1 / num2;
      Console.WriteLine($"The result of dividing {num1} by {num2} is {result}.");
  }
}
  
