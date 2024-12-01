class Q2{
    public void Question_2()
    {
        Console.WriteLine("Enter the value of n:");
        int n = int.Parse(Console.ReadLine());

        double sum = 0.0;

        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i; // Calculate the sum
        }

        Console.WriteLine("Sum of the Harmonic Series: " + sum);
    }
}
