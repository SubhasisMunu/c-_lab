class Q9{
    public void Question_9(){
         // Input: Get the string from the user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int length = 0; // Initialize length to 0

        // Calculate string length using foreach loop
        foreach (char c in input){
            length++; // Increment length for each character
        }
        // Display the length
        Console.WriteLine("The length of the string is: " + length);
    }
}