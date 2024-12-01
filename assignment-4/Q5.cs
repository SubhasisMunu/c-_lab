class Q5{
    public void Question_5(){
          // Input: Number to check
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        // Find divisors and calculate their sum
        for (int i = 1; i < num; i++){
            if (num % i == 0)
            {
                sum += i;
            }
        }
        // Check if the number is perfect
        if (sum == num){
            Console.WriteLine(num + " is a perfect number.");
        }
        else
        {
            Console.WriteLine(num + " is not a perfect number.");
        }
    }
}