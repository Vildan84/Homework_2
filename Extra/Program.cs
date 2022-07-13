void Triangle()
{
    int sideA = 6;
    int sideB = 6;
    int sideC = 15;

    if (sideA == sideB && sideB == sideC)
    {
        Console.WriteLine("Треугольник равносторонний");
    }
    else if (sideA == sideB && sideA + sideB > sideC)
    {
        Console.WriteLine("Равнобедренный треугольник");
    }
    else if (sideA == sideC && sideA + sideC > sideB) 
    {
        Console.WriteLine("Равнобедренный треугольник");
    }
    else if (sideC == sideB && sideC + sideB > sideA) 
    {
        Console.WriteLine("Равнобедренный треугольник");
    }
    else 
    {
        Console.WriteLine("Треугольник не равнобедренный");
    }
}
//Triangle();

void Age()
{
    Console.WriteLine("Enter day: ");
    int day = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter month: ");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter year: ");
    int year = Convert.ToInt32(Console.ReadLine());

    int fixDay = 1;
    int fixMonth = 7;
    int fixYear = 2022;

    int resYear = fixYear - year;

    if (month > fixMonth) Console.WriteLine("Age: " + (resYear -= 1));
    else if (fixMonth == month && day > fixDay) 
    {
        Console.WriteLine("Age: " + (resYear -= 1));
    }
    else Console.WriteLine("Age: " + resYear);     
}
//Age();

void Deposit()
{
    Console.WriteLine("Enter number of monthes: ");
    int month = Convert.ToInt32(Console.ReadLine());
    double summ = 1000;
    double proc = 1.5;
    int count = 0;
    
    while (count < month)
    {
        summ = summ + (summ * (proc / 100));
        count += 1;
        Console.WriteLine(summ);
    }
} 
    
//Deposit();

void MaxMin()
{
    Console.WriteLine("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    

}