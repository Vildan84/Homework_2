void Task01()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine("Input number: " + number);

    int tens = number / 10;
    int result = tens % 10; 
    Console.WriteLine("Middle number: " + result);
}
//Task01();

void Task02()
{
    Console.Write("Please enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    while(number > 999)
    {
        number = number / 10;
    }
    if (number < 100) Console.WriteLine("Third digit is empty");
    if (number <= 999 && number > 99) Console.WriteLine(number % 10);
    
}
//Task02();

void Task03()
{
    Console.Write("Enter number from 1 to 7: ");
    int number = Convert.ToInt32(Console.ReadLine());

    
    if (number == 6 || number == 7) 
    {
        Console.WriteLine("Holiday!!!");
    }
    else Console.WriteLine("Workday(((");
}
//Task03();
