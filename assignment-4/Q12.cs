class Q12
{
    public void Question_12()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double area = CalculateArea(radius);

        Console.WriteLine("The area of the circle is: " + area);
    }

    static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}
