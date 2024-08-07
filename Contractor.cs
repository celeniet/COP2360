using System;

class Program
{
    static void Main()
    {
        string name;
        int number;
        string startDate;
        int shift;
        double payRate;
        float hoursWorked;

        Console.WriteLine("Enter Contractor Name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter Contractor Number:");
        number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Contractor Start Date (YYYY-MM-DD):");
        startDate = Console.ReadLine();

        Console.WriteLine("Enter Shift (1 for day, 2 for night):");
        shift = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Hourly Pay Rate:");
        payRate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Hours Worked:");
        hoursWorked = float.Parse(Console.ReadLine());

        Subcontractor sub = new Subcontractor(name, number, startDate, shift, payRate);
        float totalPay = sub.ComputePay(hoursWorked);

        Console.WriteLine($"Total Pay for {sub.GetName()} is ${totalPay}");

    }
}

-----------------------------------------------------------------------------------------

  using System;

public class Contractor
{

    private string contractorName;
    private int contractorNumber;
    private string contractorStartDate;

    public Contractor()
    {
        contractorName = "";
        contractorNumber = 0;
        contractorStartDate = "";
    }

    public Contractor(string name, int number, string startDate)
    {
        contractorName = name;
        contractorNumber = number;
        contractorStartDate = startDate;
    }


    public string GetName()
    {
        return contractorName;
    }

    public int GetNumber()
    {
        return contractorNumber;
    }

    public string GetStartDate()
    {
        return contractorStartDate;
    }

    public void SetName(string name)
    {
        contractorName = name;
    }

    public void SetNumber(int number)
    {
        contractorNumber = number;
    }

    public void SetStartDate(string startDate)
    {
        contractorStartDate = startDate;
    }
}
-----------------------------------------------------------------------------
  public class Subcontractor : Contractor
{
    private int shift;  // 1 for day shift, 2 for night shift
    private double hourlyPayRate;


    public Subcontractor() : base()
    {
        shift = 1; // Default to day shift
        hourlyPayRate = 0.0;
    }

    public Subcontractor(string name, int number, string startDate, int shift, double payRate)
        : base(name, number, startDate)
    {
        this.shift = shift;
        hourlyPayRate = payRate;
    }


    public int GetShift()
    {
        return shift;
    }

    public double GetHourlyPayRate()
    {
        return hourlyPayRate;
    }


    public float ComputePay(float hoursWorked)
    {
        double basePay = hoursWorked * hourlyPayRate;
        if (shift == 2) // Night shift
        {
            basePay *= 1.03; // 3% shift differential
        }
        return (float)basePay;
    }
}
