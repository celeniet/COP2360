using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        DictManager manager = new DictManager();
        
        bool running = true;
        
        while(running)
        {
            Console.WriteLine("\nChoose an option");
            Console.WriteLine("A. Populate the Dictionary.");
            Console.WriteLine("B. Display the information.");
            Console.WriteLine("C. Remove a key.");
            Console.WriteLine("D. Add a new Key and value.");
            Console.WriteLine("E. Add a value to an existing key.");
            Console.WriteLine("F. Sort the keys.");
            Console.WriteLine("Z. to quit.");
            Console.WriteLine("Enter your given choice: ");
            
            string choice = Console.ReadLine();
            
            switch(choice)
            {
                case "A":
                manager.PopulateDictionary();
                break;
                
                case "B":
                manager.DisplayDictionary();
                break;
                
                case "C":
                manager.RemoveKey();
                break;
                
                case "D":
                manager.AddNewKeyValue();
                break;
                
                case "E":
                manager.AddValueToExistingKey();
                break;
                
                case "F":
                manager.SortKeys();
                break;
                
                case "Z":
                running = false;
                Console.WriteLine("Goodbye.");
                break;
                
                default:
                Console.WriteLine("Invalid Choice. Please select again.");
                break;
            }
        }
    }
}
------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public class DictManager
{
    private Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

    //Adds A key and value to Dictionary
    public void PopulateDictionary()
    {
        Console.WriteLine("Enter key:");
        string key = Console.ReadLine();
        Console.WriteLine("Enter value (comma separated):");
        string[] values = Console.ReadLine().Split(',');
        myDictionary[key] = new List<string>(values);
        Console.WriteLine($"Key '{key}' with values [{string.Join(", ", values)}] added.");
    }
    //Calls to display Dictionary
    public void DisplayDictionary()
    {
        Console.WriteLine("Dictionary Contents:");
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
        }
    }
    // Removes a key from the Dictionary, unless there isn't one
    public void RemoveKey()
    {
        Console.WriteLine("Enter key to remove:");
        string keyToRemove = Console.ReadLine();
        if (myDictionary.Remove(keyToRemove))
        {
            Console.WriteLine($"Key '{keyToRemove}' removed.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToRemove}' not found.");
        }
    }

    //Adds a new key value to the existing Dictionary
    public void AddNewKeyValue()
    {
        Console.WriteLine("Enter new key:");
        string newKey = Console.ReadLine();
        Console.WriteLine("Enter value (comma separated):");
        string[] newValues = Console.ReadLine().Split(',');
        myDictionary[newKey] = new List<string>(newValues);
        Console.WriteLine($"New key '{newKey}' with values [{string.Join(", ", newValues)}] added.");
    }
    
    // Adds a a new value to an Existing key.
    public void AddValueToExistingKey()
    {
        Console.WriteLine("Enter key to add value to:");
        string keyToAddValue = Console.ReadLine();
        if (myDictionary.ContainsKey(keyToAddValue))
        {
            Console.WriteLine("Enter value to add:");
            string valueToAdd = Console.ReadLine();
            myDictionary[keyToAddValue].Add(valueToAdd);
            Console.WriteLine($"Value '{valueToAdd}' added to key '{keyToAddValue}'.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToAddValue}' not found.");
        }
    }
    // Sorts the keys within the dictionary.
    public void SortKeys()
    {
        Console.WriteLine("Sorted Keys:");
        foreach (var keyInOrder in new SortedSet<string>(myDictionary.Keys))
        {
            Console.WriteLine(keyInOrder);
        }
    }
}
