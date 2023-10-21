// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hi! Let's find the area of the rectangle!");
class recarea
{ static void Main()
    { Console.WriteLine("What is the length");
        string lengthInput = Console.ReadLine();
        int length = int.Parse(lengthInput);

        Console.WriteLine("What is the width");
        string widthInput = Console.ReadLine();
        int width = int.Parse(widthInput);
        int area = length * width;
        Console.WriteLine("The area of the rectangle is:" + area);

    }
}
