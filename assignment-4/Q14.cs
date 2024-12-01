class Q14
{
    public void Question_14()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int largest = FindLargest(num1, num2, num3);

        Console.WriteLine("The largest number is: " + largest);
    }

    static int FindLargest(int a, int b, int c)
    {
        if (a > b && a > c)
            return a;
        else if (b > c)
            return b;
        else
            return c;
    }
}
