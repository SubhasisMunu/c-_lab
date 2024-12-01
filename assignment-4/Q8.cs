class Q8{
    public void Question_8(){
         // Define an array
        int[] numbers = { 5, 10, 15, 20, 25 };

        int sum = 0; // Initialize sum to 0

        // Calculate sum using foreach loop
        foreach (int number in numbers)
        {
            sum += number; // Add each element to sum
        }

        // Display the sum
        Console.WriteLine("The sum of the array elements is: " + sum);
    }
}