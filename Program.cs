#region Task1
//Print(16);
//void Print(int num)
//{
//    string CheckOddOrEven(int num)
//    {
//        if (num % 2 == 0)
//        {
//            return "Cutdur";
//        }

//        return "Tekdir";
//    }
//    string result = CheckOddOrEven(num);
//    Console.WriteLine(result);
//}
#endregion

#region Task2

//int a, b;
//Console.WriteLine("Please enter your number: ");
//a = int.Parse(Console.ReadLine());

//for (b = 2; a > 1; b++)
//    if (a % b == 0)
//    {
//        while (a % b == 0)
//        {
//            a /= b;

//        }
//        Console.WriteLine($"{b} is a prime factor");
//    }

#endregion

#region Task3

void Print(double num)
{
    Console.WriteLine(num);
}

double num1 = 5;
double num2 = 6;
double result = Difference(num1, num2);


Print(result);
double Sum(double num1, double num2)
{
    return num1 + num2;
}
double Difference(double num1, double num2)
{
    return num1 - num2;
}
double multiplication (double num1,double num2)
{
    return num1 * num2;
}
double divided (double num1,double num2)
{
    return num1 / num2;
}






#endregion