class Q11{
    public void Question_11(){
        // Define an array
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Calculate sum using for loop
        int sumUsingFor = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sumUsingFor += numbers[i];
        }
        Console.WriteLine("Sum of array elements using for loop: " + sumUsingFor);

        // Calculate sum using foreach loop
        int sumUsingForEach = 0;
        foreach (int num in numbers)
        {
            sumUsingForEach += num;
        }
        Console.WriteLine("Sum of array elements using foreach loop: " + sumUsingForEach);
    }
}
