class ConsoleApp2
{
    public static void Main()
    {
        int class_1, class_2, class_3, buses, total_students;
        Console.WriteLine("Enter the number of students in class #1: ");
        class_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of students in class #2: ");
        class_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of students in class #3: ");
        class_3 = int.Parse(Console.ReadLine());
        total_students = class_1 + class_2 + class_3;
        if (total_students % 40 == 0)
            buses = total_students / 40;
        else
            buses = total_students / 40 + 1;
        Console.WriteLine("Your total busses is {0}!", buses);
    }
}