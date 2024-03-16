System.Console.Write("Enter the radius of the circle ...");
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