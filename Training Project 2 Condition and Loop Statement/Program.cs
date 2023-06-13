using System;

using System.ComponentModel;
using System.Transactions;

class Condition_and_Loop_statement
{
// 1. Program to accept two integers and check whether they are equal or not.
    public void Equalornot()
    {
        Console.Write("Enter the First Number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Second Number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 == num2)
        {
            Console.WriteLine("True, Both Numbers are Equal");
        }
        else
        {
            Console.WriteLine("False, Both Numbers are not Equal");
        }

        Console.ReadKey();
    }

// 2. Program to check whether a given number is positive or negative.
    public void Positivenegative()
    {
        Console.Write("Enter the Number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 >= 0)
        {
            Console.WriteLine("It is a Positive Number");
        }
        else
        {
            Console.WriteLine("It is a Negative Number");
        }

        Console.ReadKey();
    }

// 3. program to find out whether a given year is a leap year or not.
    public void Leapyear()
    {
        Console.Write("Enter the Year : ");
        int Year = Convert.ToInt32(Console.ReadLine());

        if (Year % 4 == 0)
        {
            Console.WriteLine("It is a Leap Year");
        }
        else
        {
            Console.WriteLine("It is a not a Leap Year");
        }

        Console.ReadKey();
    }

// 4. Read the age of a candidate and determine whether it is eligible for casting his/her own vote.
    public void Eligileforcasting()
    {
        Console.Write("Enter the Name : ");
        string Name = Console.ReadLine();

        Console.Write("Enter the Age : ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are Eligible for Casting");
        }
        else
        {
            Console.WriteLine("You are not Eligible for Casting");
        }

        Console.ReadKey();
    }

// 5. Program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
    public void Displaythevalue()
    {
        Console.Write("Give the Value of m : ");
        int m = Convert.ToInt32(Console.ReadLine());
        int n;

        if (m > 0)
        {
            n = 1;
            Console.WriteLine("Value of n is : {0}",n);
        }
        else if(m == 0)
        {
            n = 0;
            Console.WriteLine("Value of n is : {0}", n);
        }
        else
        {
            n = -1;
            Console.WriteLine("Value of n is : {0}", n);
        }

        Console.ReadKey();
    }

// 6. Display the first 10 natural numbers.
    public void naturalnumbers()
    {
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }

// 7. Program that displays the sum of first 10 natural numbers.
    public void sumoftennumbers()
    {
        int sum = 0;

        Console.Write("The Sum of First 10 Natural Number is : ");
        for (int i = 1; i <= 10; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);

        Console.ReadKey();
    }

// 8. Program that displays the sum of n natural numbers.
    public void sumofnumbers()
    {
        Console.Write("Give the Number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        Console.Write("The Sum of n Natural Number is : ");
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);

        Console.ReadKey();
    }

// 9. Program to read 10 numbers and find their average and sum.
    public void Averageandsum()
    {
        int sum = 0;
        int average = 0;

        for (int i = 1; i <= 10; i++)
        {
            sum = sum + i;
            average = sum/i;
        }
        Console.Write("The Sum of 10 Number is : ");
        Console.WriteLine(sum);

        Console.Write("The Average of 10 Number is : ");
        Console.WriteLine(average);

        Console.ReadKey();
    }

// 10. Program to display the cube of an integer up to given number.
    public void Cubethenumber()
    {
        Console.Write("Give the number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Cube Of the Number Upto Given is : ");
        for (int i = 1; i <= n; i++)
        {
           int sum = i*i*i;

           Console.Write(sum + " ");
        }

        Console.ReadKey();
    }

// 11. Display the multiplication table of a given integer.
    public void Multipletable()
    {
        Console.Write("Give the number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} X {1} = {2}", n, i, n * i);
        }

        Console.ReadKey();
    }

// 12. Display the multiplication table vertically from 1 to n.
    public void Multipletablevert()
    {
        Console.Write("Give the number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j<=n ; j++)
            {
                Console.Write("{0} X {1} = {2}           ", i, j, i * j);
            }
            Console.WriteLine();

        }

        Console.ReadKey();
    }

// 13. Program to display the n terms of odd natural numbers and their sums.
    public void Oddnaturalnumber()
    {
        Console.Write("Give the Number : ");
        int n=Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int odd;

        Console.Write("The Odd Numbers is : ");
        for(int i=1; i<=n; i++)
        {
            odd = 2 * i - 1;
            Console.Write(odd + " ");

            sum = sum + odd;
        }
        Console.WriteLine() ;
        Console.Write("Sum Of Odd Numbers : ") ;
        Console.WriteLine(sum);

        Console.ReadKey();
    }

// 14. Display a right angle triangle with an asterisk The pattern
    public void Asteriskpattern()
    {
        Console.Write("Give the Input : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i=1; i<=n; i++)
        {
            for(int j=1; j<=i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }

// 15. Display a pattern like a right angle triangle with a number The pattern
    public void Numberpattern()
    {
        Console.Write("Give the Input : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

// 16. Pattern like a right angle triangle with a number which repeats a number in a row.
    public void Numberrepeatpattern()
    {

        Console.Write("Give the Input : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i=1; i<=n; i++)
        {
            for(int j=1; j<=i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

// 17. Pattern like a right angle triangle with the number increased by 1
    public void Numberincreasedpattern()
    {
        Console.Write("Give the Input : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int num = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num++ + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

// 18. Sharp program to calculate the factorial of a given number.
    public void Factorial()
    {
        Console.Write("Give the Input : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 1;

        for(int i=1; i<=n; i++)
        {
            sum = sum * i;
        }
        Console.WriteLine("Factorial Of The Give Number is : {0}",sum);

        Console.ReadKey();
    }

// 19. Display the n terms of even natural number and their sum.
    public void Evennaturalnumber()
    {
        Console.Write("Give the Number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int Even;

        Console.Write("The Even Numbers is : ");
        for (int i = 1; i <= n; i++)
        {
            Even = 2 * i;
            Console.Write(Even + " ");

            sum = sum + Even;
        }
        Console.WriteLine();
        Console.Write("Sum Of Even Numbers : ");
        Console.WriteLine(sum);

        Console.ReadKey();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Condition_and_Loop_statement cls = new Condition_and_Loop_statement();

        L: Console.Write("Enter The Program's Number : ");
           int Select = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine();

        switch(Select)
        {
            case 1: cls.Equalornot(); 
                break;

            case 2: cls.Positivenegative();
                break;

            case 3: cls.Leapyear();
                break;

            case 4: cls.Eligileforcasting();
                break;

            case 5:cls.Displaythevalue();
                break;

            case 6:cls.naturalnumbers(); 
                break;

            case 7:
                cls.sumoftennumbers();
                break;

            case 8:cls.sumofnumbers();
                break;

            case 9: cls.Averageandsum();
                break;

            case 10: cls.Cubethenumber();
                break;

            case 11: cls.Multipletable();
                break;

            case 12:
                cls.Multipletablevert();
                break;

            case 13:cls.Oddnaturalnumber();
                break;

            case 14:cls.Asteriskpattern();
                break;

            case 15:cls.Numberpattern();
                break;

            case 16:cls.Numberrepeatpattern();
                break;

            case 17:cls.Numberincreasedpattern();
                break;

            case 18:cls.Factorial();
                break;

            case 19:cls.Evennaturalnumber();
                break;

            default: Console.WriteLine("----INVAILD INPUT----");
                     Console.WriteLine();
                goto L;
        }
    }
}