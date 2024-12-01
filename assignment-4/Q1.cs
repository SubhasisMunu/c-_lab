class Q1
{
    public void Question_1()
    {
        Console.WriteLine("Enter the length of the first side:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the second side:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Dynamically initialize the hypotenuse variable
        double hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2));

        Console.WriteLine($"The hypotenuse of the triangle is: {hypotenuse}");
    }
}