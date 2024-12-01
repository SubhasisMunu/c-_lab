class Q4{
    public void Question_4(){
    // Input: Number of terms
        Console.Write("Enter the number of terms (n): ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0; // To store the sum of square natural numbers

        Console.WriteLine("The square natural numbers are:");
        for (int i = 1; i <= n; i++)
        {
            int square = i * i;
            Console.Write(square + " ");
            sum += square;
        }

        Console.WriteLine(); // Newline for better output formatting
        Console.WriteLine("The sum of square natural numbers is: " + sum);
}
}