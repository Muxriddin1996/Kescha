using System;
/*System.Console.Write("Enter the radius of the circle ...");
int radiusOfCircle=Convert.ToInt32(Console.ReadLine());
double faceOfCircle=Math.PI*Math.Pow(radiusOfCircle,2);
double lengthOfCircumference=2*Math.PI*radiusOfCircle; 
System.Console.WriteLine("Circle face equal "+faceOfCircle);
System.Console.WriteLine("Circumference length equal "+lengthOfCircumference);



System.Console.Write("Enter value ...");
double valueOfCarrency=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter exchange rate ...");
int rateOfExchange=Convert.ToInt32(Console.ReadLine());
double convertToCarrency=valueOfCarrency*rateOfExchange;
System.Console.WriteLine("Convert to carrency "+convertToCarrency+" sum");

System.Console.Write("Enter person's year of birth ...");
int yearOfBirth=Convert.ToInt32(Console.ReadLine());
int yearOfNow=2023;
int ageOfPerson=yearOfNow-yearOfBirth;
int ageOfPersonByDay=ageOfPerson*365;
System.Console.WriteLine("Person's age by day  "+ageOfPersonByDay+"  day");


     //--------------------------------------------------------------------------------//


    Console.Write("Enter first number ... ");
    int firstNumber= Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number ... ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.Write("Your option? ");

    switch (Console.ReadLine())
    {
        case "a":
            Console.WriteLine($"Your result: {firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
            break;
        case "s":
            Console.WriteLine($"Your result: {firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
            break;
        case "m":
            Console.WriteLine($"Your result: {firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
            break;
        case "d":
            Console.WriteLine($"Your result: {firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
            break;
    }
    Console.Write("Press any key to close the Calculator console app...");
     
    int s=0;
    Console.Write("Enter  number ... ");
    int number= Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i <=number; i++)
    {
        s=s+i;
         
    }  System.Console.WriteLine("Sum of numbers up to number  "+s); 

    //--------------------------------------------------------------------------//


    Console.Write("Enter  number ... ");
    int numberOfOne= Convert.ToInt32(Console.ReadLine());
    if (number%2==0)
    {
        System.Console.WriteLine("This number is an even number");
    }
    else System.Console.WriteLine("This number is an odd number");


  Console.WriteLine("Enter the text");
string str=Console.ReadLine();
Console.WriteLine("Enter the number");
int numberOfTwo=Convert.ToInt32(Console.ReadLine());
int numberOfStr=str.Length;
if(number>numberOfStr)
{
    System.Console.WriteLine(str.ToUpper());
}
else  System.Console.WriteLine(str.ToLower());

int numberOfFirst=15;
int numberOfSecond=10;
if(numberOfFirst>numberOfSecond)
{
    System.Console.WriteLine( "x is greater than y");
}
else if(numberOfFirst<numberOfSecond)
{
   System.Console.WriteLine("x is less than y");
}
else if(numberOfFirst==numberOfSecond)
{
  System.Console.WriteLine("x is equal to y");
}
else System.Console.WriteLine("x and y are not comparable");

System.Console.WriteLine("Enter the days of week");

string   daysOfWeek=Console.ReadLine();
switch(daysOfWeek)
{
  case "Dushanba":
  System.Console.WriteLine("Monday");
  break;
  case "Seshanba":
  System.Console.WriteLine("Tuesday");
  break;
  case "Chorshanba":
  System.Console.WriteLine("Wednesday");
  break;
  case "Payshanba":
  System.Console.WriteLine("Thursday");
  break;
  case "Juma":
  System.Console.WriteLine("Friday");
  break;
  case "Shanba":
  System.Console.WriteLine("Saturday");
  break;
  case "Yakshanba":
  System.Console.WriteLine("Sunday");
  break;
} 


//-----------------------------------------------------------------//
System.Console.WriteLine("Enter minute ..");
int numberOfMinute=Convert.ToInt32(Console.ReadLine());
int numberOfWatch=numberOfMinute/60;
int numberOfResidualMinute=numberOfMinute-numberOfWatch*60;
System.Console.WriteLine(numberOfWatch +":"+ numberOfResidualMinute);

System.Console.WriteLine("Enter your age");
int age=Convert.ToInt32(Console.ReadLine());
if( age>0 && age<=12 ) 
{
    System.Console.WriteLine("Child");
}
else if(age>=13 && age<=19 )
{
    System.Console.WriteLine("Teenager");
}
else if(age>=20 && age<=59 )
{
   System.Console.WriteLine("Adults");
}
else if(age>=60)
{
  System.Console.WriteLine("Adult");
} 

System.Console.WriteLine("Enter the ball of Mathematics");
int numberOfMath=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the ball of History");
int numberOfHistory=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the ball of Physics");
int numberOfPhysics=Convert.ToInt32(Console.ReadLine());
int averangeOfBalls=(numberOfMath+numberOfHistory+numberOfPhysics)/3;
string message=
       averangeOfBalls>=0 && averangeOfBalls<=40
       ? "Unsatisfactory" 
       : averangeOfBalls>=41 && averangeOfBalls<=59 
       ? "Satisfactory"
       : averangeOfBalls>=60 && averangeOfBalls<=79 
       ? "Best"
       : averangeOfBalls>=80 && averangeOfBalls<=100
       ? "Great" 
       :  "bunaqa son yuq";

       System.Console.WriteLine(message);

 System.Console.WriteLine("Enter the number");
 int numberOfYour=Convert.ToInt32(Console.ReadLine());
 Random rnd=new Random();
 
 for(int i=0;i<1;i++)     
 {
    string messageBox=
       numberOfYour>rnd.Next(0, 100)
       ? "The secret number is small"
       : "The secret number is large";
       System.Console.WriteLine(messageBox);
     } 
*/
//--------------------------------------------------------------------//


/*string palindrom=Console.ReadLine();
int lengthOfPalindrom=palindrom.Length;
string reverseOfPalindrom="";
for(int i=lengthOfPalindrom-1;i>=0;i--)
{
  reverseOfPalindrom=reverseOfPalindrom+palindrom[i].ToString();
}
if(palindrom==reverseOfPalindrom)
{
  System.Console.WriteLine("Entered string is Palindrome");
}
else 
{
  System.Console.WriteLine("Entered string is not Palindrome");
}

int gradusOfSelcium=Convert.ToInt32(Console.ReadLine());
switch(gradusOfSelcium)
{

}   
 internal class Program
{
    private static void Main(string[] args)
    {
        string choice;
        double temperature;

        double result;

        Console.WriteLine("Enter F to convert to Fahrenheit or C to convert to Celsius:");
        choice = Console.ReadLine();
     
        switch (choice)
        {
            case "C":
            case "c":
                temperature = GetTemperature("Fahrenheit");
                result = CalculateCelsius(temperature);
                DisplayResult(temperature, "Fahrenheit", result, "Celsius");
                break;
            case "F":
            case "f":
                temperature = GetTemperature("Celsius");
                result = CalculateFahrenheit(temperature);
                DisplayResult(temperature, "Celsius", result, "Fahrenheit");
                break;
            default:
                Console.WriteLine("You must enter C to convert to Celsius or F to convert to Fahrenheit!");
                break;
           }
        }
        private static double GetTemperature(string label)
        {
            string input;
            double temperature;

            Console.WriteLine("Enter " + label + " temperature:");
            input = Console.ReadLine();
            temperature = Convert.ToDouble(input);

            return temperature;
        }

        private static double CalculateCelsius(double fahrenheit)
        {
            double celsius;

            celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }

        private static double CalculateFahrenheit(double celsius)
        {
            double fahrenheit;

            fahrenheit = celsius * 9 / 5 + 32;

            return fahrenheit;
        }

        private static void DisplayResult(double fahrenheit, string fromLabel, double celsius, string toLabel)
        {
            Console.WriteLine(fahrenheit.ToString() + "° " + fromLabel + " is " + celsius.ToString() + "° " + toLabel);
        }
    }   

       List<int> numbers = new List<int>{ 9, 4, 7, 2, 5 };
        numbers.Sort();  // Sort the list in an ascending order

        Console.WriteLine("Sorted numbers:");
        for (int i = 0; i < numbers.Count; i++)
        {
            int number = numbers[i];
            Console.WriteLine(number);
        }  */ 
         