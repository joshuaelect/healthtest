// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile hpp1 = new HealthProfile(null, null, 0, 0, 0, 0, 0, null);

        Console.Write("Enter First Name: ");
        hpp1.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Last Name: ");
        hpp1.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Day of Birth: ");
        hpp1.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month of Birth: ");
        hpp1.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Year of Birth: ");
        hpp1.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Weight in pounds: ");
        hpp1.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height in inches: ");
        hpp1.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Gender: ");
        hpp1.Gender = Convert.ToString(Console.ReadLine());



        hpp1.DisplayFirstName();
        hpp1.DisplayLastName();
        hpp1.DisplayDayOfBirth();
        hpp1.DisplayMonthOfBirth();
        hpp1.DisplayYearOfBirth();
        hpp1.DisplayWeightInPounds();
        hpp1.DisplayHeightInInches();
        hpp1.DisplayGender();
        hpp1.DisplayYearsOfAgeSimple();
        hpp1.DisplayMaxHeartRate();
        hpp1.DisplayTargetHeartRate();
        hpp1.DisplayBodyMassIndex();
        hpp1.DisplayBMIOutput();
        hpp1.DisplayBMIChart();
    }
}