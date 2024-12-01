class Q3{
    public void Question_3()
    {
        // Input: Base value x and series limit n
        Console.Write("Enter the value of x: ");
        int x = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        // Initialize sum to the first term
        int sum = 1;

        // Calculate the sum of the series
        for (int i = 2; i <= n; i++)
        {
            sum += (int)Math.Pow(x, i);
        }

        // Display the result
        Console.WriteLine("The sum of the series 1 + x^2 + x^3 + ... + x^n is: " + sum);
    
    }
}
