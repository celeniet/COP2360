using System;


public class Panda
{
    int age;
    string name;                   
    string gender;
   
    public string panName(string n)       
    {
        name = n;
        return name;                  
    }
    public int panAge(int a)
    {
         age = a;
        return age;
    }
    public string panGen(string g)
    {
        gender = g;
        return gender;
    }    
}


public class Program
{
    
    public static void Main()
    {
        string n;
        int a;
        string inputAge;
        string g;

      // calls the constructor
        Panda p = new Panda (); 
        
        Console.Write("Enter the name of the Panda: ");
        
        n = Console.ReadLine();
        
        // accepting an input as an int
        
        Console.Write("What is the age of the Panda: ");
        
        inputAge = Console.ReadLine();
        a = Convert.ToInt32(inputAge);
        
        Console.Write("What is the Panda gender: ");
        
        g = Console.ReadLine();
      
        Console.Write("The panda's name is {0}, the gender of the panda is {1}, and the age is {2}", p.panName(n), p.panGen(g), p.panAge(a));
    }
}
