class Q13
{
    public void Question_13()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine(number + " is even.");
        }
        else
        {
            Console.WriteLine(number + " is odd.");
        }
    }

    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
}
